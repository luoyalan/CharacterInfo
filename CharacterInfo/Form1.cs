using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsvReader csvReader = new CsvReader();
            if (radioButton1.Checked)
            {
                var characters = csvReader.ReaddecompT();
                display(characters);
            }
            else
            {
                var characters = csvReader.Readdecomp();
                display(characters);
            }


        }



        private void display(string[] characters)
        {
            var matchingstring = characters.FirstOrDefault(stringToCheck => stringToCheck.Contains(this.textBox1.Text));
            int index = 0;
            index = matchingstring.IndexOf(',');
            matchingstring = matchingstring.Substring(index + 1);
            this.label1.Text = matchingstring;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CsvReader csvReader = new CsvReader();
            var characters = csvReader.Readadjlist();
            var matchingstring = characters.FirstOrDefault(stringToCheck => stringToCheck.Contains(this.textBox1.Text));
            int index = 0;
            index = matchingstring.IndexOf(',');
            matchingstring = matchingstring.Substring(index + 1);
            this.label1.Text = matchingstring;
        }
    }
}
