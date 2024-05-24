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
    //TODO: XML
    public partial class AddTriangleUserControl : UserControl, IAddFigure
    {
        //TODO: XML
        public AddTriangleUserControl()
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
        private void HeightA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReadDataFromTextBox.CheckInput(e);
        }

        /// <summary>
        /// метод добавления круга
        /// </summary>
        /// <returns></returns>
        public FigureBase AddFigure()
        {
            var triangle = new Triangle();

            triangle.SideA = ReadDataFromTextBox.CheckNumber(SideA.Text);
            triangle.HeightA = ReadDataFromTextBox.CheckNumber(HeightA.Text);

            return triangle;
        }
    }
}
