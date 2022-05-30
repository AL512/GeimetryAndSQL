namespace Geometry
{
	/// <summary>
	/// Базовый класс абстрактной фигуры
	/// </summary>
	public abstract class Figure
    {
		/// <summary>
		/// Имя фигуры
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Точность округления
		/// </summary>
		private protected int Digits = 2;
		/// <summary>
		/// Конструктор абстрактной фигуры
		/// </summary>
		/// <param name="name">Имя фигуры</param>
		public Figure(string name)
		{
			Name = name?.Length > 0 ? Name = name : $"Figure {DateTime.Now.ToString("ddMMYYYHHmmss")}";
		}
		/// <summary>
		/// Площадь фигуры
		/// </summary>
		/// <returns>Площадь фигуры</returns>
		public abstract double Square();
	}
}