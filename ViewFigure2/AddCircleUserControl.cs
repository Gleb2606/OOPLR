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
using Model;

namespace ViewFigure
{
    //TODO: XML +
    /// <summary>
    /// Пользовательское действие добавление круга
    /// </summary>
    public partial class AddCircleUserControl : UserControl, IAddFigure
    {
        //TODO: XML +
        /// <summary>
        /// Инициализация добавления круга
        /// </summary>
        public AddCircleUserControl()
        {
            InitializeComponent();

            Radius.KeyPress += TextBox_KeyPress;
        }

        /// <summary>
        /// Обработчик события KeyPress для текстовых полей.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReadDataFromTextBox.CheckInput(e);
        }

        /// <summary>
        /// метод добавления круга
        /// </summary>
        /// <returns></returns>
        public FigureBase AddFigure()
        {
            var circle = new Circle();

            circle.Radius = ReadDataFromTextBox.CheckNumber(Radius.Text);

            return circle;
        }
    }
}
