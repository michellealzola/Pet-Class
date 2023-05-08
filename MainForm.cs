using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Class
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tBoxName.Text;
            string type = tBoxType.Text;
            int age;

            if(int.TryParse(tBoxAge.Text, out age))
            {
                
            }
            else
            {
                MessageBox.Show("Invalid age.");
            }

            Pet pet = new Pet(name, type, age);

            PetInfoForm petInfoForm = new PetInfoForm();

            petInfoForm.lBoxPetInfo.Items.Add("Name: " + pet.Name.ToString());
            petInfoForm.lBoxPetInfo.Items.Add("Type: " + pet.Type.ToString());
            petInfoForm.lBoxPetInfo.Items.Add("Age: " + pet.Age.ToString());

            petInfoForm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tBoxName.Text = "";
            tBoxType.Text = "";
            tBoxAge.Text = "";

            tBoxName.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
