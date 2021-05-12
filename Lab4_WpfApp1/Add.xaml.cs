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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public AddInfo addInfo;
        private int count = 0;
        private int price = 0;
        public Add()
        {
            InitializeComponent();            
        }
        public Add(int count, int price)
        {
            InitializeComponent();

            comboBox1.Items.Add(Classification.ClassificationValue.Мяка_іграшка);
            comboBox1.Items.Add(Classification.ClassificationValue.Лялька);
            comboBox1.Items.Add(Classification.ClassificationValue.Модель_техніки);
            comboBox1.Items.Add(Classification.ClassificationValue.Конструктор);

            this.count = count;
            this.price = price;

            try
            {
                ToyShop shop = (ToyShop)((ListBox)Application.Current.Windows[0].FindName("listBox1")).SelectedItem;

                information_Copy8.Content = shop.NumberOfTheStore;
                information_Copy9.Content = count;

                ListBox list1 = (ListBox)Application.Current.Windows[0].FindName("listBox1");
                ListBox list2 = (ListBox)Application.Current.Windows[2].FindName("listBox1");

                if (list2 != null && list2.Items.Count != 0)
                {
                    PartyInformation partyInfo = (PartyInformation)list2.SelectedItem;
                    if (partyInfo != null)
                    {
                        list2.Items.Remove(partyInfo);
                        shop.RemoveInfo(partyInfo);
                        list1.Items.Remove(partyInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddSave_Click(object sender, RoutedEventArgs e)
        {
            ToyShop shop = (ToyShop)((ListBox)Application.Current.Windows[0].FindName("listBox1")).SelectedItem;
            try
            {
                Classification classification = new Classification((Classification.ClassificationValue)comboBox1.SelectedItem);
                Toy toy = new Toy(textBox1.Text, textBox2.Text);

                ToyParty toyParty = new ToyParty(toy, (DateTime)DatePicker.SelectedDate, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));

                PartyInformation information = new PartyInformation(classification, toy, toyParty);
                shop.AddInfo(information);

                Close();
                AddInfo addInfo = new AddInfo();
                addInfo.Show();
            }
            catch
            {
                MessageBox.Show("Не всі поля заповнені!");
            }
        }
        public bool switch_0 { get; set; } = false;
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            AddInfo addInfo = new AddInfo();
            addInfo.Show();               
        }

        private void textBox1_TextChanged(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }

        private void textBox2_TextChanged(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
