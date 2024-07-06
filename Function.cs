using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TWO_WinAdd
{
    // обьект класса хранить список функций и информацию о выводимой функции на панель
    public class Function
    {
        private int indexFunction;
        public List<IFunction> Functions;
        
        public Function()
        {
            this.Functions = new List<IFunction>
            {
                new Sin(),
                new Tan(),
                new Line(),
                new Deg2(),
                new Deg3()
            };

            this.indexFunction = 0;
        }

        public int IndexFunction{
            get
            {
                return this.indexFunction;
            }
            set
            {
                if(value > Functions.Count - 1 || value < 0)
                {
                    this.indexFunction = 0;
                }
                else
                {
                    this.indexFunction = value;
                }
            }
        }

        public void FunctionMean(float x, ReturnValues val)
        {
            this.Functions[this.indexFunction].Y(x, val);
        }
    }
}
