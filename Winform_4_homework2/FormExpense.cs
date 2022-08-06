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
    public partial class FormExpense : Form
    {
        private decimal totalMoney = 0;
        private int totalNum = 0;
        public FormExpense()
        {
            InitializeComponent();
        }

        private void resetValue()
        {
            this.textName.Text = "";
            this.textDescription.Text = "";
            this.textPrice.Text = "";
            this.textNum.Text = "";
        }

        //定义一个结构体，描述支出记录信息（包含名目名称、支出描述、单价、数量、金额）
        struct Expense
        {
            public string name;
            public decimal money;
            public string description;
            public int num;
            public decimal price;
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            // get info
            expense.name = this.textName.Text;
            expense.description = this.textDescription.Text;
            expense.num = int.Parse(this.textNum.Text);
            expense.price = decimal.Parse(this.textPrice.Text);
            expense.money = expense.price * expense.num;

            // 计算
            totalMoney += expense.money;
            totalNum += expense.num;

            // show info
            this.textMoney.Text = expense.money.ToString("0.00");
            this.labelTotalMoney.Text = totalMoney.ToString("0.00");
            this.labelTotalNum.Text = totalNum.ToString();
            this.labelAverage.Text = (totalMoney / totalNum).ToString("0.00");

            this.labelDetail.Text += $"{expense.name}, {expense.price}, {expense.num}, {expense.money}, {expense.description}\r\n";

            this.resetValue();
        }
    }
}
