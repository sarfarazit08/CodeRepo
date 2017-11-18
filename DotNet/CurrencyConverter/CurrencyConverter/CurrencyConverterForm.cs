using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConverterForm : Form
    {
        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double multiplier;

            if (txtCurrency1.Text == "")
            {
                multiplier = 1.0;
            }
            else
            {
                multiplier = double.Parse(txtCurrency1.Text);
            }

            if (cb1.SelectedItem != null && cb2.SelectedItem != null)
            {
                lblValue.Text = value(cb1.SelectedItem.ToString(), cb2.SelectedItem.ToString(), multiplier).ToString();
            }
            else
            {
                lblValue.Text = "Please select currency!";
            }
        }

        public double value(string currency1, string currency2, double multiplier)
        {
            double currencyValue1 = 0.0;
            double currencyValue2 = 0.0;
            Dictionary<string, double> DicObj = new Dictionary<string, double>();

            DicObj.Add("BP", 0.76);
            DicObj.Add("INR", 67.98);
            DicObj.Add("SD", 1.36);
            DicObj.Add("JY", 101.61);
            DicObj.Add("CY", 6.67);
            DicObj.Add("GM", 1.72);
            DicObj.Add("USD", 1.00);

            if (DicObj.ContainsKey(currency1) && DicObj.ContainsKey(currency2))
            {
                currencyValue1 = DicObj[currency1];
                currencyValue2 = DicObj[currency2];
            }

            return (currencyValue2 / currencyValue1) * (multiplier);
        }
    }
}
