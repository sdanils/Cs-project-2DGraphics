using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_TWO_WinAdd
{
    public partial class FormGraphics : Form
    {
        Function usedFunction;
        // элементы для рисования
        Pen penGraph;
        Pen penLine;
        Pen penCircle;
        SolidBrush brushScale;
        Font fontScale;

        GraphicInfo grafInfo;

        BackgroundPanel backPanel;

        Point mousePosiotion;

        //original size elements
        PointF sizeButtFunc;
        PointF sizeButtColor;
        PointF sizeButtSave;
        PointF sizeButtBackground;
        PointF sizeGroupBox;
        PointF sizeForm;
        PointF sizePanel;

        bool initElements; //отслеживает создание всех элементов, для защиты от вызова FormGraphics_Resize в некорректный моментgпроверка

        public FormGraphics()
        {
            this.initElements = false;
            MyInitializeComponent();
            this.initElements = true;

            this.backPanel = new BackgroundPanel(this.panelForGraphics.Width, this.panelForGraphics.Height);

            this.grafInfo = new GraphicInfo(0, 0);

            this.sizeButtFunc.X = this.butRandFunc.Width;
            this.sizeButtFunc.Y = this.butRandFunc.Height;

            this.sizeButtColor.X = this.buttonColor.Width;
            this.sizeButtColor.Y = this.buttonColor.Height;

            this.sizeButtSave.X = this.buttonSave.Width;
            this.sizeButtSave.Y = this.buttonSave.Height;

            this.sizeButtBackground.X = this.buttonChangBackgorund.Width;
            this.sizeButtBackground.Y = this.buttonChangBackgorund.Height;

            this.sizeGroupBox.X = this.groupBox.Width;
            this.sizeGroupBox.Y = this.groupBox.Height;

            this.sizeForm.X = this.Width;
            this.sizeForm.Y = this.Height;

            this.sizePanel.X = this.panelForGraphics.Width;
            this.sizePanel.Y = this.panelForGraphics.Height;

            this.penGraph = new Pen(Color.Black, 3) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round };
            this.penLine = new Pen(Color.Black, 2) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round };
            this.penCircle = new Pen(Color.Black, 2) { DashStyle = DashStyle.Dash };
            this.usedFunction = new Function();
            this.fontScale = new Font("Arial", 10);
            this.brushScale = new SolidBrush(Color.Black);
        }

        private void butRandFunc_Click(object sender, EventArgs e)
        {
            Random randomChoiseFunc = new Random();
            this.usedFunction.IndexFunction = randomChoiseFunc.Next(0,usedFunction.Functions.Count);

            this.grafInfo = new GraphicInfo(0,0); // сбрасывается масштаб и сдвиг

            panelForGraphics.Invalidate();
        }

        private void panelForGraphics_Paint(object sender, PaintEventArgs e)
        {
            int width = panelForGraphics.Width, height = panelForGraphics.Height;

            Bitmap forPanel = new Bitmap(width, height);

            using (var graphic = Graphics.FromImage(forPanel))
            {
                //axis
                graphic.DrawLine(this.penLine, grafInfo.OxShift + width / 2, 0, grafInfo.OxShift + width / 2, height);
                graphic.DrawLine(this.penLine, 0, grafInfo.OyShift + height / 2, width, grafInfo.OyShift + height / 2);
                graphic.DrawEllipse(this.penCircle, grafInfo.OxShift + width / 2 - grafInfo.scale, grafInfo.OyShift + height / 2 - grafInfo.scale, 2 * grafInfo.scale, 2 * grafInfo.scale);
                //paint graphic
                float X1, X2, Y1, Y2;
                //
                ReturnValues _value = new ReturnValues();

                for (float x = 0; x < width / grafInfo.scale; x += 1f / grafInfo.scale)
                {
                    //координаты точек относительно начала панели
                    X1 = x * grafInfo.scale; 
                    X2 = (x * grafInfo.scale) + 1f / grafInfo.scale;

                    // x - width / (2 * grafInfo.scale) - grafInfo.OxShift / grafInfo.scale координаты точек относительно начала координат
                    this.usedFunction.FunctionMean(x - width / (2 * grafInfo.scale) - grafInfo.OxShift / grafInfo.scale, _value);
                    if (_value.DrawingStatus == true) // проверка на статус точки
                    {
                        Y1 = grafInfo.scale * _value.Values + grafInfo.OyShift + height / 2;
                    }
                    else
                    {
                        continue;
                    }

                    this.usedFunction.FunctionMean(x + 1f / grafInfo.scale - width / (2 * grafInfo.scale) - grafInfo.OxShift / grafInfo.scale, _value);
                    if(_value.DrawingStatus == true) // проверка на статус точки
                    {
                        Y2 = grafInfo.scale * _value.Values + grafInfo.OyShift + height / 2;
                    }
                    else
                    {
                        continue;
                    }

                    if (Y1 - Y2 > -100)
                    {
                        graphic.DrawLine(this.penGraph, X1, Y1, X2, Y2);
                    }
                    else
                    {
                        if (this.usedFunction.IndexFunction != 3)
                        {
                            if (grafInfo.OyShift * grafInfo.OyShift > height * height || grafInfo.scale < 40) //Рисую вблизи точек разрыва при необходимости.
                            {
                                graphic.DrawLine(this.penGraph, X1, Y1, X2, 0);
                                graphic.DrawLine(this.penGraph, X1, height, X2, Y2);
                            }
                        }
                    }
                }
                //ented scale
                if (this.grafInfo.scale > 5)
                {
                    graphic.DrawString(this.grafInfo.entedScale(), this.fontScale, this.brushScale, width - 80, 30);
                }
            }
            //paint background
            if (this.backPanel.indexCustomBackground != 0)
            {
                this.panelForGraphics.BackgroundImage = this.backPanel.GetImageBackground();
            }

            e.Graphics.DrawImageUnscaled(forPanel, Point.Empty);
        }    

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.penGraph.Color = colorDialog.Color;
                this.panelForGraphics.Invalidate();
            }
        }

        private void FormGraphics_Resize(object sender, EventArgs e)
        {
            if (this.initElements && this.Width > 600) 
            {
                float resizeKx = this.Width / this.sizeForm.X;
                float resizeKy = this.Height / this.sizeForm.Y;

                this.groupBox.Width = (int)(sizeGroupBox.X * resizeKx);
                this.groupBox.Height = (int)(sizeGroupBox.Y * resizeKy);

                this.butRandFunc.Width = (int)(sizeButtFunc.X * resizeKx);
                this.butRandFunc.Height = (int)(sizeButtFunc.Y * resizeKy);

                this.buttonColor.Width = (int)(sizeButtColor.X * resizeKx);
                this.buttonColor.Height = (int)(sizeButtColor.Y * resizeKy);

                this.buttonSave.Width = (int)(sizeButtSave.X * resizeKx);
                this.buttonSave.Height = (int)(sizeButtSave.Y * resizeKy);

                this.buttonChangBackgorund.Width = (int)(sizeButtBackground.X * resizeKx);
                this.buttonChangBackgorund.Height = (int)(sizeButtBackground.Y * resizeKy);

                this.panelForGraphics.Width = (int)(sizePanel.X * resizeKx);
                this.panelForGraphics.Height = (int)(sizePanel.Y * resizeKy);


                if (this.buttonColor.Top - this.butRandFunc.Bottom < 0)
                {
                    this.buttonColor.Top += this.butRandFunc.Bottom - this.buttonColor.Top + 5;
                }
                if (this.buttonChangBackgorund.Top - this.buttonColor.Bottom < 0)
                {
                    this.buttonChangBackgorund.Top += this.buttonColor.Bottom - this.buttonChangBackgorund.Top + 5;
                }
                if (this.buttonSave.Top - this.buttonChangBackgorund.Bottom < 0)
                {
                    this.buttonSave.Top += this.buttonChangBackgorund.Bottom - this.buttonSave.Top + 5;
                }

                this.grafInfo.OxShift = 0;
                this.grafInfo.OyShift = 0;

                this.backPanel.SetNewSizePanel(panelForGraphics.Width, panelForGraphics.Height);

                panelForGraphics.Invalidate();
            }
        }

        private void panelForGraphics_MouseWheel(object sender, MouseEventArgs e)
        {
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines;
            int dScale = 1;

            if(this.grafInfo.scale > 50 && this.grafInfo.scale < 80)
            {
                dScale = 3;
            }
            else if(this.grafInfo.scale > 80 && this.grafInfo.scale < 110)
            {
                dScale = 5;
            }
            else if (this.grafInfo.scale > 110 && this.grafInfo.scale < 140)
            {
                dScale = 7;
            }
            else if (this.grafInfo.scale > 140)
            {
                dScale = 9;
            }

            if (numberOfTextLinesToMove > 0)
            { 
                this.grafInfo.scale += dScale;
            }
            else if(numberOfTextLinesToMove < 0 && this.grafInfo.scale > 5)
            {
                this.grafInfo.scale -= dScale;
            }

            panelForGraphics.Invalidate();
        }

        private void panelForGraphics_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = (-1) * (this.mousePosiotion.X - e.X);
                int dy = (-1) * (this.mousePosiotion.Y - e.Y);

                this.grafInfo.OxShift += dx;
                this.grafInfo.OyShift += dy;

                panelForGraphics.Invalidate();

                this.mousePosiotion.Y = e.Y;
                this.mousePosiotion.X = e.X;
            }
        }

        private void panelForGraphics_MouseDown(object sender, MouseEventArgs e)
        {
            this.mousePosiotion.Y = e.Y;
            this.mousePosiotion.X = e.X;
        }

        private void buttonChangBackgorund_Click(object sender, EventArgs e)
        {
            Form formChangeBack = new FormChooseBackgroud((DoubleBufferedPanel)this.panelForGraphics, this.backPanel);
            formChangeBack.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.Filter = ".png|";
            this.saveFileDialog.InitialDirectory = "C:\\Users\\banil\\OneDrive\\Рабочий стол\\Visual Code\\ForGraphics";
            this.saveFileDialog.DefaultExt = "png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                Bitmap savePicture = new Bitmap(this.panelForGraphics.Width, this.panelForGraphics.Height);
                this.panelForGraphics.DrawToBitmap(savePicture, panelForGraphics.ClientRectangle);

                savePicture.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            }           
        }

        private void FormGraphics_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                Form formlogin = new FormEntedBoards(usedFunction);
                formlogin.ShowDialog();
                this.panelForGraphics.Invalidate();
            }
        }
    }
}

































/*private void panelForGraphics_Paint(object sender, PaintEventArgs e)
        {
            int width = panelForGraphics.Width, height = panelForGraphics.Height;

            Bitmap forPanel = new Bitmap(width, height);

            using (var graphic = Graphics.FromImage(forPanel))
            {
                //axis
                graphic.DrawLine(this.penLine, grafInfo.OxShift, 0, grafInfo.OxShift, height);
                graphic.DrawLine(this.penLine, 0, grafInfo.OyShift, width, grafInfo.OyShift);
                graphic.DrawEllipse(this.penCircle, grafInfo.OxShift - grafInfo.scale, grafInfo.OyShift - grafInfo.scale, 2 * grafInfo.scale, 2 * grafInfo.scale);
                //paint graphic
                for (float x = -width; x < width; x += 0.10f)
                {
                    if(this.usedFunction.FunctionMean(x) - this.usedFunction.FunctionMean(x + 0.10f) < 30 && this.usedFunction.FunctionMean(x) - this.usedFunction.FunctionMean(x + 0.10f) > -30)
                        graphic.DrawLine(this.penGraph, x * grafInfo.scale + grafInfo.OxShift, (grafInfo.scale * this.usedFunction.FunctionMean(x) + grafInfo.OyShift), ((x + 0.10f) * grafInfo.scale) + grafInfo.OxShift, (grafInfo.scale * this.usedFunction.FunctionMean(x + 0.10f) + grafInfo.OyShift));
                }
                //ented scale
                if(this.grafInfo.scale > 6)
                {
                    graphic.DrawString(this.grafInfo.entedScale(), this.fontScale, this.brushScale, width - 80, 30);
                }
            }
            //paint background
            if(this.backPanel.indexCustomBackground != 0)
            {
                this.panelForGraphics.BackgroundImage = this.backPanel.GetImageBackground();
            }

            e.Graphics.DrawImageUnscaled(forPanel, Point.Empty);
        }*/