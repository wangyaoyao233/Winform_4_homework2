namespace Winform_4_homework2
{
    partial class FormMonthExpense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLiveExpense = new System.Windows.Forms.TextBox();
            this.textFamilyExpense = new System.Windows.Forms.TextBox();
            this.textPersonExpense = new System.Windows.Forms.TextBox();
            this.textOtherExpense = new System.Windows.Forms.TextBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelLiveTotal = new System.Windows.Forms.Label();
            this.labelFamilyTotal = new System.Windows.Forms.Label();
            this.labelPersonTotal = new System.Windows.Forms.Label();
            this.labelOtherTotal = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "生活消费支出";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "家庭缴费";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "个人支出";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "其他支出";
            // 
            // textLiveExpense
            // 
            this.textLiveExpense.Location = new System.Drawing.Point(218, 31);
            this.textLiveExpense.Name = "textLiveExpense";
            this.textLiveExpense.Size = new System.Drawing.Size(395, 21);
            this.textLiveExpense.TabIndex = 4;
            // 
            // textFamilyExpense
            // 
            this.textFamilyExpense.Location = new System.Drawing.Point(218, 88);
            this.textFamilyExpense.Name = "textFamilyExpense";
            this.textFamilyExpense.Size = new System.Drawing.Size(395, 21);
            this.textFamilyExpense.TabIndex = 5;
            // 
            // textPersonExpense
            // 
            this.textPersonExpense.Location = new System.Drawing.Point(218, 147);
            this.textPersonExpense.Name = "textPersonExpense";
            this.textPersonExpense.Size = new System.Drawing.Size(395, 21);
            this.textPersonExpense.TabIndex = 6;
            // 
            // textOtherExpense
            // 
            this.textOtherExpense.Location = new System.Drawing.Point(218, 207);
            this.textOtherExpense.Name = "textOtherExpense";
            this.textOtherExpense.Size = new System.Drawing.Size(395, 21);
            this.textOtherExpense.TabIndex = 7;
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(267, 268);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(91, 40);
            this.buttonRecord.TabIndex = 8;
            this.buttonRecord.Text = "统计";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "生活总消费:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "家庭总消费:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "个人总消费:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "其他总消费:";
            // 
            // labelLiveTotal
            // 
            this.labelLiveTotal.AutoSize = true;
            this.labelLiveTotal.Location = new System.Drawing.Point(247, 341);
            this.labelLiveTotal.Name = "labelLiveTotal";
            this.labelLiveTotal.Size = new System.Drawing.Size(0, 12);
            this.labelLiveTotal.TabIndex = 13;
            // 
            // labelFamilyTotal
            // 
            this.labelFamilyTotal.AutoSize = true;
            this.labelFamilyTotal.Location = new System.Drawing.Point(516, 341);
            this.labelFamilyTotal.Name = "labelFamilyTotal";
            this.labelFamilyTotal.Size = new System.Drawing.Size(0, 12);
            this.labelFamilyTotal.TabIndex = 14;
            // 
            // labelPersonTotal
            // 
            this.labelPersonTotal.AutoSize = true;
            this.labelPersonTotal.Location = new System.Drawing.Point(247, 400);
            this.labelPersonTotal.Name = "labelPersonTotal";
            this.labelPersonTotal.Size = new System.Drawing.Size(0, 12);
            this.labelPersonTotal.TabIndex = 15;
            // 
            // labelOtherTotal
            // 
            this.labelOtherTotal.AutoSize = true;
            this.labelOtherTotal.Location = new System.Drawing.Point(516, 400);
            this.labelOtherTotal.Name = "labelOtherTotal";
            this.labelOtherTotal.Size = new System.Drawing.Size(0, 12);
            this.labelOtherTotal.TabIndex = 16;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(451, 268);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 40);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "重置";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormMonthExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelOtherTotal);
            this.Controls.Add(this.labelPersonTotal);
            this.Controls.Add(this.labelFamilyTotal);
            this.Controls.Add(this.labelLiveTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.textOtherExpense);
            this.Controls.Add(this.textPersonExpense);
            this.Controls.Add(this.textFamilyExpense);
            this.Controls.Add(this.textLiveExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMonthExpense";
            this.Text = "FormMonthExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLiveExpense;
        private System.Windows.Forms.TextBox textFamilyExpense;
        private System.Windows.Forms.TextBox textPersonExpense;
        private System.Windows.Forms.TextBox textOtherExpense;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLiveTotal;
        private System.Windows.Forms.Label labelFamilyTotal;
        private System.Windows.Forms.Label labelPersonTotal;
        private System.Windows.Forms.Label labelOtherTotal;
        private System.Windows.Forms.Button buttonReset;
    }
}