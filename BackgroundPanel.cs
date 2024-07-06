using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_TWO_WinAdd
{
    // обьект класса хранит Bitmap изображение для фона панели и инофрмацию о виде фона
    public class BackgroundPanel
    {
        private Bitmap background;
        public int indexCustomBackground; // 0 - default back

        public BackgroundPanel(int widht, int height)
        {
            this.background = new Bitmap(widht, height);
            this.indexCustomBackground = 0;
        }

        public void BrushBackround(Color color)
        {
            Bitmap newBack = new Bitmap(this.background.Width, this.background.Height);
            this.background = newBack;

            using (var graphic = Graphics.FromImage(this.background))
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    graphic.FillRectangle(brush, 0, 0, background.Width, background.Height);
                }
            }

            if (color == Color.White)
            {
                this.indexCustomBackground = 0;
            }
            else if(color != Color.White)
            {
                this.indexCustomBackground = 1;
            }
        } // заливка фона цветом

        public void HatchingBackground()
        {
            Bitmap newBack = new Bitmap(this.background.Width, this.background.Height);
            this.background = newBack;

            using (var graphic = Graphics.FromImage(this.background))
            {
                for (float y = 0; y < 2*background.Width; y += 10)
                {
                    graphic.DrawLine(new Pen(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot }, y, 0, 0, y);
                }
            }

            this.indexCustomBackground = 2;
        }// штриховка фона

        public void GradientBackground()
        {
            Bitmap newBack = new Bitmap(this.background.Width, this.background.Height);
            this.background = newBack;

            using (var graphic = Graphics.FromImage(this.background))
            {
                int shade = 0;

                for (float y = 0; y < background.Height; y += background.Height/255 + 1)
                {
                    graphic.DrawLine(new Pen(Color.FromArgb(255, 0, shade++), background.Height / 255 + 1), 0, y, background.Width, y);
                }
            }

            this.indexCustomBackground = 3;
        } // градиент фона

        public void SetImageBackground()
        {
            Bitmap image = (Bitmap)Image.FromFile("C://Users//banil//source//repos//Lab_TWO_WinAdd//Lab_TWO_WinAdd//imageOne.jpg");

            Bitmap newBack = new Bitmap(image.Width, image.Height);
            this.background = newBack;

            using (var graphic = Graphics.FromImage(this.background))
            {
                graphic.DrawImage((Image)image, 0, 0);
            }

            this.indexCustomBackground = 4;
        }// Натягивает на фон изображение
        public void DrowIconBack()
        {
            Bitmap newBack = new Bitmap(this.background.Width, this.background.Height);
            this.background = newBack;

            Bitmap image = (Bitmap)Image.FromFile("C://Users//banil//source//repos//Lab_TWO_WinAdd//Lab_TWO_WinAdd//imageIcon.jpg");

            using (var graphic = Graphics.FromImage(this.background))
            {
                graphic.DrawImage((Image)image, 0, this.background.Height - image.Height/1.3f);
            }

            this.indexCustomBackground = 5;
        }// рисует иконку в нижнем углу фона

        public void StrarsBackground()
        {
            Random PositionStar = new Random();
            Pen penStars = new Pen(Color.White);

            Bitmap newBack = new Bitmap(this.background.Width, this.background.Height);
            this.background = newBack;

            using (var graphic = Graphics.FromImage(this.background))
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 7, 71)))
                {
                    graphic.FillRectangle(brush, 0, 0, background.Width, background.Height);
                }

                for (int posX = 0; posX < this.background.Width; posX += 50)
                {
                    for (int posY = 0; posY < this.background.Height; posY += 50)
                    {
                        graphic.DrawRectangle(penStars, PositionStar.Next(posX, posX + 50), PositionStar.Next(posY, posY + 50), 2, 2);
                    }
                }
            }

            this.indexCustomBackground = 6;
        }// рисует звездное небо
        public void SetNewSizePanel(int widht, int height)
        {
            if(this.indexCustomBackground == 0)
            {
                this.background = new Bitmap(widht, height);
                return;
            }
            else if(this.indexCustomBackground == 1)
            {
                Color color = this.background.GetPixel(1, 1);
                this.background = new Bitmap(widht, height);

                this.BrushBackround(color);
            }
            else if(this.indexCustomBackground == 2)
            {
                this.background = new Bitmap(widht, height);
                this.HatchingBackground();
            }
            else if (this.indexCustomBackground == 3)
            {
                this.background = new Bitmap(widht, height);
                this.GradientBackground();
            }
            else if(this.indexCustomBackground == 4)
            {
                this.background = new Bitmap(widht, height);
                this.SetImageBackground();
            }
            else if(this.indexCustomBackground == 5)
            {
                this.background = new Bitmap(widht, height);
                this.DrowIconBack();
            }
            else if (this.indexCustomBackground == 6)
            {
                this.background = new Bitmap(widht, height);
                this.StrarsBackground();
            }
        }// изменяет размер фона при растягивании и перерисовывает фон
        public Image GetImageBackground()
        {
            return (Image)this.background;
        } // возвращает Image в Bitmap

    }
}
