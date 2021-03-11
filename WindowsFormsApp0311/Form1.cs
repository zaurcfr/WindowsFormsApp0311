using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ListBox

            //List<string> cars = new List<string>
            //{
            //    "Audi",
            //    "Ferrari",
            //    "BMW",
            //    "Chevrolet",
            //    "Mercedes"
            //};
            //listBox1.DataSource = cars;

            //listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            List<Car> cars = new List<Car>
            {
                new Car
                {
                    ID=1,
                    Name = "BMW"
                },
                new Car
                {
                    ID=2,
                    Name = "Mercedes"
                },
                new Car
                {
                    ID=3,
                    Name = "Ferrari"
                },
            };
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";

            //listBox1.DataSource = cars;

            listBox1.Items.Add(new Car
            {
                Name = "Mercedes"
            });
            listBox1.Items.Add(new Car
            {
                Name = "Ferrari"
            });

            //CheckedListBox

            checkedListBox1.Items.Add("Write Code");
            checkedListBox1.Items.Add("Read book");
            checkedListBox1.Items.Add("Do workout");


            List<Language> languages = new List<Language>
            {
                new Language
                {
                    LangName="English"
                },
                new Language
                {
                    LangName="Russian"
                },
                new Language
                {
                    LangName="Azerbaijani"
                }
            };
            comboBox1.DisplayMember = "LangName";
            comboBox1.DataSource = languages;


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //List<string> fruits = new List<string>
            //{
            //    "Apple",
            //    "Mango",
            //    "Pineapple",
            //    "Melon"
            //};
            //listBox1.DataSource = fruits;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"{(listBox1.SelectedItem as Car)?.Name} {(listBox1.SelectedItem as Car)?.ID}";
            var obj = listBox1.SelectedItem;
            try
            {
                listBox2.Items.Add(obj);
                listBox1.Items.Remove(obj);
                listBox1.SelectedItem = null;
            }
            catch (Exception) { }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Car
            {
                Name = textBox1.Text
            });
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in listBox1.SelectedItems)
            {
                var obj = item as Car;
                stringBuilder.Append($"{obj?.Name}\n");
                label1.Text = stringBuilder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                stringBuilder.Append($"\n{item}");
            }
            label3.Text = stringBuilder.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((comboBox1.SelectedItem as Language)?.LangName);
        }
    }
}
