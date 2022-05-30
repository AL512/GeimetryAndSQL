namespace Geometry
{
    /// <summary>
	/// Треугольник
	/// </summary>
	public class Triangle : Figure
    {
		private double _a;
		/// <summary>
		/// Сторона А
		/// </summary>
		public double A 
		{
			get => _a;
			set => Set(ref _a, value);
		}

		private double _b;
		/// <summary>
		/// Сторона В
		/// </summary>
		public double B 
		{
			get => _b;
			set => Set(ref _b, value);
		}

		private double _c;
		/// <summary>
		/// Сторона С
		/// </summary>
		public double C 
		{
			get => _c;
			set => Set(ref _c, value);
		}
		/// <summary>
		/// Задает значение стороны
		/// </summary>
		/// <param name="param">Параметр (сторона треугольника)</param>
		/// <param name="value">Значение</param>
		/// <exception cref="Exception"></exception>
		private void Set(ref double param, double value)
        {
			if (param == value) return;
			param = value > 0 ? value : throw new Exception($"Geometry.Triangle({Name}): Сторона треугольника меньше или равен 0. Значение:{value}");
		}
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="figureName">Имя треугольника</param>
		/// <param name="a">Сторона А</param>
		/// <param name="b">Сторона В</param>
		/// <param name="c">Сторона С</param>
		public Triangle(string figureName, double a, double b, double c) : base(figureName)
		{
			A = a;
			B = b;
			C = c;
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
				throw new Exception($"Geometry.Triangle({Name}): Для округления должно использоваться от 0 до 15 разрядов включительно. Значение:{digits}");
			Digits = digits;
			return Square();
		}
		/// <summary>
		/// Вычисляет площадь треугольника по формуле Герона
		/// </summary>
		/// <returns>Площадь треугольника</returns>
		public override double Square()
		{
			CheckCurrent();
			var p = (A + B + C) / 2;
			var square = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), Digits);
			return square;
		}
		/// <summary>
		/// Проверка на существование треугольника
		/// </summary>
		/// <param name="a">Сторона А</param>
		/// <param name="b">Сторона В</param>
		/// <param name="c">Сторона С</param>
		/// <returns>True - треуголиник существует</returns>
		/// <exception cref="Exception"></exception>
		public static bool Check(double a, double b, double c)
		{
			if (a > (b + c) || b > (a + c) || c > (a + b))
				return false;

			return true;
		}
		/// <summary>
		/// Проверка на существование треугольника созданного треугольника
		/// </summary>
		/// <returns>True - треуголиник существует</returns>
		/// <exception cref="Exception"></exception>
		private bool CheckCurrent()
        {
			if(!Check(A, B, C))
				throw new Exception($"Geometry.Triangle({Name}): Треугольник с такими сторонами не может существоватью. A({A}), B({B}), C({C})");
			return true;
        }
		/// <summary>
		/// Проверка является ли треугольник прямоугольным
		/// </summary>
		/// <returns>True - треугольник прямоугольный</returns>
		public bool IsStraight()
		{
			CheckCurrent();
			return (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)) || 
					B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2)) || 
					C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));

		}
	}
}
