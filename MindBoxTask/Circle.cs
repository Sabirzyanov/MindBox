using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib
{
    public class Circle : Figure, IAreaCalculabe
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
        }

        public Circle(string figureName, double radius) : base(figureName)
        {
            _radius = radius;
        }

        /// <summary>
        /// Для нахождения площади окружности
        /// </summary>
        /// <returns></returns>
        public double CalculateFigureArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }
    }
}
