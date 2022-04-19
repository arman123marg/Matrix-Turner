using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        int[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbChooseDegree.Items.Add("turn 90° right");
            cbChooseDegree.Items.Add("turn 90° left");
            cbChooseDegree.Items.Add("turn 180°");

        }

        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            int matrixI = int.Parse(txtMatrixI.Text);
            int matrixJ = int.Parse(txtMatrixJ.Text);
            matrix = new int[matrixI, matrixJ];
            MatrixGenerator();
            PrintInDgView(matrix, dgBaseMatrix);

        }
        void MatrixGenerator()
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                }
            }
        }
        static void PrintInDgView(int[,] matrix, DataGridView dataGridView)
        {
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 25;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            int[,] turnedMatrix;
            switch (cbChooseDegree.SelectedIndex)
            {
                case 0:
                    turnedMatrix = TurnIn90();
                    break;
                case 1:
                    turnedMatrix = TurnIn270();
                    break;
                case 2:
                    turnedMatrix = TurnIn180();
                    break;
                default:
                    MessageBox.Show("Choose degree");
                    return;

            }
            PrintInDgView(turnedMatrix, dgTurnedMatrix);
        }
        int[,] TurnIn90()
        {
            int[,] turnedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    turnedMatrix[j, matrix.GetLength(0) - i - 1] = matrix[i, j];
                }
            }

            return turnedMatrix;
        }
        int[,] TurnIn270()
        {
            int[,] turnedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    turnedMatrix[matrix.GetLength(1) - j - 1, i] = matrix[i, j];
                }
            }

            return turnedMatrix;
        }
        int[,] TurnIn180()
        {
            int[,] turnedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    turnedMatrix[matrix.GetLength(0) - i - 1, matrix.GetLength(1) - j - 1] = matrix[i, j];
                }
            }

            return turnedMatrix;
        }
    }
}
