using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String fileXML = Directory.GetCurrentDirectory() + "\\all_shop.xml";
        List<ToyShop> shops = new List<ToyShop>();
        public MainWindow()
        {
            InitializeComponent();
            if (shops.Count != 0)
            {
                buttonOpenMag.IsEnabled = true;
            }
        }

        private void buttonAddMag_Click(object sender, RoutedEventArgs e)
        {
            ToyShop newShop = new ToyShop();
            listBox1.Items.Add(newShop);

            shops.Add(newShop);
            if (buttonOpenMag.IsEnabled == false)
            {
                buttonOpenMag.IsEnabled = true;
                button1.IsEnabled = true;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count == 1)
            {
                button1.IsEnabled = false;
                buttonOpenMag.IsEnabled = false;
            }
            shops.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonOpenMag_Click(object sender, RoutedEventArgs e)
        {
            ToyShopWindow toyShop = new ToyShopWindow(shops[listBox1.SelectedIndex]);
            toyShop.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    XmlSerializer serial = new XmlSerializer(typeof(List<ToyShop>), new Type[] { typeof(ToyShop), typeof(PartyToys), typeof(Toy) });
                    BinaryFormatter bf2 = new BinaryFormatter();
                    Stream fs = new FileStream(Environment.CurrentDirectory + "\\all_shop.xml", FileMode.Open);
                    TextReader reader = new StreamReader(fs);

                    shops = serial.Deserialize(fs) as List<ToyShop>;
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine(ex.Message);

                }

                foreach (var locality in shops)
                {
                    listBox1.Items.Add(locality);
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString() + " " + fileXML);

            }
            if (listBox1.Items.Count > 0)
            {
                button1.IsEnabled = true;
                buttonOpenMag.IsEnabled = true;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Do you want to save changes?", "Serialisation",
             (MessageBoxButton)MessageBoxButtons.YesNo) == MessageBoxResult.Yes)
            {
                XmlSerializer serial = new XmlSerializer(typeof(List<ToyShop>), new Type[] { typeof(ToyShop), typeof(PartyToys), typeof(Toy) });
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\all_shop.xml",
                    FileMode.Create, FileAccess.Write))
                {
                    serial.Serialize(fs, shops);
                    //System.Windows.MessageBox.Show("XML was created");
                    fs.Close();
                }

                string json = JsonConvert.SerializeObject(shops);
                File.WriteAllText(Environment.CurrentDirectory + "\\all_shop.json", json);
            }
        }
    }
}
