using System;
using System.Windows.Forms;

namespace Winform_4_homework2
{
    public partial class FormExpenseEnum : Form
    {
        public FormExpenseEnum()
        {
            InitializeComponent();
        }

        //生活消费、还朋友钱、付客户账款、其他支出
        enum ExpenseType
        {
            生活消费,
            还朋友钱,
            付客户账款,
            其他支出
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = this.comboBoxName.SelectedValue.ToString();
            Enum.TryParse(name, out ExpenseType type);

            MessageBox.Show($"名称:{type.ToString()}, 值:{(int)type}");
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormExpenseEnum_Load(object sender, EventArgs e)
        {
            this.comboBoxName.DataSource = Enum.GetValues(typeof(ExpenseType));
        }
    }
}
