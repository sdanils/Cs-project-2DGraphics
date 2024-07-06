using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TWO_WinAdd
{
    // интерфейс функций
    public interface IFunction
    {
        void Y(float x, ReturnValues val); // Использую один обьек, для записи туда результата по всем Х, что бы не создавать огромное кол-во обьектов
    }
}
