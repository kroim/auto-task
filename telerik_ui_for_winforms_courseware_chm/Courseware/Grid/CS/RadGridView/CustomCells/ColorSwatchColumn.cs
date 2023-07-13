using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace _15_CustomCells
{
    class ColorSwatchColumn : GridViewDataColumn
    {
        public ColorSwatchColumn(string fieldName)
            : base(fieldName)
        {

        }

        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewDataRowInfo)
            {
                return typeof(ColorSwatchCellElement);
            }
            return base.GetCellType(row);
        }
    }
}
