using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Interfaces
{
    /// <summary>
	/// Расчет площади фигуры
	/// </summary>
	public interface IFigureSquare
    {
		/// <summary>
		/// Вычисляет площадь фигуры
		/// </summary>
		/// <param name="digits">Кол-во разрядов при округлении</param>
		/// <returns>Площадь</returns>
		public double CalcSquare(int digits = 2);
	}
}
