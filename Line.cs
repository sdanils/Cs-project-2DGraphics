using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TWO_WinAdd
{
    internal class Line : IFunction
    {
        public void Y(float x, ReturnValues val)
        {
            val.DrawingStatus = true;
            val.Values = (-1)*(2 * x + 5);
        }
    }

}
