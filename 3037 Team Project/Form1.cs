using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3037_Team_Project
{
    public partial class Form1 : Form
    {
        Employee glooba = new Employee("Glooba", 2345, 9);
        public Form1()
        {
            
            InitializeComponent();
        }


        
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clock_out_button_Click(object sender, EventArgs e)
        {
            glooba.Clock_Out();
            label2.Text += "\nEmployee " + glooba.Name + " has clocked out after working for " + glooba.HoursWorked +
                 " hours.";
        }

        private void clock_in_button_Click(object sender, EventArgs e)
        {
            
            glooba.Clock_In();

            label2.Text = "Employee " + glooba.Name + " is clocked in.";
        }
    }


}
