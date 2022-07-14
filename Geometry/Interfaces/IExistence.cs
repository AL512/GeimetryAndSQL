using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Interfaces
{
    /// <summary>
    /// Существование фигуры
    /// </summary>
    public interface IExistence
    {
        /// <summary>
        /// Проверяет существование фигуры
        /// </summary>
        /// <returns></returns>
        public bool CkeckExistence();
    }
}
