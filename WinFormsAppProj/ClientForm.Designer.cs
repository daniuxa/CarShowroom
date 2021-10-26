
namespace WinFormsAppProj
{
    partial class ClientForm
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
            this.TypeAuto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrandAuto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelAuto = new System.Windows.Forms.ComboBox();
            this.SearcButtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FromYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ToYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Виберіть тип авто";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TypeAuto
            // 
            this.TypeAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeAuto.FormattingEnabled = true;
            this.TypeAuto.Items.AddRange(new object[] {
            "Легковий автомобіль",
            "Вантажівка"});
            this.TypeAuto.Location = new System.Drawing.Point(246, 32);
            this.TypeAuto.Name = "TypeAuto";
            this.TypeAuto.Size = new System.Drawing.Size(226, 24);
            this.TypeAuto.TabIndex = 3;
            this.TypeAuto.SelectedIndexChanged += new System.EventHandler(this.TypeAuto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Виберіть бренд авто";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BrandAuto
            // 
            this.BrandAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandAuto.FormattingEnabled = true;
            this.BrandAuto.Items.AddRange(new object[] {
            "Виберіть тип"});
            this.BrandAuto.Location = new System.Drawing.Point(246, 81);
            this.BrandAuto.Name = "BrandAuto";
            this.BrandAuto.Size = new System.Drawing.Size(226, 24);
            this.BrandAuto.TabIndex = 5;
            this.BrandAuto.SelectedIndexChanged += new System.EventHandler(this.BrandAuto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Виберіть модель авто";
            // 
            // ModelAuto
            // 
            this.ModelAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelAuto.FormattingEnabled = true;
            this.ModelAuto.Items.AddRange(new object[] {
            "Визначте тип і бренд"});
            this.ModelAuto.Location = new System.Drawing.Point(246, 126);
            this.ModelAuto.Name = "ModelAuto";
            this.ModelAuto.Size = new System.Drawing.Size(226, 24);
            this.ModelAuto.TabIndex = 7;
            this.ModelAuto.SelectedIndexChanged += new System.EventHandler(this.ModelAuto_SelectedIndexChanged);
            // 
            // SearcButtn
            // 
            this.SearcButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearcButtn.Location = new System.Drawing.Point(17, 256);
            this.SearcButtn.Name = "SearcButtn";
            this.SearcButtn.Size = new System.Drawing.Size(198, 47);
            this.SearcButtn.TabIndex = 8;
            this.SearcButtn.Text = "Пошук автомобіля";
            this.SearcButtn.UseVisualStyleBackColor = true;
            this.SearcButtn.Click += new System.EventHandler(this.SearcButtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Рік випуску";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(158, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Від:";
            // 
            // FromYear
            // 
            this.FromYear.Location = new System.Drawing.Point(210, 175);
            this.FromYear.Name = "FromYear";
            this.FromYear.Size = new System.Drawing.Size(100, 22);
            this.FromYear.TabIndex = 11;
            this.FromYear.TextChanged += new System.EventHandler(this.FromYear_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(339, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "До:";
            // 
            // ToYear
            // 
            this.ToYear.Location = new System.Drawing.Point(391, 178);
            this.ToYear.Name = "ToYear";
            this.ToYear.Size = new System.Drawing.Size(100, 22);
            this.ToYear.TabIndex = 13;
            this.ToYear.TextChanged += new System.EventHandler(this.ToYear_TextChanged);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::WinFormsAppProj.Properties.Resources.логотип_автосалона_спорт_автоматического_магазина_на_белизне_151783950;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.ToYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FromYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearcButtn);
            this.Controls.Add(this.ModelAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrandAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeAuto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BrandAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModelAuto;
        private System.Windows.Forms.Button SearcButtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FromYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ToYear;
    }
}

