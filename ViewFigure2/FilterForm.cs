using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewFigure
{
    /// <summary>
    /// Форма фильтра
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Список фильтруемых фигур
        /// </summary>
        private readonly BindingList<FigureBase> _listFigure;

        /// <summary>
        /// Список отфильтрованных фигур
        /// </summary>
        private BindingList<FigureBase> _listFigureFilter;

        /// <summary>
        /// Обработка событий
        /// </summary>
        public EventHandler<EventArgs> FigureFiltered;
        
        //TODO: RSDN +
        /// <summary>
        /// Площадь
        /// </summary>
        private double _area;

        /// <summary>
        /// Фильтрация
        /// </summary>
        /// <param name="figures"></param>
        public FilterForm(BindingList<FigureBase> figures)
        {
            InitializeComponent();
            _listFigure = figures;
            AreaTextBox.Enabled = true;
        }

        /// <summary>
        /// Ввод площади
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AreaTextBox.Text != "")
                {
                    _area = ReadDataFromTextBox.CheckNumber(AreaTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное число!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReadDataFromTextBox.CheckInput(e);
        }

        /// <summary>
        /// Флажок активации поля ввода площади.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AreaCheckBox.Checked)
            {
                AreaCheckBox.Enabled = true;
            }
        }
        //TODO: RSDN +
        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            _listFigureFilter = new BindingList<FigureBase>();

            int count = 0;
            if (!CircleCheckBox.Checked
                && !RectangleCheckBox.Checked
                && !TriangleCheckBox.Checked
                && !AreaCheckBox.Checked)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (FigureBase figure in _listFigure)
            {

                switch (figure)
                {
                    //TODO: RSDN +
                    case Circle when CircleCheckBox.Checked:
                    case Model.Rectangle when RectangleCheckBox.Checked:
                    case Triangle when TriangleCheckBox.Checked:
                    {
                        if (AreaCheckBox.Checked)
                        {
                            if (figure.Area == _area)
                            {
                                count++;
                                _listFigureFilter.Add(figure);
                                break;
                            }
                            break;
                        }
                        else
                        {
                            count++;
                            _listFigureFilter.Add(figure);
                            break;
                        }
                    }
                }

                if (!CircleCheckBox.Checked
                    && !TriangleCheckBox.Checked
                    && !RectangleCheckBox.Checked)
                {
                    if (AreaCheckBox.Checked && figure.Area == _area)
                    {
                        count++;
                        _listFigureFilter.Add(figure);
                    }
                }
            }

            var eventArgs = new FigureListEventArgs(_listFigureFilter);

            if (count <= 0)
            {
                MessageBox.Show("Нет фигур удовлетворяющих фильтру!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FigureFiltered?.Invoke(this, eventArgs);
            Close();
        }
    }
}
