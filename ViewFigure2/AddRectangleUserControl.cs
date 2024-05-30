using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewFigure
{
    //TODO: XML +
    /// <summary>
    /// Пользовательское действие добавление прямоугольника
    /// </summary>
    public partial class AddRectangleUserControl : UserControl, IAddFigure
    {
        //TODO: XML +
        /// <summary>
        /// Иницализация добавления прямоугольника
        /// </summary>
        public AddRectangleUserControl()
        {
            InitializeComponent();
        }

        //TODO: duplication
        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SideA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReadDataFromTextBox.CheckInput(e);
        }

        //TODO: duplication
        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SideB_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReadDataFromTextBox.CheckInput(e);
        }

        /// <summary>
        /// метод добавления круга
        /// </summary>
        /// <returns></returns>
        public FigureBase AddFigure()
        {
            var rectangle = new Model.Rectangle();

            rectangle.SideA = ReadDataFromTextBox.CheckNumber(SideA.Text);
            rectangle.SideB = ReadDataFromTextBox.CheckNumber(SideB.Text);

            return rectangle;
        }
    }
}
