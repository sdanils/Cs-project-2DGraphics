using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TWO_WinAdd
{
    // обьект класса хранит информацию о сдвиге кадра относительно начала координат и информацию о масштабе вывода графика
    internal class GraphicInfo
    {
        public float scale;
        public float OxShift;
        public float OyShift;

        public GraphicInfo(float xShift, float yShift, float scale = 40)
        {
            this.scale = scale;
            this.OxShift = xShift;
            this.OyShift = yShift;
        }

        public string entedScale()
        {
            string returned = "Scale: " + Convert.ToString(this.scale); 
            return returned;
        }
    }
}
