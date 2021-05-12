using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для AddInfo.xaml
    /// </summary>
    public partial class AddInfo : Window
    {
        public AddInfo()
        {
            InitializeComponent();
        }
        private int number = 0;

        public AddInfo(int number)
        {
            InitializeComponent();
            this.number = number;
        }
        private int count = 0;
        private int price = 0;
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            ToyShop shop = (ToyShop)((ListBox)Application.Current.Windows[0].FindName("listBox1")).SelectedItem;
            Add add = new Add(count++, price);
            this.Hide();
            add.ShowDialog();

            if (shop.information != null)
            {
                listBox1.Items.Clear();
                foreach (var plot in shop.information)
                {
                    listBox1.Items.Add(plot);
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ToyShop shop = (ToyShop)((ListBox)Application.Current.Windows[0].FindName("listBox1")).SelectedItem;

            shop.RemoveInfo((PartyInformation)listBox1.SelectedItem);
            listBox1.Items.Remove((PartyInformation)listBox1.SelectedItem);

            if (shop.information != null)
            {
                listBox1.Items.Clear();
                foreach (var information in shop.information)
                {
                    listBox1.Items.Add(information);
                }
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            ToyShop shop = (ToyShop)((ListBox)Application.Current.Windows[0].FindName("listBox1")).SelectedItem;

            if (listBox1.SelectedItem != null)
            {
                string text = listBox1.SelectedItem.ToString();
                string textCopy = text;

                string[] str = text.Trim().Split('\n');

                Add add = new Add(listBox1.SelectedIndex++, number);

                string[] str2 = str[0].Trim().Split(' ');
                add.comboBox1.Text = str2[1].Trim().Split(';')[0];

                str2 = str[1].Trim().Split(' ');
                add.textBox1.Text = str2[2];

                str2 = str[2].Trim().Split(' ');
                add.textBox2.Text = str2[1].Trim().Split(';')[0];

                str2 = str[3].Trim().Split(' ');
                add.DatePicker.Text = str2[2].Trim().Split(';')[0];

                str2 = str[4].Trim().Split(' ');
                add.textBox3.Text = str2[2].Trim().Split(';')[0];

                str2 = str[5].Trim().Split(' ');
                add.textBox4.Text = str2[1].Trim().Split(';')[0];


                add.switch_0 = true;
                add.ShowDialog();
                this.Hide();

                if (shop.information != null)
                {
                    listBox1.Items.Clear();
                    foreach (var information in shop.information)
                    {
                        listBox1.Items.Add(information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Виберіть магазин!");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
