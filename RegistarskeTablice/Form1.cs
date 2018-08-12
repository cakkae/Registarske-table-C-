using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace RegistarskeTablice
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (Regex.IsMatch(tablica.Text, @"^\D{1}\d{2}[\s\-]?\D{1}[\s\-]?\d{3}$"))
            {
                rezultat.Text = "Tablica je nova";
               
                rezultat.ForeColor = Color.Green;
                rezultat.ReadOnly = true;
                panel.BackgroundImage = Properties.Resources.NovaTablica;
            }
            else if (Regex.IsMatch(tablica.Text, @"^\d{3}[\s\-]?\D{1}[\s\-]?\d{3}$"))
            {
                rezultat.Text = "Tablica je stara";
             
                rezultat.ForeColor = Color.Green;
                panel.BackgroundImage = Properties.Resources.StaraTablica;
            }
            else if (Regex.IsMatch(tablica.Text, @"^TA[\s\-]?\d{6}$")) 
            {
                rezultat.Text = "Tablica je za taxi";
            
                rezultat.ForeColor = Color.Green;
                panel.BackgroundImage = Properties.Resources.TaxiTablica;
            }
            else if (Regex.IsMatch(tablica.Text, @"^TT[\s\-]?\d{6}$"))
            {
                rezultat.Text = "Tablica je privremena";
             
                rezultat.ForeColor = Color.Green;
                panel.BackgroundImage = Properties.Resources.PrivremenaTablica;
            }
            else if (Regex.IsMatch(tablica.Text, @"^d{2}[\s\-]?\D{1}[\s\-]?\d{3}$"))
            {
                rezultat.Text = "Tablica je diplomatska";
             
                rezultat.ForeColor = Color.Green;
                panel.BackgroundImage = Properties.Resources.DiplomatskaTablica;
            }
            else
            {
                rezultat.Text = "Tablica nije validna";
              
                rezultat.ForeColor = Color.Red;            
            }

        }
    }
}
