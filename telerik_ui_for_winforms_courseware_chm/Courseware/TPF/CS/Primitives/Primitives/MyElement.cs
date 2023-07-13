using System.Drawing; // supports Size, Color
using Telerik.WinControls; // supports RadItem
using Telerik.WinControls.UI; // supports RadTextBoxElement
using Telerik.WinControls.Primitives; // supports FillPrimitive, TextPrimitive
using Telerik.WinControls.Layouts;
using System; // supports StripLayout, StackedLayout, etc

namespace Primitives
{
    public class MyElement : RadItem
    {
        protected override void CreateChildElements()
        {
            Array gradientStyleValues = Enum.GetValues(typeof(GradientStyles));
            StackLayoutPanel layoutPanel = new StackLayoutPanel();
            layoutPanel.Orientation = System.Windows.Forms.Orientation.Vertical;

            foreach (GradientStyles gradientStyle in gradientStyleValues)
            {
                StackLayoutPanel panel = new StackLayoutPanel();
                panel.Orientation = System.Windows.Forms.Orientation.Vertical;
                panel.Margin = new System.Windows.Forms.Padding(20, 1, 20, 0);

                TextPrimitive textPrimitive = new TextPrimitive();
                textPrimitive.Text = gradientStyle.ToString("g");
                textPrimitive.Font = new Font("Arial", 10f);
                textPrimitive.ForeColor = Color.Black;
                textPrimitive.Shadow = new Telerik.WinControls.Paint.ShadowSettings(
                  new Point(1, 1), Color.DarkGray);
                panel.Children.Add(textPrimitive);

                FillPrimitive fillPrimitive = new FillPrimitive();
                fillPrimitive.MinSize = new Size(0, 20);
                fillPrimitive.NumberOfColors = 4;
                fillPrimitive.GradientStyle = gradientStyle;
                fillPrimitive.BackColor = Color.Blue;
                fillPrimitive.BackColor2 = Color.BlueViolet;
                fillPrimitive.BackColor3 = Color.Violet;
                fillPrimitive.BackColor4 = Color.Red;
                panel.Children.Add(fillPrimitive);

                layoutPanel.Children.Add(panel);
            }
            this.Children.Add(layoutPanel);
            base.CreateChildElements();
        }
    }
}