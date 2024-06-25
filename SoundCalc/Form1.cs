using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SoundCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.productsDBTableAdapter2.Fill(this.products1DataSet2.ProductsDB);


        }

        private void btn_calculate(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox2 == null ||
                string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Пожалуйста введите значения в строки!");
                return;
            }
            if (double.TryParse(textBox1.Text, out double hours) && double.TryParse(textBox2.Text, out double totalRate))
            {
                // Расчитываем ставку в час
                double hourlyRate = totalRate * hours;

                label4.Text = $"{hourlyRate:F2}";
            }
        }

        /*
         При нажатии на ячейку со ставкой,
         ставка автоматически переходит в нужное текстовое поле
        */
        private void btn_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            //Столбец ставки
            const int targetColumnIndex = 4; 
            
            if(e.RowIndex >= 0 && e.ColumnIndex == targetColumnIndex)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[targetColumnIndex].Value.ToString();
                // Автоматическое добавление числа в строку времени при нажатии
                textBox1.Text = "1";
            }
        }


    }
}
