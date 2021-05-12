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
        public MainWindow()
        {
            InitializeComponent();
        }
        private string fileXML = Directory.GetCurrentDirectory() + "\\all_shop.xml";
        private string fileJson = Directory.GetCurrentDirectory() + "\\all_shop.json";

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Хочете зберегти дані?", "Збереження даних", MessageBoxButton.YesNoCancel);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                List<ToyShop> information = new List<ToyShop>();
                foreach (var loc in listBox1.Items)
                {
                    information.Add((ToyShop)loc);
                }
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<ToyShop>), new Type[] { typeof(PartyInformation), typeof(ToyShop), typeof(ToyParty), typeof(Toy), typeof(Classification) });
                 using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\all_shop.xml",
                     FileMode.Create, FileAccess.Write))
                 {
                     xmlFormatter.Serialize(fs, information);
                     MessageBox.Show("XML was created");
                     fs.Close();
                 }
                string json = JsonConvert.SerializeObject(information);
                File.WriteAllText(Environment.CurrentDirectory + "\\all_shop.json", json);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToyShop information = new ToyShop(listBox1.Items.Count + 1);
            AddInfo form = new AddInfo(listBox1.Items.Count + 1);
            listBox1.Items.Add(information);
            
            listBox1.SelectedItem = information;
            form.ShowDialog();            
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items != null && listBox1.SelectedItem is ToyShop)
            {
                ToyShop information = (ToyShop)listBox1.SelectedItem;
                AddInfo form = new AddInfo();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Оберіть магазин!");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*try
            {
                
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<ToyShop>), new Type[] { typeof(PartyInformation), typeof(ToyShop), typeof(ToyParty), typeof(Toy), typeof(Classification) });
                FileStream fileStream2 = new FileStream(fileXML, FileMode.Open);
                BinaryFormatter bf2 = new BinaryFormatter();
                try
                {
                    shops = xmlFormatter.Deserialize(fileStream2) as List<ToyShop>;
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
            catch (Exception)
            {
                MessageBox.Show("Не вдалося загрузити файл! Створено нові файли!");

            }*/
            try
            {
                List<ToyShop> information = new List<ToyShop>();
                try
                {
                    if (!File.Exists(fileXML))
                    {
                        File.Create(fileXML);
                    }

                    if (!File.Exists(fileJson))
                    {
                        File.Create(fileJson);
                    }
                    
                    XmlSerializer serial = new XmlSerializer(typeof(List<ToyShop>), new Type[] { typeof(PartyInformation), typeof(ToyShop), typeof(ToyParty), typeof(Toy), typeof(Classification) });
                    BinaryFormatter bf2 = new BinaryFormatter();
                    Stream fs = new FileStream(Environment.CurrentDirectory + "\\all_shop.xml", FileMode.Open);
                    TextReader reader = new StreamReader(fs);

                    information = serial.Deserialize(fs) as List<ToyShop>;
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine(ex.Message);

                }

                foreach (var locality in information)
                {
                    listBox1.Items.Add(locality);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " " + fileXML);

            }
        }

    }
}
