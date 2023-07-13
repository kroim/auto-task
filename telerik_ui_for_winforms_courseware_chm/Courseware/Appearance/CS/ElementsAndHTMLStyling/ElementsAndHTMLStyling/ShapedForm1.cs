using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace AnimatedProperty
{
    public partial class ShapedForm1 : Telerik.WinControls.UI.ShapedForm
    {
        public ShapedForm1()
        {
            InitializeComponent();
        }

        private void ShapedForm1_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Aqua";
            ThemeList list = ThemeResolutionService.GetAvailableThemes(radTitleBar1);

            lblTitle.Text =
              "<html>" +
              "<size=11><b><color=1,78,194><font=Papyrus>Blue Sky Travel Planning</b>" +
              "<br>" +
              "<size=10><color=72,173,229><font=Narkisim>Get where you're going";
        }
    }
}