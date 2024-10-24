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
    public partial class Form1 : Form
    {
        double total = 0.0;

        bool smallRadioAdd = false;
        bool mediumRadioAdd = false;
        bool largeRadioAdd = false;
        bool XLRadioAdd = false;
        string selectedOption = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //only add if first selection
            if (smallRadio.Checked)
            {
                if (!smallRadioAdd)
                {
                    total += 7.00; //small pizza price
                    smallRadioAdd = true;
                    pizzaSize.Text = "Pizza: Small Pizza"; //update label
                }
            }
            else
            {
                //handle checking for radio buttons
                if (smallRadioAdd)
                {
                    total -= 7.00; ;
                    smallRadioAdd = false;
                    pizzaSize.Text = ""; //remove item from label
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (pepCheck.Checked)
            {
                //if pepperoni box checked, shows pepperoni as a topping
                if (!Toppings.Text.Contains("Pepperoni"))
                {
                    Toppings.Text += " Pepperoni ";
                }
            }
            else
            {
                //removes pepperoni from toppings if unchecked
                Toppings.Text = Toppings.Text.Replace("Pepperoni", "");
            }
            //shows none if no toppings selected
            if (string.IsNullOrWhiteSpace(Toppings.Text) || Toppings.Text == "Toppings: ")
            {
                Toppings.Text = "Toppings: None";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update finalized screen
            string pizzaSize = "";
            if (smallRadio.Checked)
            {
                pizzaSize = "Small Pizza";
            }
            else if (mediumRadio.Checked)
            {
                pizzaSize = "Medium Pizza";
            }
            else if (largeRadio.Checked)
            {
                pizzaSize = "Large Pizza";
            }
            else if (XLRadio.Checked)
            {
                pizzaSize = "XL Pizza";
            }

            //get selected item from combo box
            string cheeseSelection = comboBox1.SelectedItem?.ToString() ?? "No Cheese Selected";
            string sauceSelection = comboBox2.SelectedItem?.ToString() ?? "No Sauce Selected";

            //create one instance of form 1
            Form2 secondform = new Form2();

            //pass data to form2
            secondform.PassedData = pizzaSize;
            secondform.CheeseSelection = cheeseSelection;
            secondform.SauceSelection = sauceSelection;
            secondform.OrderTotal = (decimal)total;

            secondform.Show();
        }

        private void UpdateTotalLabel()
        {
            totalLabel.Text ="Total: $" +total.ToString("F2");
        }

        private void mediumRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumRadio.Checked)
            {
                if (!mediumRadioAdd)
                {
                    total += 10.00; //price medium pizza
                    mediumRadioAdd = true;
                    pizzaSize.Text = "Pizza: Medium Pizza"; //update label
                }
            }
            else
            {
                //handles checking for radio buttons
                if (mediumRadioAdd)
                {
                    total -= 10.00; ;
                    mediumRadioAdd = false;
                    pizzaSize.Text = ""; //remove item from label and clear..
                                         //..if only selection
                }
            }
        }

        private void largeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (largeRadio.Checked)
            {
                if (!largeRadioAdd)
                {
                    total += 12.00; //price of large pizza
                    largeRadioAdd = true;
                    pizzaSize.Text = "Pizza: Large Pizza"; //update label
                }
            }
            else
            {    
                //handle unchecking for radio buttons 
                if (largeRadioAdd)
                {
                    total -= 12.00; ;
                    largeRadioAdd = false;
                    pizzaSize.Text = "";
                }
            }
        }

        private void XLRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (XLRadio.Checked)
            {
                if (!XLRadioAdd)
                {
                    total += 14.00; //price of XL pizza
                    XLRadioAdd = true;
                    pizzaSize.Text = "Pizza: XL Pizza"; //update label
                }
            }
            else
            {
                //handles unchecking for radio buttons
                if (XLRadioAdd)
                {
                    total -= 14.00; ;
                    XLRadioAdd = false;
                    pizzaSize.Text = "";
                }
            }
        }

        private void breadsticks_CheckedChanged(object sender, EventArgs e)
        {
            if (Breadsticks.Checked)
            {
                total += 6.99; //price of breadsticks

                if(!sides.Text.Contains(" Breadsticks"))
                {
                    sides.Text += " Breadsticks"; //add item name without trailing space
                }
            }
            else
            {
                //removes item from label with comma handling
                total -= 6.99;
                sides.Text = sides.Text.Replace("Breadsticks", "");
                sides.Text = sides.Text.Trim(','); //trim trailing commas
                sides.Text = sides.Text.Trim();    //trim leading/trailing spaces
            }
            UpdateTotalLabel();
        }

        private void wings_CheckedChanged(object sender, EventArgs e)
        {
            if (wings.Checked)
            {
                total += 12.00; //price of wings

                if (!sides.Text.Contains(" Wings"))
                {
                    sides.Text += " Wings"; //add item name without trailing space
                }
            }
            else
            {
                //removes item from label with comma handling
                total -= 12.00;
                sides.Text = sides.Text.Replace("Wings", "");
                sides.Text = sides.Text.Trim(',');
                sides.Text = sides.Text.Trim();
            }
            UpdateTotalLabel();
        }

        private void salad_CheckedChanged(object sender, EventArgs e)
        {
            if (salad.Checked)
            {
                total += 10.99; //price of wings

                if (!sides.Text.Contains(" Caesar Salad"))
                {
                    sides.Text += " Caesar Salad"; //add item name without trailing space
                }
            }
            else
            {
                //removes item from label with comma handling
                total -= 10.99;
                sides.Text = sides.Text.Replace("Caesar Salad", "");
                sides.Text = sides.Text.Trim(',');
                sides.Text = sides.Text.Trim();
            }
            UpdateTotalLabel();
        }

        private void pasta_CheckedChanged(object sender, EventArgs e)
        {
            if (pasta.Checked)
            {
                total += 14.99; //price of pasta

                if (!sides.Text.Contains(" Over-Baked Pasta"))
                {
                    sides.Text += " Over-Baked Pasta"; //add item without trailing space
                }
            }
            else
            {
                //removes item from label with comma handling
                total -= 14.99;
                sides.Text = sides.Text.Replace("Over-Baked Pasta", "");
                sides.Text = sides.Text.Trim(',');
                sides.Text = sides.Text.Trim();
            }
            UpdateTotalLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (mushrooms.Checked)
            {

                if (!Toppings.Text.Contains("Mushrooms"))
                {
                    Toppings.Text += " Mushrooms ";
                }
            }
            else
            {
                //removes mushrooms from toppings if unchecked
                Toppings.Text = Toppings.Text.Replace("Mushrooms", "");
            }
            if (string.IsNullOrWhiteSpace(Toppings.Text) || Toppings.Text == "Toppings: ")
            {
                Toppings.Text = "Toppings: None"; //if no toppings selected show none
            }
        }

        private void onions_CheckedChanged(object sender, EventArgs e)
        {
            if (onions.Checked)
            {

                if (!Toppings.Text.Contains(" Onions"))
                {
                    Toppings.Text += " Onions ";
                }
            }
            else
            {
                //removes onions from toppings if unchecked
                Toppings.Text = Toppings.Text.Replace("Onions", "");
            }
            if (string.IsNullOrWhiteSpace(Toppings.Text) || Toppings.Text == "Toppings: ")
            {
                Toppings.Text = "Toppings: None";
            }
        }

        private void sausage_CheckedChanged(object sender, EventArgs e)
        {
            if (sausage.Checked)
            {

                if (!Toppings.Text.Contains(" Sausage"))
                {
                    Toppings.Text += " Sausage ";
                }
            }
            else
            {
                //removes sausage from toppings if unchecked
                Toppings.Text = Toppings.Text.Replace("Sausage", "");
            }
            if (string.IsNullOrWhiteSpace(Toppings.Text) || Toppings.Text == "Toppings: ")
            {
                //shows none if no toppings selected
                Toppings.Text = "Toppings: None"; 
            }
        }

        private void bacon_CheckedChanged(object sender, EventArgs e)
        {
            if (bacon.Checked)
            {

                if (!Toppings.Text.Contains(" Bacon"))
                {
                    Toppings.Text += " Bacon ";
                }
            }
            else
            {
                //removes bacon from toppings if unchecked
                Toppings.Text = Toppings.Text.Replace("Bacon", "");
            }
            if (string.IsNullOrWhiteSpace(Toppings.Text) || Toppings.Text == "Toppings: ")
            {
                Toppings.Text = "Toppings: None"; //shows none if none checked
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (olive.Checked)
            {

                if (!Toppings.Text.Contains(" Black Olives"))
                {
                    Toppings.Text += " Black Olives ";
                }
            }
            else
            {
                //removes pepperoni from toppings if unchecked
                Toppings.Text = Toppings.Text.Replace("Black Olives", "");
            }
            if (string.IsNullOrWhiteSpace(Toppings.Text) || Toppings.Text == "Toppings: ")
            {
                Toppings.Text = "Toppings: None"; //shows none if none checked
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (peppers.Checked)
            {

                if (!Toppings.Text.Contains(" Green Peppers"))
                {
                    Toppings.Text += " Green Peppers ";
                }
            }
            else
            {
                //removes bacon from toppings if unchecked
                Toppings.Text = Toppings.Text.Replace("Green Peppers", "");
            }
            if (string.IsNullOrWhiteSpace(Toppings.Text) || Toppings.Text == "Toppings: ")
            {
                Toppings.Text = "Toppings: None"; //shows none if none checked
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //adding cheese to order group box
            cheese.Text = " ";
            string selectedItem = comboBox1.SelectedItem.ToString();
            cheese.Text = "Cheese: " + selectedItem;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //adding sauce to order group box
            sauce.Text = " ";
            string selectedItem = comboBox2.SelectedItem.ToString();
            sauce.Text = "Sauce: " + selectedItem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

    }
}
