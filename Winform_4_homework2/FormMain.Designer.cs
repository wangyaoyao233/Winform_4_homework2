namespace Winform_4_homework2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonItemInfo = new System.Windows.Forms.Button();
            this.buttonExpenseEnum = new System.Windows.Forms.Button();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.buttonExpense = new System.Windows.Forms.Button();
            this.buttonMonthExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonItemInfo
            // 
            this.buttonItemInfo.Location = new System.Drawing.Point(147, 63);
            this.buttonItemInfo.Name = "buttonItemInfo";
            this.buttonItemInfo.Size = new System.Drawing.Size(100, 50);
            this.buttonItemInfo.TabIndex = 0;
            this.buttonItemInfo.Text = "名目信息维护";
            this.buttonItemInfo.UseVisualStyleBackColor = true;
            this.buttonItemInfo.Click += new System.EventHandler(this.buttonItemInfo_Click);
            // 
            // buttonExpenseEnum
            // 
            this.buttonExpenseEnum.Location = new System.Drawing.Point(458, 63);
            this.buttonExpenseEnum.Name = "buttonExpenseEnum";
            this.buttonExpenseEnum.Size = new System.Drawing.Size(100, 50);
            this.buttonExpenseEnum.TabIndex = 1;
            this.buttonExpenseEnum.Text = "支出名目枚举";
            this.buttonExpenseEnum.UseVisualStyleBackColor = true;
            this.buttonExpenseEnum.Click += new System.EventHandler(this.buttonExpenseEnum_Click);
            // 
            // buttonIncome
            // 
            this.buttonIncome.Location = new System.Drawing.Point(147, 196);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(100, 50);
            this.buttonIncome.TabIndex = 2;
            this.buttonIncome.Text = "收入记账";
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // buttonExpense
            // 
            this.buttonExpense.Location = new System.Drawing.Point(458, 196);
            this.buttonExpense.Name = "buttonExpense";
            this.buttonExpense.Size = new System.Drawing.Size(100, 50);
            this.buttonExpense.TabIndex = 3;
            this.buttonExpense.Text = "支出记账";
            this.buttonExpense.UseVisualStyleBackColor = true;
            this.buttonExpense.Click += new System.EventHandler(this.buttonExpense_Click);
            // 
            // buttonMonthExpense
            // 
            this.buttonMonthExpense.Location = new System.Drawing.Point(147, 336);
            this.buttonMonthExpense.Name = "buttonMonthExpense";
            this.buttonMonthExpense.Size = new System.Drawing.Size(100, 50);
            this.buttonMonthExpense.TabIndex = 4;
            this.buttonMonthExpense.Text = "本月输出统计";
            this.buttonMonthExpense.UseVisualStyleBackColor = true;
            this.buttonMonthExpense.Click += new System.EventHandler(this.buttonMonthExpense_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 427);
            this.Controls.Add(this.buttonMonthExpense);
            this.Controls.Add(this.buttonExpense);
            this.Controls.Add(this.buttonIncome);
            this.Controls.Add(this.buttonExpenseEnum);
            this.Controls.Add(this.buttonItemInfo);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonItemInfo;
        private System.Windows.Forms.Button buttonExpenseEnum;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonExpense;
        private System.Windows.Forms.Button buttonMonthExpense;
    }
}

