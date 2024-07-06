namespace Lab_TWO_WinAdd
{
    partial class FormChooseBackgroud
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
            this.buttonOnlyColor = new System.Windows.Forms.Button();
            this.buttonHatchingDackground = new System.Windows.Forms.Button();
            this.buttonGradientDackground = new System.Windows.Forms.Button();
            this.buttonPictureBack = new System.Windows.Forms.Button();
            this.buttonStarsBack = new System.Windows.Forms.Button();
            this.buttonPicture2Back = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // buttonOnlyColor
            // 
            this.buttonOnlyColor.Location = new System.Drawing.Point(14, 13);
            this.buttonOnlyColor.Name = "buttonOnlyColor";
            this.buttonOnlyColor.Size = new System.Drawing.Size(83, 33);
            this.buttonOnlyColor.TabIndex = 0;
            this.buttonOnlyColor.Text = "Color";
            this.buttonOnlyColor.UseVisualStyleBackColor = true;
            this.buttonOnlyColor.Click += new System.EventHandler(this.buttonOnlyColor_Click);
            // 
            // buttonHatchingDackground
            // 
            this.buttonHatchingDackground.Location = new System.Drawing.Point(101, 13);
            this.buttonHatchingDackground.Name = "buttonHatchingDackground";
            this.buttonHatchingDackground.Size = new System.Drawing.Size(83, 33);
            this.buttonHatchingDackground.TabIndex = 1;
            this.buttonHatchingDackground.Text = "Hatching";
            this.buttonHatchingDackground.UseVisualStyleBackColor = true;
            this.buttonHatchingDackground.Click += new System.EventHandler(this.buttonHatchingDackground_Click);
            // 
            // buttonGradientDackground
            // 
            this.buttonGradientDackground.Location = new System.Drawing.Point(190, 13);
            this.buttonGradientDackground.Name = "buttonGradientDackground";
            this.buttonGradientDackground.Size = new System.Drawing.Size(83, 34);
            this.buttonGradientDackground.TabIndex = 2;
            this.buttonGradientDackground.Text = "Gradient";
            this.buttonGradientDackground.UseVisualStyleBackColor = true;
            this.buttonGradientDackground.Click += new System.EventHandler(this.buttonGradientDackground_Click);
            // 
            // buttonPictureBack
            // 
            this.buttonPictureBack.Location = new System.Drawing.Point(14, 52);
            this.buttonPictureBack.Name = "buttonPictureBack";
            this.buttonPictureBack.Size = new System.Drawing.Size(83, 34);
            this.buttonPictureBack.TabIndex = 3;
            this.buttonPictureBack.Text = "Picture";
            this.buttonPictureBack.UseVisualStyleBackColor = true;
            this.buttonPictureBack.Click += new System.EventHandler(this.buttonPictureBack_Click);
            // 
            // buttonStarsBack
            // 
            this.buttonStarsBack.Location = new System.Drawing.Point(190, 52);
            this.buttonStarsBack.Name = "buttonStarsBack";
            this.buttonStarsBack.Size = new System.Drawing.Size(83, 34);
            this.buttonStarsBack.TabIndex = 4;
            this.buttonStarsBack.Text = "Stars";
            this.buttonStarsBack.UseVisualStyleBackColor = true;
            this.buttonStarsBack.Click += new System.EventHandler(this.buttonStarsBack_Click);
            // 
            // buttonPicture2Back
            // 
            this.buttonPicture2Back.Location = new System.Drawing.Point(103, 52);
            this.buttonPicture2Back.Name = "buttonPicture2Back";
            this.buttonPicture2Back.Size = new System.Drawing.Size(83, 34);
            this.buttonPicture2Back.TabIndex = 5;
            this.buttonPicture2Back.Text = "Picture 2";
            this.buttonPicture2Back.UseVisualStyleBackColor = true;
            this.buttonPicture2Back.Click += new System.EventHandler(this.buttonPicture2Back_Click);
            // 
            // FormChooseBackgroud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 93);
            this.Controls.Add(this.buttonPicture2Back);
            this.Controls.Add(this.buttonStarsBack);
            this.Controls.Add(this.buttonPictureBack);
            this.Controls.Add(this.buttonGradientDackground);
            this.Controls.Add(this.buttonHatchingDackground);
            this.Controls.Add(this.buttonOnlyColor);
            this.MaximumSize = new System.Drawing.Size(309, 140);
            this.MinimumSize = new System.Drawing.Size(309, 140);
            this.Name = "FormChooseBackgroud";
            this.Text = "Choose backgroud";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOnlyColor;
        private System.Windows.Forms.Button buttonHatchingDackground;
        private System.Windows.Forms.Button buttonGradientDackground;
        private System.Windows.Forms.Button buttonPictureBack;
        private System.Windows.Forms.Button buttonStarsBack;
        private System.Windows.Forms.Button buttonPicture2Back;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}