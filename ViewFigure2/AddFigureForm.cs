using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewFigure
{
    /// <summary>
    /// Форма для добавления новой фигуры
    /// </summary>
    public partial class AddFigureForm : Form
    {
        /// <summary>
        /// Событие добавления новой фигуры
        /// </summary>
        public EventHandler<EventArgs> FigureAdded;

        /// <summary>
        /// Словарь UserControls
        /// </summary>
        private readonly Dictionary<string, UserControl>
            _comboBoxToUserControl;

        //TODO: refactor
        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl userControl;

        /// <summary>
        /// Форма добавления фигур
        /// </summary>
        public AddFigureForm()
        {
            InitializeComponent();

            comboBoxFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            OK.Enabled = false;
#if !DEBUG
            Random.Visible = false;
#endif
            string[] typeFigure = { "Круг", "Прямоугольник", "Треугольник" };

            comboBoxFigures.Items.AddRange(typeFigure);

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {typeFigure[0], addCircleUserControl},
                {typeFigure[1], addRectangleUserControl},
                {typeFigure[2], addTriangleUserControl}
            };
        }

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddForm_Load(object sender, EventArgs e)
        {
            addCircleUserControl.Visible = false;
            addRectangleUserControl.Visible = false;
            addTriangleUserControl.Visible = false;
        }

        /// <summary>
        /// Выпадающий список.
        /// Действие которое выполняется когда
        /// выбрали фигуру из выпадающего списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFigeres_SelectedIndexChanged(object sender, EventArgs e)
        {

            string figureType = comboBoxFigures.SelectedItem.ToString();
            foreach (var (figure, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (figureType == figure)
                {
                    userControl.Visible = true;
                    OK.Enabled = true;
                    this.userControl = userControl;
                }
            }
        }

        //TODO: RSDN
        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                var currentFigureControlName = comboBoxFigures.SelectedItem.ToString();
                var currentFigureControl = _comboBoxToUserControl[currentFigureControlName];
                var eventArgs = new FigureEventArgs(((IAddFigure)currentFigureControl).AddFigure());
                FigureAdded?.Invoke(this, eventArgs);
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение!\n" +
                    "Введите одно положительное десятичное число" +
                    " в каждое текстовое поле.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: RSDN
        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TODO: RSDN
        //TODO: preprocessor directives
        /// <summary>
        /// Рандом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            comboBoxFigures.SelectedIndex = random.Next(0, 3);

            foreach (TextBox textbox in userControl.Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Text = random.Next(1, 100).ToString();
                }
            }
        }
    }
}
