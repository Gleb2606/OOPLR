﻿using Model;
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
    /// <summary>
    /// Пользовательское действие добавление треугольника
    /// </summary>
    public partial class AddTriangleUserControl : UserControl, IAddFigure
    {
        /// <summary>
        /// Инициализация добавления треугольника
        /// </summary>
        public AddTriangleUserControl()
        {
            InitializeComponent();

            SideA.KeyPress += TextBox_KeyPress;
            HeightA.KeyPress += TextBox_KeyPress;
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
            var triangle = new Triangle();

            triangle.SideA = ReadDataFromTextBox.CheckNumber(SideA.Text);
            triangle.HeightA = ReadDataFromTextBox.CheckNumber(HeightA.Text);

            return triangle;
        }
    }
}
