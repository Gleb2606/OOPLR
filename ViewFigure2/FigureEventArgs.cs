using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewFigure
{
    //TODO: XML +
    /// <summary>
    /// Действия при добавлении фигуры
    /// </summary>
    public class FigureEventArgs : EventArgs
    {
        /// <summary>
        /// Фигура
        /// </summary>
        public FigureBase Figure { get; }

        /// <summary>
        /// Добавление фигуры
        /// </summary>
        /// <param name="figure"></param>
        public FigureEventArgs(FigureBase figure)
        {
            Figure = figure;
        }
    }
}
