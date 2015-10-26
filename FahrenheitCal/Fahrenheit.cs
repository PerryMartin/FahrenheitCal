/*
 * Created by: Perry Martin
 * Created on: 26-102015
 * Created for: ICS3U
 * Daily Assignment – Unit#4-01
 * This program displays celsius converting to fahrenhait
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

namespace FahrenheitCal
{
    public partial class frmFahrenheit : Form

    {
        public void Converter(double temp)
         {
            double fahrenheit;

            fahrenheit = (9.0/ 5.0) * temp + 32; 
             MessageBox.Show(Convert.ToString(fahrenheit) + " degrees is the temperature in fahrenheit"); 
         }

    public frmFahrenheit()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double degrees;

            degrees = Convert.ToDouble(this.txtCelsius.Text);
            Converter(degrees);
        }
    }
}
