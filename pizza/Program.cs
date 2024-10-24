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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
