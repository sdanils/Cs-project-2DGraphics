using System.Drawing;
using System.Windows.Forms;

namespace Lab_TWO_WinAdd
{
    partial class FormGraphics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChangBackgorund = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.butRandFunc = new System.Windows.Forms.Button();
            this.panelForGraphics = new System.Windows.Forms.Panel();
            this.doubleBufferedPanel2 = new Lab_TWO_WinAdd.DoubleBufferedPanel();
            this.doubleBufferedPanel1 = new Lab_TWO_WinAdd.DoubleBufferedPanel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox.SuspendLayout();
            this.panelForGraphics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonSave);
            this.groupBox.Controls.Add(this.buttonChangBackgorund);
            this.groupBox.Controls.Add(this.buttonColor);
            this.groupBox.Controls.Add(this.butRandFunc);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox.Location = new System.Drawing.Point(971, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(194, 587);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Elements";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(17, 188);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 43);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save graphic";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChangBackgorund
            // 
            this.buttonChangBackgorund.Location = new System.Drawing.Point(17, 139);
            this.buttonChangBackgorund.Name = "buttonChangBackgorund";
            this.buttonChangBackgorund.Size = new System.Drawing.Size(95, 43);
            this.buttonChangBackgorund.TabIndex = 1;
            this.buttonChangBackgorund.Text = "Change backgrounb";
            this.buttonChangBackgorund.UseVisualStyleBackColor = true;
            this.buttonChangBackgorund.Click += new System.EventHandler(this.buttonChangBackgorund_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(17, 90);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(95, 43);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Change color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // butRandFunc
            // 
            this.butRandFunc.Location = new System.Drawing.Point(17, 35);
            this.butRandFunc.Name = "butRandFunc";
            this.butRandFunc.Size = new System.Drawing.Size(95, 49);
            this.butRandFunc.TabIndex = 0;
            this.butRandFunc.Text = "Random function";
            this.butRandFunc.UseVisualStyleBackColor = true;
            this.butRandFunc.Click += new System.EventHandler(this.butRandFunc_Click);
            // 
            // panelForGraphics
            // 
            this.panelForGraphics.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.panelForGraphics.Controls.Add(this.doubleBufferedPanel2);
            this.panelForGraphics.Controls.Add(this.doubleBufferedPanel1);
            this.panelForGraphics.Location = new System.Drawing.Point(0, 0);
            this.panelForGraphics.Name = "panelForGraphics";
            this.panelForGraphics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelForGraphics.Size = new System.Drawing.Size(967, 734);
            this.panelForGraphics.TabIndex = 1;
            this.panelForGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForGraphics_Paint);
            this.panelForGraphics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForGraphics_MouseDown);
            // 
            // doubleBufferedPanel2
            // 
            this.doubleBufferedPanel2.Location = new System.Drawing.Point(34, 174);
            this.doubleBufferedPanel2.Name = "doubleBufferedPanel2";
            this.doubleBufferedPanel2.Size = new System.Drawing.Size(8, 8);
            this.doubleBufferedPanel2.TabIndex = 1;
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.Location = new System.Drawing.Point(10, 112);
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            this.doubleBufferedPanel1.Size = new System.Drawing.Size(8, 8);
            this.doubleBufferedPanel1.TabIndex = 0;
            // 
            // FormGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 587);
            this.Controls.Add(this.panelForGraphics);
            this.Controls.Add(this.groupBox);
            this.Name = "FormGraphics";
            this.Text = "Graphics";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGraphics_KeyDown);
            this.Resize += new System.EventHandler(this.FormGraphics_Resize);
            this.groupBox.ResumeLayout(false);
            this.panelForGraphics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void MyInitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonChangBackgorund = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.butRandFunc = new System.Windows.Forms.Button();
            this.panelForGraphics = new DoubleBufferedPanel();          // использую панель с двойной буферизацией
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonChangBackgorund);
            this.groupBox.Controls.Add(this.buttonColor);
            this.groupBox.Controls.Add(this.butRandFunc);
            this.groupBox.Controls.Add(this.buttonSave);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox.Location = new System.Drawing.Point(973, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(124, 734);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Elements";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(17, 90);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(95, 43);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Change color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // butRandFunc
            // 
            this.butRandFunc.Location = new System.Drawing.Point(17, 35);
            this.butRandFunc.Name = "butRandFunc";
            this.butRandFunc.Size = new System.Drawing.Size(95, 49);
            this.butRandFunc.TabIndex = 0;
            this.butRandFunc.Text = "Random function";
            this.butRandFunc.UseVisualStyleBackColor = true;
            this.butRandFunc.Click += new System.EventHandler(this.butRandFunc_Click);
            // 
            // panelForGraphics
            // 
            this.panelForGraphics.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.panelForGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForGraphics.Location = new System.Drawing.Point(0, 0);
            this.panelForGraphics.Name = "panelForGraphics";
            this.panelForGraphics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelForGraphics.Size = new System.Drawing.Size(967, 734);
            this.panelForGraphics.TabIndex = 1;
            this.panelForGraphics.Dock = DockStyle.Fill;
            this.panelForGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForGraphics_Paint);
            this.panelForGraphics.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panelForGraphics_MouseWheel);
            this.panelForGraphics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForGraphics_MouseDown);
            this.panelForGraphics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelForGraphics_MouseMove);
            this.panelForGraphics.BackgroundImageLayout = ImageLayout.Stretch;
            // 
            // buttonChangBackgorund
            // 
            this.buttonChangBackgorund.Location = new System.Drawing.Point(17, 139);
            this.buttonChangBackgorund.Name = "buttonChangBackgorund";
            this.buttonChangBackgorund.Size = new System.Drawing.Size(95, 43);
            this.buttonChangBackgorund.TabIndex = 1;
            this.buttonChangBackgorund.Text = "Change backgrounb";
            this.buttonChangBackgorund.UseVisualStyleBackColor = true;
            this.buttonChangBackgorund.Click += new System.EventHandler(this.buttonChangBackgorund_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(17, 188);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 43);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save graphic";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 734);
            this.Controls.Add(this.panelForGraphics);
            this.Controls.Add(this.groupBox);
            this.Name = "FormGraphics";
            this.Text = "Graphics";
            this.Resize += new System.EventHandler(this.FormGraphics_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGraphics_KeyDown);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.KeyPreview= true;

            //

            this.MinimumSize = new Size(250, 250);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panelForGraphics;
        private System.Windows.Forms.Button butRandFunc;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Button buttonChangBackgorund;
        private Button buttonSave;
        private SaveFileDialog saveFileDialog;
        private DoubleBufferedPanel doubleBufferedPanel2;
        private DoubleBufferedPanel doubleBufferedPanel1;
    }
}

