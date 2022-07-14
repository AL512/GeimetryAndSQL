namespace Geometry.Figures
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
        /// Конструктор абстрактной фигуры
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        public Figure(string name)
        {
            Name = name?.Length > 0 ? Name = name : $"Figure {DateTime.Now.ToString("ddMMYYYHHmmss")}";
        }
    }
}