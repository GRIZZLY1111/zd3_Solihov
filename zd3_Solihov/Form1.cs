using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_Solihov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = CarManager.GetAllItems();
        }
        //Добавление машины
        private void button1_Click(object sender, EventArgs e)
        {
            //Добавление машины только с информацией из базового класса
            if (checkBox1.Checked == false)
            {
                int km = Convert.ToInt32(numericUpDown1.Value);
                double consumptionkm = Convert.ToDouble(numericUpDown2.Value);
                CarManager.AddCar(km, consumptionkm);
                UpdateListBox();
                MessageBox.Show("Машина успешно добавлена");

            }
            //Добавление машины с информацией из класса наследника
            else
            {
                int km = Convert.ToInt32(numericUpDown1.Value);
                double consumptionkm = Convert.ToDouble(numericUpDown2.Value);
                int releaseYear = Convert.ToInt32(numericUpDown3.Value);
                int currentYear = Convert.ToInt32(numericUpDown4.Value);
                CarManager.AddAuto(km, consumptionkm, releaseYear, currentYear);
                UpdateListBox();
            }
        }

        private void удалитьМашинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;

            if (selectedItem is Automobile auto)
            {
                // Удаление автомобиля из класса наследника
                CarManager.RemoveAuto(auto); 
            }
            else if (selectedItem is Car car)
            {
                // Удаление машины из базового класса
                CarManager.RemoveCar(car); 
            }

            UpdateListBox(); // Обновляем список
        }
    }
}
