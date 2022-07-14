using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Interfaces
{
    /// <summary>
    /// Проверка на прямой угол
    /// </summary>
    public interface IStraight
    {
        /// <summary>
        /// Является ли прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsStraight();
    }
}
