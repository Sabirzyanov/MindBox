using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib
{
    interface IAreaCalculabe
    {
        /// <summary>
        /// Интерфейс, для тех фигур, у которых можно вычислить площадь. 
        /// Например, у линии - нельзя.
        /// </summary>
        /// <returns>Вычисленная площадь фигуры</returns>
        public double CalculateFigureArea();
    }
}
