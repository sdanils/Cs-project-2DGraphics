namespace Lab_TWO_WinAdd
{
    partial class FormEntedBoards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBroadLeft = new System.Windows.Forms.TextBox();
            this.textBoxBroadRight = new System.Windows.Forms.TextBox();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.checkBoxRelockate = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labeldx = new System.Windows.Forms.Label();
            this.labeldy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBroadLeft
            // 
            this.textBoxBroadLeft.Location = new System.Drawing.Point(12, 12);
            this.textBoxBroadLeft.Name = "textBoxBroadLeft";
            this.textBoxBroadLeft.Size = new System.Drawing.Size(100, 22);
            this.textBoxBroadLeft.TabIndex = 0;
            this.textBoxBroadLeft.Text = "0";
            // 
            // textBoxBroadRight
            // 
            this.textBoxBroadRight.Location = new System.Drawing.Point(137, 12);
            this.textBoxBroadRight.Name = "textBoxBroadRight";
            this.textBoxBroadRight.Size = new System.Drawing.Size(100, 22);
            this.textBoxBroadRight.TabIndex = 1;
            this.textBoxBroadRight.Text = "0";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(9, 37);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(67, 16);
            this.labelLeft.TabIndex = 2;
            this.labelLeft.Text = "Left board";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(134, 37);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(77, 16);
            this.labelRight.TabIndex = 3;
            this.labelRight.Text = "Right board";
            // 
            // checkBoxRelockate
            // 
            this.checkBoxRelockate.AutoSize = true;
            this.checkBoxRelockate.Location = new System.Drawing.Point(12, 56);
            this.checkBoxRelockate.Name = "checkBoxRelockate";
            this.checkBoxRelockate.Size = new System.Drawing.Size(186, 20);
            this.checkBoxRelockate.TabIndex = 4;
            this.checkBoxRelockate.Text = "Relocation on mouse click";
            this.checkBoxRelockate.UseVisualStyleBackColor = true;
            this.checkBoxRelockate.CheckedChanged += new System.EventHandler(this.checkBoxRelockate_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // labeldx
            // 
            this.labeldx.AutoSize = true;
            this.labeldx.Location = new System.Drawing.Point(12, 112);
            this.labeldx.Name = "labeldx";
            this.labeldx.Size = new System.Drawing.Size(83, 16);
            this.labeldx.TabIndex = 7;
            this.labeldx.Text = "relocation dx";
            // 
            // labeldy
            // 
            this.labeldy.AutoSize = true;
            this.labeldy.Location = new System.Drawing.Point(134, 112);
            this.labeldy.Name = "labeldy";
            this.labeldy.Size = new System.Drawing.Size(84, 16);
            this.labeldy.TabIndex = 8;
            this.labeldy.Text = "relocation dy";
            // 
            // FormEntedBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 137);
            this.Controls.Add(this.labeldy);
            this.Controls.Add(this.labeldx);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxRelockate);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.textBoxBroadRight);
            this.Controls.Add(this.textBoxBroadLeft);
            this.Name = "FormEntedBoards";
            this.Text = "Boards slice";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEntedBoards_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBroadLeft;
        private System.Windows.Forms.TextBox textBoxBroadRight;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.CheckBox checkBoxRelockate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labeldx;
        private System.Windows.Forms.Label labeldy;
    }
}