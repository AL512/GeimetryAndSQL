using Geometry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Для расчета площади фигуры
    /// </summary>
    public static class FigureSquare
    {
        /// <summary>
        /// Расчет площади фигуры
        /// </summary>
        /// <param name="figureSquare">Интерфейс расчета блощади фигуры</param>
        /// <returns>Площадь фигуры</returns>
        public static double CalcSquare(IFigureSquare figureSquare)
        {
            return figureSquare.CalcSquare();
        }
        /// <summary>
        /// Расчет площади фигуры с заданной точностью
        /// </summary>
        /// <param name="figureSquare">Интерфейс расчета блощади фигуры</param>
        /// <param name="digits">Точность вычисления</param>
        /// <returns>Площадь фигуры</returns>
        public static double CalcSquare(IFigureSquare figureSquare, int digits)
        {
            return figureSquare.CalcSquare(digits);
        }
    }
}
