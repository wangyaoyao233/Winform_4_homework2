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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonItemInfo_Click(object sender, EventArgs e)
        {
            FormItemInfo formItemInfo = new FormItemInfo();
            formItemInfo.Show();
        }

        private void buttonExpenseEnum_Click(object sender, EventArgs e)
        {
            FormExpenseEnum formExpenseEnum = new FormExpenseEnum();
            formExpenseEnum.Show();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            FormIncoming formIncoming = new FormIncoming();
            formIncoming.Show();
        }

        private void buttonExpense_Click(object sender, EventArgs e)
        {
            FormExpense formExpense = new FormExpense();
            formExpense.Show();
        }

        private void buttonMonthExpense_Click(object sender, EventArgs e)
        {
            FormMonthExpense formMonthExpense = new FormMonthExpense();
            formMonthExpense.Show();
        }
    }
}
