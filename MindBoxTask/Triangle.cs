using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib
{
    public class Triangle : Figure, IAreaCalculabe
    {
        // В задаче не было указано, что именно будет являться стороной
        // Поэтому, я взял самое простое решение - длина стороны

        private double _firstSideLength;
        private double _secondSideLength;
        private double _thirdSideLength;

        public Triangle(string figureName, double firstSideLength, 
                        double secondSideLength, double thirdSideLength) : base(figureName)
        {
            if (firstSideLength < 0 || secondSideLength < 0 || thirdSideLength < 0)
                throw new ArgumentException("Sides length cant be less 0!");
            else if (!IsTriangleExist(firstSideLength, secondSideLength, thirdSideLength))
                throw new ArgumentException("Triangle with such values cannot exist!");
            else 
            {
                _firstSideLength = firstSideLength;
                _secondSideLength = secondSideLength;
                _thirdSideLength = thirdSideLength;
            }
        }

        /// <summary>
        /// Проверяет на существование треугольника
        /// </summary>
        /// <param name="firstSideLength">Первая стороная</param>
        /// <param name="secondSideLength">Вторая сторона</param>
        /// <param name="thirdSideLength">Третья сторона</param>
        /// <returns>Возвращает булево значение - существует/не существует</returns>
        public bool IsTriangleExist(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            return (firstSideLength < secondSideLength + thirdSideLength) &&
                   (secondSideLength < firstSideLength + thirdSideLength) &&
                   (thirdSideLength < firstSideLength + secondSideLength);
        }

        /// <summary>
        /// Для нахождения площади треугольника без высоты есть Формула Герона
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double CalculateFigureArea()
        {
            double halfPerimeter = (_firstSideLength + _secondSideLength + _thirdSideLength) / 2;
            double square = Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSideLength)
                                                    * (halfPerimeter - _secondSideLength)
                                                    * (halfPerimeter - _thirdSideLength));
            return Math.Round(square, 2);
        }

        /// <summary>
        /// Метод для проверки является ли треугольник прямоугольным. Применяется теорема Пифагора.
        /// </summary>
        /// <returns>Возвращает булево значение - является/не является прямоугольным</returns>
        public bool IsRectangular()
        {
            bool isRectangular = Math.Pow(_firstSideLength, 2) == Math.Pow(_secondSideLength, 2) + Math.Pow(_thirdSideLength, 2) ||
                                 Math.Pow(_secondSideLength, 2) == Math.Pow(_firstSideLength, 2) + Math.Pow(_thirdSideLength, 2) ||
                                 Math.Pow(_thirdSideLength, 2) == Math.Pow(_secondSideLength, 2) + Math.Pow(_firstSideLength, 2);
            return isRectangular;
        }
    }
}
