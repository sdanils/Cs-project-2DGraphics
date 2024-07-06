using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TWO_WinAdd
{
    class SliceFunctionDecorator : IFunction
    {
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
        public SliceFunctionDecorator(IFunction functions, float boardL, float boardR)
        {
            this.function = functions;
            this.BoardLeft = boardL;
            this.BoardRight = boardR;
        }
        public void Y(float x, ReturnValues val)
        {
            if(x > this.BoardLeft && x < this.BoardRight)
            {
                this.function.Y(x, val);
            }
            else
            {
                val.DrawingStatus = false; 
            }
        }

    }
}
