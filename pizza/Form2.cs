/*
  Team 13 Ahjeossi's
  Group Members: Everest Law, Patrick Heard, Quinton Mclain
  Pizza Place Part 2

  This program is a continuation of the My Pizza Place assignment. 
  The program uses forms, for a user to select different pizza options and 
  adds the price of everything together. 
  Form1 passes data to form2 for order summary
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public decimal OrderTotal { get; set; } //reference to order total object in form 1

        public string OrderSummary { get; set; }  //reference to order summary
        
    private void Form2_Load(object sender, EventArgs e)
        {
            //showing order summary on form2
            summaryLabel.Text = OrderSummary;
            form2Total.Text = $"Total Order Amount: ${OrderTotal:F2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
