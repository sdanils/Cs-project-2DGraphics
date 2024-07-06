using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TWO_WinAdd
{
    public class ReturnValues
    {
        float values;
        bool drawingStatus;

        public float Values
        {
            get
            {
                return values;

            }
            set
            {
                values = value;
            }
        }

        public bool DrawingStatus {
            get
            { 
                return drawingStatus;
            } 
            set
            { 
                drawingStatus = value;
            }
        }

        public ReturnValues()
        {
            this.DrawingStatus = true;
        }
    }
}
