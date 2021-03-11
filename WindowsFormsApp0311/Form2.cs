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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void usersLstb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = usersLstb.SelectedItem;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            usersLstb.Items.Add(new Person
            {
                Name = nameTxtb.Text,
                Surname = surnameTxtb.Text,
                Email = emailTxtb.Text,
                Phone = phoneMtxtb.Text,
                BirthDate = birthdateDtpckr.Value
            });
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usersLstb.DisplayMember = "Name";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (fileTxtb.Text != "") FileHelper.JsonSerialize(fileTxtb.Text, usersLstb.SelectedItem as Person);
            else FileHelper.JsonSerialize((usersLstb.SelectedItem as Person)?.Name, usersLstb.SelectedItem as Person);
            nameTxtb.Text = "";
            surnameTxtb.Text = "";
            emailTxtb.Text = "";
            phoneMtxtb.Text = "";
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var obj = usersLstb.SelectedItem as Person;
            var p = FileHelper.JsonDeserialize((obj)?.Name);
            nameTxtb.Text = p.Name;
            surnameTxtb.Text = p.Surname;
            emailTxtb.Text = p.Email;
            phoneMtxtb.Text = p.Phone;
            birthdateDtpckr.Value = p.BirthDate;
        }
    }
}
