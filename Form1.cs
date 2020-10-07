using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HM_Geometry3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CheckTriangle(double side1, double side2, double angle)
        {
            if (side1 <= 0 || side2 <= 0 || angle <= 0 || angle >= Math.PI)
            {
                throw new ArgumentException();
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double side1 = 0.0;
            double side2 = 0.0;
            double angle = 0.0;
            try
            {
                side1 = double.Parse(tbSide1.Text);
                side2 = double.Parse(tbSide2.Text);
                angle = double.Parse(tbAngle.Text);
                CheckTriangle(side1, side2, angle);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некоректні дані");
                return;
            }
            IsoscelesTriangle ist = new IsoscelesTriangle(side1, side2, angle);
            tbPerimeter.Text = ist.Perimeter().ToString();
            tbArea.Text = ist.Area().ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSide1.Clear();
            tbSide2.Clear();
            tbAngle.Clear();
            tbPerimeter.Clear();
            tbArea.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnComputeRightTriangle_Click(object sender, EventArgs e)
        {
            double side1 = 0.0;
            double side2 = 0.0;
            double angle = 0.0;
            try
            {
                side1 = double.Parse(tbSide1RightTriangle.Text);
                side2 = double.Parse(tbSide2RightTriangle.Text);
                angle = double.Parse(tbAngleRightTriangle.Text);
                CheckTriangle(side1, side2, angle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некоректні дані");
                return;
            }
            RightTriangle rt = new RightTriangle(side1, side2, angle);
            tbPerimeterRightTriangle.Text = rt.Perimeter().ToString();
            tbAreaRightTriangle.Text = rt.Area().ToString();
        }

        private void btnClearRightTriangle_Click(object sender, EventArgs e)
        {
            tbSide1RightTriangle.Clear();
            tbSide2RightTriangle.Clear();
            tbAngleRightTriangle.Clear();
            tbPerimeterRightTriangle.Clear();
            tbAreaRightTriangle.Clear();
        }
    }
}
