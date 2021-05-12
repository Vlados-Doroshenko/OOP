using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<ToyShop> shops = new List<ToyShop>();
        public Form1()
        {
            InitializeComponent();
            if (shops.Count != 0)
            {
                buttonOpenMag.Enabled = true;
            }
        }


        private void buttonAddMag_Click(object sender, EventArgs e)
        {
            ToyShop newShop = new ToyShop();
            listBox1.Items.Add(newShop);
          
            shops.Add(newShop);
            if(buttonOpenMag.Enabled == false)
            {
                buttonOpenMag.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void buttonOpenMag_Click(object sender, EventArgs e)
        {
            
            ToyShopForm toyShop = new ToyShopForm(shops[listBox1.SelectedIndex]);
            toyShop.ShowDialog();
        }
        private String fileXML = Directory.GetCurrentDirectory() + "\\all_shop.xml";



        private void Form1_Load(object sender, EventArgs e)
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
                System.Windows.Forms.MessageBox.Show(ex.ToString() + " " + fileXML);

            }
            if (listBox1.Items.Count > 0)
            {
                button1.Enabled = true;
                buttonOpenMag.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 1)
            {
                button1.Enabled = false;
                buttonOpenMag.Enabled = false;
            }
            shops.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
