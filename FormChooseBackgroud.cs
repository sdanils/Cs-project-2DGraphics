using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_TWO_WinAdd
{
    public partial class FormChooseBackgroud : Form
    {
        DoubleBufferedPanel panelForGraphic;
        BackgroundPanel backPanel;

        public FormChooseBackgroud(DoubleBufferedPanel panel, BackgroundPanel backPanel)
        {
            InitializeComponent();
            this.panelForGraphic = panel;
            this.backPanel = backPanel;

        }

        private void buttonOnlyColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.backPanel.BrushBackround(colorDialog1.Color);
                this.panelForGraphic.Invalidate();
            }
        }

        private void buttonHatchingDackground_Click(object sender, EventArgs e)
        {
            this.backPanel.HatchingBackground();
            this.panelForGraphic.Invalidate();
        }

        private void buttonGradientDackground_Click(object sender, EventArgs e)
        {
            this.backPanel.GradientBackground();
            this.panelForGraphic.Invalidate();
        }

        private void buttonPictureBack_Click(object sender, EventArgs e)
        {
            this.backPanel.SetImageBackground();
            this.panelForGraphic.Invalidate();
        }

        private void buttonPicture2Back_Click(object sender, EventArgs e)
        {
            this.backPanel.DrowIconBack();
            this.panelForGraphic.Invalidate();
        }

        private void buttonStarsBack_Click(object sender, EventArgs e)
        {
            this.backPanel.StrarsBackground();
            this.panelForGraphic.Invalidate();
        }
    }
}
