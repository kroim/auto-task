using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace _15_CustomCells
{
    public class ColorSwatchCellElement : GridDataCellElement
    {
        public ColorSwatchCellElement(GridViewColumn column, GridRowElement row) :
        base(column, row)
        {
        }
       
        private LightVisualElement _swatch;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            _swatch = new LightVisualElement();
            _swatch.DrawFill = true;
            _swatch.Font = new Font("Arial", 7F, FontStyle.Regular);
            _swatch.Shape = new RoundRectShape(5);
            _swatch.GradientStyle = GradientStyles.Linear;
            _swatch.NumberOfColors = 2;
            _swatch.MouseDown -= new MouseEventHandler(_swatch_MouseDown);
            _swatch.MouseDown += new MouseEventHandler(_swatch_MouseDown);
            this.Children.Add(_swatch);
        }

       
        protected override void SetContentCore(object value)
        {
            // blank out the cell's text, only show on swatch element
            this.Text = "";
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);
            //size the element according to the cell size
            _swatch.Arrange(new RectangleF(3, 3, finalSize.Width - 6, finalSize.Height - 6));
            return finalSize;
        }

        public override void SetContent()
        {
            base.SetContent();

            // set default properties
            _swatch.BackColor = Color.White;
            _swatch.BackColor2 = Color.White;
            _swatch.Text = String.Empty;

            // only process if there is a value and its not "Transparent"
            if (!this.Value.Equals(System.DBNull.Value) &&
                (!this.Value.ToString().Equals("Transparent")))
            {
                string colorName = this.Value.ToString();
                // convert to a Color type and assign to background color
                _swatch.BackColor2 = Color.FromName(colorName);
                // set the readable color name
                _swatch.Text = colorName;
            }

            // get the size of the color name string
            if (this.ElementTree != null)
            {
                SizeF size = SizeF.Empty;
                using (Graphics g = this.ElementTree.Control.CreateGraphics())
                {
                    size = g.MeasureString(_swatch.Text, this.Font);
                }
            
                // get the current column width
                int width = this.GridControl.Columns[this.ColumnIndex].Width;
                // set column width to use the column or measured 
                // color name string width, whichever is widest
                this.GridControl.Columns[this.ColumnIndex].Width = Math.Max(width, (int)size.Width);
            }
        }

        void _swatch_MouseDown(object sender, MouseEventArgs e)
        {
            // configure color dialog to only show web colors
            RadColorDialog colorDialog = new RadColorDialog();
            colorDialog.ColorDialogForm.ShowBasicColors = false;
            colorDialog.ColorDialogForm.ShowProfessionalColors = false;
            colorDialog.ColorDialogForm.ShowSystemColors = false;
            colorDialog.ColorDialogForm.ShowCustomColors = false;
            colorDialog.ColorDialogForm.ShowHEXColorValue = false;
            colorDialog.ColorDialogForm.AllowColorPickFromScreen = false;
            colorDialog.ColorDialogForm.AllowColorSaving = false;
            colorDialog.ColorDialogForm.WebTabHeading = "Swatch Colors";

            // set initial dialog color
            colorDialog.SelectedColor = _swatch.BackColor2;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // set value to known color name of selected color
                this.Value = GetColorName(colorDialog.SelectedColor);
            }
        }

        public string GetColorName(Color color)
        {
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                // only look for web colors, not system colors
                if ((knownColor > KnownColor.Transparent) && (knownColor < KnownColor.ButtonFace))
                {
                    if (color.ToArgb() == Color.FromKnownColor(knownColor).ToArgb())
                    {
                        return knownColor.ToString();
                    }
                }
            }
            return KnownColor.Transparent.ToString();
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is ColorSwatchColumn && context is GridDataRowElement;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }
    }
}