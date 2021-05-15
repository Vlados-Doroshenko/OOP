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
    /// Логика взаимодействия для PartyEditWindow.xaml
    /// </summary>
    public partial class PartyEditWindow : Window
    {
        PartyToys thePartyToys;
        public static List<Toy> allToys = new List<Toy>();
        public PartyEditWindow(PartyToys partyToys)
        {
            InitializeComponent();
            thePartyToys = partyToys;
            if (partyToys.TheToy != null)
            {
                listBox1.Items.Add(partyToys);
            }
            foreach (Toy i in allToys)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Toy toy = new Toy();
            ToyEditWindow toyEdit = new ToyEditWindow(toy);
            toyEdit.ShowDialog();
            allToys.Add(toy);
            listBox1.Items.Add(toy);
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                button4.IsEnabled = true;
            }
            else
            {
                button4.IsEnabled = false;

            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ToyEditWindow toyEdit = new ToyEditWindow(allToys[listBox1.SelectedIndex]);
            toyEdit.ShowDialog();
            RefreshData();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            thePartyToys.TheToy = (Toy)listBox1.SelectedItem;
            thePartyToys.Date = (DateTime)dateTimePicker1.SelectedDate;
            thePartyToys.Price = Convert.ToInt32(numericUpDown1.Text);
            thePartyToys.Count = Convert.ToInt32(numericUpDown2.Text);
            Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            thePartyToys = new PartyToys();            
            Close();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //button2.IsEnabled = true;
        }

        public void RefreshData()
        {
            listBox1.Items.Clear();
            foreach (var i in allToys)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
