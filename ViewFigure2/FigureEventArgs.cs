using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewFigure
{
    public class FigureEventArgs : EventArgs
    {
        /// <summary>
        /// Фигура
        /// </summary>
        public FigureBase Figure { get; private set; }

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
