using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewFigure
{
    internal class FigureListEventArgs : EventArgs
    {
        /// <summary>
        /// Список фигур.
        /// </summary>
        public BindingList<FigureBase> FigureList { get; private set; }

        /// <summary>
        /// Конструктор события добавления в список фигур.
        /// </summary>
        /// <param name="figures"></param>
        public FigureListEventArgs(BindingList<FigureBase> figures)
        {
            FigureList = figures;
        }
    }
}
