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
        public static double Square(IFigureSquare figureSquare)
        {
            return figureSquare.CalcSquare();
        }
    }
}
