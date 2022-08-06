using System;
using System.Windows.Forms;

namespace Winform_4_homework2
{
    public partial class FormIncoming : Form
    {
        private decimal totalMoney = 0;
        private bool canRecord = false;
        public FormIncoming()
        {
            InitializeComponent();
        }

        //工资收入、银行转账、朋友还钱、其他收入。
        enum IncomingType
        {
            工资收入,
            银行转账,
            朋友还钱,
            其他收入
        }


        /// <summary>
        /// 重置
        /// </summary>
        private void resetValue()
        {
            textName.Text = "";
            textMoney.Text = "";
            textDescription.Text = "";
            canRecord = false;
        }

        /// <summary>
        /// 检查名目
        /// </summary>
        private void checkName()
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                labelNameError.Text = Define.EMPTY;
                canRecord = false;
                return;
            }

            foreach (var v in Enum.GetValues(typeof(IncomingType)))
            {
                // no error
                if (textName.Text.Trim().Equals(v.ToString()))
                {
                    labelNameError.Text = "";
                    canRecord = true;
                    return;
                }
            }
            labelNameError.Text = Define.INCOMINGTYPEERROR;
            canRecord = false;
        }

        /// <summary>
        /// 检查金额
        /// </summary>
        private void checkMoney()
        {
            if (string.IsNullOrWhiteSpace(textMoney.Text))
            {
                labelMoneyError.Text = Define.EMPTY;
                canRecord = false;
            }
            else if (!decimal.TryParse(textMoney.Text.Trim(), out decimal result))
            {
                labelMoneyError.Text = Define.DECIMALERROR;
                canRecord = false;
            }
            else
            {
                // no error
                labelMoneyError.Text = "";
                canRecord = true;
            }
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (!canRecord) return;

            // get info
            IncomingInfo incomingInfo = new IncomingInfo(
                textName.Text.Trim(), 
                textDescription.Text.Trim(),
                decimal.Parse(textMoney.Text)
               );

            // show info
            labelTotal.Text = incomingInfo.TotalMoney().ToString("0.00");
            labelDetail.Text = incomingInfo.Detail(labelDetail.Text);

            resetValue();
        }

        private void textName_Enter(object sender, EventArgs e)
        {
            checkName();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            checkName();
        }

        private void textMoney_Enter(object sender, EventArgs e)
        {
            checkMoney();
        }

        private void textMoney_TextChanged(object sender, EventArgs e)
        {
            checkMoney();
        }
    }
}
