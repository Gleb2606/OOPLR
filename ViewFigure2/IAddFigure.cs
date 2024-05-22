using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewFigure
{
    /// <summary>
    /// Интерфейс для добавления фигуры
    /// </summary>
    public interface IAddFigure
    {
        /// <summary>
        /// Метод добавления фигуры
        /// </summary>
        /// <returns></returns>
        public abstract FigureBase AddFigure();
    }
}
