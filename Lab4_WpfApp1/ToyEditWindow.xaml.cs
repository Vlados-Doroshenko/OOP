using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ToyEditWindow.xaml
    /// </summary>
    public partial class ToyEditWindow : Window
    {
        Toy theToy;
        public ToyEditWindow(Toy toy)
        {
            InitializeComponent();
            theToy = toy;
            if (theToy.Name != null)
            {
                textBox1.Text = theToy.Name;
                textBox2.Text = theToy.Manufacturer;
                comboBox1.SelectedItem = theToy.ToyClass;
            }


        }
        Regex NameReg = new Regex(@"^[a-zA-Z]+\s?$");

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" | textBox2.Text != "")
            {
                theToy.Name = textBox1.Text;
                theToy.Manufacturer = textBox2.Text;
                theToy.ToyClass = (Toy.Classification)comboBox1.SelectedItem;
                //DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Не можна створити iграшку без назви або виробника");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Add(Toy.Classification.Мяка_іграшка);
            comboBox1.Items.Add(Toy.Classification.Лялька);
            comboBox1.Items.Add(Toy.Classification.Модель_техніки);
            comboBox1.Items.Add(Toy.Classification.Конструктор);
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            theToy = new Toy();
            //DialogResult = DialogResult.No;
            Close();
        }
    }
}
