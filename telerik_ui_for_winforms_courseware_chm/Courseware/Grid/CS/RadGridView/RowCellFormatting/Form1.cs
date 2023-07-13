using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;

namespace _13_ConditionalFormatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.CreditCard' table. You can move, or remove it, as needed.
            this.creditCardTableAdapter.Fill(this.adventureWorksDataSet.CreditCard);

            radGridView1.MasterTemplate.BestFitColumns();
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            // make sure the column is not the header and is a GridViewDataColumn
            if (e.CellElement.ColumnInfo is GridViewDataColumn && !(e.CellElement is GridHeaderCellElement))
            {
                GridViewDataColumn column = e.CellElement.ColumnInfo as GridViewDataColumn;
                // only make changes to the CardType column
                if (column.Name.Equals("CardType") && e.CellElement.RowInfo.Cells["ExpYear"].Value != null)
                {
                    // get value of the "ExpYear"
                    int year = (Int16)e.CellElement.RowInfo.Cells["ExpYear"].Value;
                    // make changes based on another column ("ExpYear") where the current 
                    // column contains "SuperiorCard"    
                    if ((year < 2008) && (e.CellElement.Text.Equals("SuperiorCard")))
                    {
                        // must set DrawFill for background colors to show!
                        e.CellElement.DrawFill = true;
                        // change any CellElement property
                        e.CellElement.BackColor = Color.PaleGreen;
                        e.CellElement.BackColor2 = Color.LightGreen;
                        e.CellElement.BackColor3 = Color.YellowGreen;
                        e.CellElement.BackColor4 = Color.Green;
                        e.CellElement.NumberOfColors = 4;
                        e.CellElement.GradientStyle = GradientStyles.OfficeGlassRect;
                    }
                    else
                    {
                        //must reset the visual modifications 
                        e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.BackColor3Property, ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.BackColor4Property, ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.NumberOfColorsProperty, ValueResetFlags.Local);
                        e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                    }
                }
            }
        }

        private void toggleButtonEnableAlternationRowColor_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radGridView1.EnableAlternatingRowColor = Convert.ToBoolean(args.ToggleState);
            //radGridView1.TableElement.AlternatingRowColor = Color.Yellow;
        }

        private void radGridView1_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (toggleButtonEnableAlternationRowColor.ToggleState == ToggleState.On)
            {
                if (e.RowElement.IsOdd)
                {
                    e.RowElement.DrawFill = true;
                    e.RowElement.BackColor = Color.LightGreen;
                    e.RowElement.BackColor2 = Color.PaleTurquoise;
                    e.RowElement.BackColor3 = Color.PaleGreen;
                    e.RowElement.BackColor4 = Color.SpringGreen;
                    e.RowElement.GradientStyle = GradientStyles.Vista;
                }
                else
                {
                    e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                    e.RowElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local);
                    e.RowElement.ResetValue(LightVisualElement.BackColor3Property, ValueResetFlags.Local);
                    e.RowElement.ResetValue(LightVisualElement.BackColor4Property, ValueResetFlags.Local);
                    e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                    e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                }
            }
        }
    }
}
