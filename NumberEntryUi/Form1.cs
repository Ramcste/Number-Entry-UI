using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberEntryUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double number;
        List<double > list=new List<double>();
        private double total = 0;
        private void showAllNumberButton_Click(object sender, EventArgs e)
        {
            numberListBox.DataSource = list;
            sumResultTextBox.Text = total.ToString();
        }

        private void addNumberButton_Click_1(object sender, EventArgs e)
        {
            number = double.Parse(numberTextBox.Text);
       
            list.Add(number);
            total += number;
            numberTextBox.Text = "";

            

        }
    }
}
