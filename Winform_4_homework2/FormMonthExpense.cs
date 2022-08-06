using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_4_homework2
{
    public partial class FormMonthExpense : Form
    {
        private decimal totalLive = 0;
        private decimal totalFamily = 0;
        private decimal totalPerson = 0;
        private decimal totalOther = 0;
        public FormMonthExpense()
        {
            InitializeComponent();
        }

        private void restValue()
        {
            textLiveExpense.Text = "";
            textFamilyExpense.Text = "";
            textPersonExpense.Text = "";
            textOtherExpense.Text = "";
        }

        private string bubbleSort(decimal[] data)
        {
            decimal temp = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++)
                    if (data[j] > data[j + 1])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
            }
            return string.Join(",", data.Select(c => c.ToString("0.00")));
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            //get info
            totalLive = textLiveExpense.Text.Trim().Split(',').Select(c => decimal.Parse(c)).Sum();
            totalFamily = textFamilyExpense.Text.Trim().Split(',').Select(c => decimal.Parse(c)).Sum();
            totalPerson = textPersonExpense.Text.Trim().Split(',').Select(c => decimal.Parse(c)).Sum();
            totalOther = textOtherExpense.Text.Trim().Split(',').Select(c => decimal.Parse(c)).Sum();

            // show sort
            textLiveExpense.Text = bubbleSort(textLiveExpense.Text.Trim().Split(',').Select(c => decimal.Parse(c)).ToArray());
     

            // show info
            labelLiveTotal.Text = totalLive.ToString("0.00");
            labelFamilyTotal.Text = totalFamily.ToString("0.00");
            labelPersonTotal.Text = totalPerson.ToString("0.00");
            labelOtherTotal.Text = totalOther.ToString("0.00");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            restValue();
        }
    }
}
