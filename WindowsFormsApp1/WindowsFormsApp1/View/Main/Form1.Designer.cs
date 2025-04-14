namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Assortiment_button = new System.Windows.Forms.Button();
            this.Product_button = new System.Windows.Forms.Button();
            this.Provide_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информационная система\r\nпредприятия ОП";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Assortiment_button
            // 
            this.Assortiment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Assortiment_button.Location = new System.Drawing.Point(54, 82);
            this.Assortiment_button.Name = "Assortiment_button";
            this.Assortiment_button.Size = new System.Drawing.Size(354, 71);
            this.Assortiment_button.TabIndex = 1;
            this.Assortiment_button.Text = "Ассоритмент ";
            this.Assortiment_button.UseVisualStyleBackColor = true;
            this.Assortiment_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product_button
            // 
            this.Product_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Product_button.Location = new System.Drawing.Point(54, 194);
            this.Product_button.Name = "Product_button";
            this.Product_button.Size = new System.Drawing.Size(354, 71);
            this.Product_button.TabIndex = 2;
            this.Product_button.Text = "Запасы";
            this.Product_button.UseVisualStyleBackColor = true;
            this.Product_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Provide_button
            // 
            this.Provide_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Provide_button.Location = new System.Drawing.Point(54, 317);
            this.Provide_button.Name = "Provide_button";
            this.Provide_button.Size = new System.Drawing.Size(354, 71);
            this.Provide_button.TabIndex = 3;
            this.Provide_button.Text = "Поставщики";
            this.Provide_button.UseVisualStyleBackColor = true;
            this.Provide_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.Provide_button);
            this.Controls.Add(this.Product_button);
            this.Controls.Add(this.Assortiment_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Assortiment_button;
        private System.Windows.Forms.Button Product_button;
        private System.Windows.Forms.Button Provide_button;
    }
}

