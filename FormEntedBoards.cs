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
    public partial class FormEntedBoards : Form
    {
        Function function;

        public FormEntedBoards(Function function)
        {
            InitializeComponent();
            this.function = function;
            this.KeyPreview = true;

            this.labeldx.Visible = false;
            this.labeldy.Visible = false;
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
        }

        private void FormEntedBoards_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float left = 0, right = 0;

                if(Single.TryParse(textBoxBroadLeft.Text, out left) && Single.TryParse(textBoxBroadRight.Text, out right))
                {
                    if (this.checkBoxRelockate.Checked == false)
                    {
                        SliceFunctionDecorator newFunction = new SliceFunctionDecorator(this.function.Functions[this.function.IndexFunction], left, right);
                        this.function.Functions.Add(newFunction);
                        this.function.IndexFunction = this.function.Functions.Count - 1;
                        this.Close();
                    }
                    else if(this.checkBoxRelockate.Checked == true)
                    {
                        float dx = 0, dy = 0;
                        if(Single.TryParse(textBox1.Text, out dx) && Single.TryParse(textBox2.Text, out dy))
                        {
                            SliceRelocationFunctionDecorator newFunction = new SliceRelocationFunctionDecorator(this.function.Functions[this.function.IndexFunction], left, right, dx, dy);
                            this.function.Functions.Add(newFunction);
                            this.function.IndexFunction = this.function.Functions.Count - 1;
                            this.Close();
                        }
                        else
                        {
                            if (dx == 0)
                            {
                                textBox1.BackColor = Color.Red;
                            }
                            if (dy == 0)
                            {
                                textBox1.BackColor = Color.Red;
                            }

                        }

                    }
                }
                else
                {
                    if(left == 0)
                    {
                        textBoxBroadLeft.BackColor = Color.Red;
                    }
                    if (right == 0)
                    {
                        textBoxBroadRight.BackColor = Color.Red;
                    }
                }
            }
        }

        private void checkBoxRelockate_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBoxRelockate.Checked == true)
            {
                this.labeldx.Visible = true;
                this.labeldy.Visible = true;
                this.textBox1.Visible = true;
                this.textBox2.Visible = true;
            }
            else if(this.checkBoxRelockate.Checked == false)
            {
                this.labeldx.Visible = false;
                this.labeldy.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
            }
        }
    }
}
