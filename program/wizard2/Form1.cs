using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wizard2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string StrName; //public static for name
        public static string StrElement; //public static for elements

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StrName = textBox1.Text; //name shown on text box 1

            if (comboBox1.Text == "Air")
            { StrElement = "Air"; } //air element made
            if (comboBox1.Text == "Water")
            { StrElement = "Water"; } //water element made
            if (comboBox1.Text == "Fire")
            { StrElement = "Fire"; } //fire element made
            if (comboBox1.Text == "Earth")
            { StrElement = "Earth"; } //earth element made

            play form = new play();
            form.Show(); // show on the second form made
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
