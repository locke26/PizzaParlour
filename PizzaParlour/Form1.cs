using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        double price = 3.25;
        double slices;
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                slices = Convert.ToInt32(numberTextBox.Text);
                total = slices * price;
                outputLabel.Text = $"The price of {slices} slices is {total.ToString("$0.00")}";
            }
            catch
            {
                outputLabel.Text = "Only numbers please";

            }
        } 
    }
}

