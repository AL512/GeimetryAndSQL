namespace Geometry
{
	/// <summary>
	/// Окружность
	/// </summary>
    public class Circle : Figure
    {
		double _radius;
		/// <summary>
		/// Радиус окружности
		/// </summary>
		public double Radius 
		{
			get => _radius;
			set => _radius = value > 0 ? value : throw new Exception($"Geometry.Circle({Name}): Радиус окружности меньше или равен 0. Значение:{value}");
		}
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="name">Имя окружности</param>
		/// <param name="radius">Радиус окружности</param>
		public Circle(string name, double radius) : base(name)
		{
			Radius = radius;
		}
		/// <summary>
		/// Вычисляет площадь окружности
		/// </summary>
		/// <param name="digits">Кол-во разрядов при округлении</param>
		/// <returns>Площадь окружности</returns>
		/// <exception cref="Exception"></exception>
		public double Square(int digits)
		{
			if (digits < 0 && digits > 15)
				throw new Exception($"Geometry.Circle({Name}): Для округления должно использоваться от 0 до 15 разрядов включительно. Значение:{digits}");
			Digits = digits;
			return Square();
		}
		/// <summary>
		/// Вычисляет площадь окружности
		/// </summary>
		/// <returns>Площадь окружности</returns>
		public override double Square()
		{
			return Math.Round(Math.PI * Math.Pow(Radius, 2), Digits);
		}
	}
}
