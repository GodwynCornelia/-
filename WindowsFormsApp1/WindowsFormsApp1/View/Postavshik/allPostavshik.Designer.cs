namespace WindowsFormsApp1
{
    partial class allPostavshik
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddresBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BankBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.INNBox = new System.Windows.Forms.TextBox();
            this.СheckBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProvideListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Выберите поставщика для просмотра информации";
            // 
            // AddresBox
            // 
            this.AddresBox.Location = new System.Drawing.Point(486, 128);
            this.AddresBox.Multiline = true;
            this.AddresBox.Name = "AddresBox";
            this.AddresBox.ReadOnly = true;
            this.AddresBox.Size = new System.Drawing.Size(199, 20);
            this.AddresBox.TabIndex = 17;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(486, 79);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(199, 20);
            this.NameBox.TabIndex = 18;
            // 
            // BankBox
            // 
            this.BankBox.Location = new System.Drawing.Point(486, 273);
            this.BankBox.Multiline = true;
            this.BankBox.Name = "BankBox";
            this.BankBox.ReadOnly = true;
            this.BankBox.Size = new System.Drawing.Size(199, 20);
            this.BankBox.TabIndex = 19;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(486, 224);
            this.PhoneBox.Multiline = true;
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.ReadOnly = true;
            this.PhoneBox.Size = new System.Drawing.Size(199, 20);
            this.PhoneBox.TabIndex = 20;
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(486, 176);
            this.FIOBox.Multiline = true;
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.ReadOnly = true;
            this.FIOBox.Size = new System.Drawing.Size(199, 20);
            this.FIOBox.TabIndex = 21;
            // 
            // INNBox
            // 
            this.INNBox.Location = new System.Drawing.Point(486, 371);
            this.INNBox.Multiline = true;
            this.INNBox.Name = "INNBox";
            this.INNBox.ReadOnly = true;
            this.INNBox.Size = new System.Drawing.Size(199, 20);
            this.INNBox.TabIndex = 22;
            // 
            // СheckBox
            // 
            this.СheckBox.Location = new System.Drawing.Point(486, 321);
            this.СheckBox.Multiline = true;
            this.СheckBox.Name = "СheckBox";
            this.СheckBox.ReadOnly = true;
            this.СheckBox.Size = new System.Drawing.Size(199, 20);
            this.СheckBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Банк поставщика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Расчётный счёт в этом банке";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Телефон руководителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "ФИО руководителя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Название";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(482, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 48);
            this.label9.TabIndex = 31;
            this.label9.Text = "Информация\r\nо поставщике";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ProvideListBox
            // 
            this.ProvideListBox.FormattingEnabled = true;
            this.ProvideListBox.Location = new System.Drawing.Point(29, 96);
            this.ProvideListBox.Name = "ProvideListBox";
            this.ProvideListBox.Size = new System.Drawing.Size(323, 251);
            this.ProvideListBox.TabIndex = 0;
            this.ProvideListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // allPostavshik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.ProvideListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.СheckBox);
            this.Controls.Add(this.INNBox);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddresBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "allPostavshik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.allPostavshik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddresBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox BankBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox INNBox;
        private System.Windows.Forms.TextBox СheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox ProvideListBox;
    }
}