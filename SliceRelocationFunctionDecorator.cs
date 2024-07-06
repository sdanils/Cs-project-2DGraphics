using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TWO_WinAdd
{
    internal class SliceRelocationFunctionDecorator : IFunction
    {
        float dx;
        float dy;

        public IFunction function;

        float boardLeft;
        float boardRight;

        public float BoardLeft
        {
            get
            {
                return this.boardLeft;
            }
            set
            {
                this.boardLeft = value;
            }
        }
        public float BoardRight
        {
            get
            {
                return this.boardRight;
            }
            set
            {
                this.boardRight = value;
            }
        }

        public SliceRelocationFunctionDecorator(IFunction functions, float boardL, float boardR, float dx, float dy)
        {
            this.dx = dx;
            this.dy = dy;
            this.function = functions;
            this.BoardLeft = boardL;
            this.BoardRight = boardR;
        }

        public void Y(float x, ReturnValues val)
        {
                if (x - dx > this.BoardLeft && x - dx < this.BoardRight)
                {
                    this.function.Y(x - dx, val);
                    val.Values -= dy;
                }
                else
                {
                    val.DrawingStatus = false;
                }         
        }


    }
}
