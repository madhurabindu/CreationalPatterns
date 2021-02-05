using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base.GUIControls;

namespace GUIControls.LightTheme
{
    public partial class LightImageButton : ImageButton
    {
        public LightImageButton()
        {
            InitializeComponent();
            this.TileButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
    }
}
