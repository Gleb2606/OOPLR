using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WindowsFormsApp1
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();

            triangle.SideA = ReadFigureFromConsole.CheckNumber(textBoxsideA.Text);
            triangle.HeightA = ReadFigureFromConsole.CheckNumber(textBoxHeightA.Text);

            double area = triangle.Area;

            MessageBox.Show($"Площадь треугольника равна: {area}");
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
