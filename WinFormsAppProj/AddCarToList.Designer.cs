
namespace WinFormsAppProj
{
    partial class AddCarToList
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
            this.TopBorder = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EngineComboBox = new System.Windows.Forms.ComboBox();
            this.HelpCheckBox = new System.Windows.Forms.CheckBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.EngineListView = new System.Windows.Forms.ListView();
            this.NameEngine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Power = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.YearProdComboBox = new System.Windows.Forms.ComboBox();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.ExtraField1 = new System.Windows.Forms.Label();
            this.ExtraField2 = new System.Windows.Forms.Label();
            this.TypeBodyComboBox = new System.Windows.Forms.ComboBox();
            this.CarryingCapacityBox = new System.Windows.Forms.TextBox();
            this.ExtraTextBox2 = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Silver;
            this.TopBorder.Controls.Add(this.CloseButton);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(800, 28);
            this.TopBorder.TabIndex = 18;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(772, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Бренд:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(187, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Модель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(187, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Рік виготовлення:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(191, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Тип двигуна:";
            // 
            // EngineComboBox
            // 
            this.EngineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EngineComboBox.FormattingEnabled = true;
            this.EngineComboBox.Location = new System.Drawing.Point(384, 218);
            this.EngineComboBox.Name = "EngineComboBox";
            this.EngineComboBox.Size = new System.Drawing.Size(144, 24);
            this.EngineComboBox.TabIndex = 28;
            this.EngineComboBox.SelectedIndexChanged += new System.EventHandler(this.EngineComboBox_SelectedIndexChanged);
            // 
            // HelpCheckBox
            // 
            this.HelpCheckBox.AutoSize = true;
            this.HelpCheckBox.Location = new System.Drawing.Point(548, 221);
            this.HelpCheckBox.Name = "HelpCheckBox";
            this.HelpCheckBox.Size = new System.Drawing.Size(95, 21);
            this.HelpCheckBox.TabIndex = 30;
            this.HelpCheckBox.Text = "Підсказка";
            this.HelpCheckBox.UseVisualStyleBackColor = true;
            this.HelpCheckBox.CheckedChanged += new System.EventHandler(this.HelpCheckBox_CheckedChanged);
            // 
            // AddCar
            // 
            this.AddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCar.Location = new System.Drawing.Point(311, 356);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(93, 35);
            this.AddCar.TabIndex = 31;
            this.AddCar.Text = "Додати";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // EngineListView
            // 
            this.EngineListView.BackColor = System.Drawing.SystemColors.Menu;
            this.EngineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameEngine,
            this.Type,
            this.Power,
            this.Volume});
            this.EngineListView.GridLines = true;
            this.EngineListView.HideSelection = false;
            this.EngineListView.Location = new System.Drawing.Point(442, 356);
            this.EngineListView.Name = "EngineListView";
            this.EngineListView.Size = new System.Drawing.Size(346, 129);
            this.EngineListView.TabIndex = 32;
            this.EngineListView.UseCompatibleStateImageBehavior = false;
            this.EngineListView.View = System.Windows.Forms.View.Details;
            this.EngineListView.SelectedIndexChanged += new System.EventHandler(this.EngineListView_SelectedIndexChanged);
            // 
            // NameEngine
            // 
            this.NameEngine.Text = "Назва";
            this.NameEngine.Width = 79;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 78;
            // 
            // Power
            // 
            this.Power.Text = "Потужність";
            this.Power.Width = 93;
            // 
            // Volume
            // 
            this.Volume.Text = "Об\'єм";
            this.Volume.Width = 92;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Легковий автомобіль",
            "Вантажівка"});
            this.TypeComboBox.Location = new System.Drawing.Point(384, 40);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(144, 24);
            this.TypeComboBox.TabIndex = 33;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // YearProdComboBox
            // 
            this.YearProdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearProdComboBox.FormattingEnabled = true;
            this.YearProdComboBox.Location = new System.Drawing.Point(384, 145);
            this.YearProdComboBox.Name = "YearProdComboBox";
            this.YearProdComboBox.Size = new System.Drawing.Size(144, 24);
            this.YearProdComboBox.TabIndex = 34;
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(384, 73);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(144, 24);
            this.BrandComboBox.TabIndex = 35;
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(384, 106);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(144, 24);
            this.ModelComboBox.TabIndex = 36;
            // 
            // ExtraField1
            // 
            this.ExtraField1.AutoSize = true;
            this.ExtraField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtraField1.Location = new System.Drawing.Point(191, 266);
            this.ExtraField1.Name = "ExtraField1";
            this.ExtraField1.Size = new System.Drawing.Size(157, 20);
            this.ExtraField1.TabIndex = 37;
            this.ExtraField1.Text = "Додаткове поле1";
            // 
            // ExtraField2
            // 
            this.ExtraField2.AutoSize = true;
            this.ExtraField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtraField2.Location = new System.Drawing.Point(187, 303);
            this.ExtraField2.Name = "ExtraField2";
            this.ExtraField2.Size = new System.Drawing.Size(162, 20);
            this.ExtraField2.TabIndex = 38;
            this.ExtraField2.Text = "Додаткове поле 2";
            // 
            // TypeBodyComboBox
            // 
            this.TypeBodyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBodyComboBox.FormattingEnabled = true;
            this.TypeBodyComboBox.Items.AddRange(new object[] {
            "Седан",
            "Кросовер",
            "Хетчбек"});
            this.TypeBodyComboBox.Location = new System.Drawing.Point(384, 262);
            this.TypeBodyComboBox.Name = "TypeBodyComboBox";
            this.TypeBodyComboBox.Size = new System.Drawing.Size(144, 24);
            this.TypeBodyComboBox.TabIndex = 39;
            // 
            // CarryingCapacityBox
            // 
            this.CarryingCapacityBox.Location = new System.Drawing.Point(384, 264);
            this.CarryingCapacityBox.Name = "CarryingCapacityBox";
            this.CarryingCapacityBox.Size = new System.Drawing.Size(144, 22);
            this.CarryingCapacityBox.TabIndex = 40;
            // 
            // ExtraTextBox2
            // 
            this.ExtraTextBox2.Location = new System.Drawing.Point(384, 301);
            this.ExtraTextBox2.Name = "ExtraTextBox2";
            this.ExtraTextBox2.Size = new System.Drawing.Size(144, 22);
            this.ExtraTextBox2.TabIndex = 41;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(191, 183);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(51, 20);
            this.PriceLabel.TabIndex = 42;
            this.PriceLabel.Text = "Ціна:";
            this.PriceLabel.Click += new System.EventHandler(this.Price_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(384, 183);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(144, 22);
            this.PriceTextBox.TabIndex = 43;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // AddCarToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ExtraTextBox2);
            this.Controls.Add(this.CarryingCapacityBox);
            this.Controls.Add(this.TypeBodyComboBox);
            this.Controls.Add(this.ExtraField2);
            this.Controls.Add(this.ExtraField1);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.BrandComboBox);
            this.Controls.Add(this.YearProdComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.EngineListView);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.HelpCheckBox);
            this.Controls.Add(this.EngineComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarToList";
            this.Text = "AddCarToList";
            this.Load += new System.EventHandler(this.AddCarToList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddCarToList_MouseDown);
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EngineComboBox;
        private System.Windows.Forms.CheckBox HelpCheckBox;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.ListView EngineListView;
        private System.Windows.Forms.ColumnHeader NameEngine;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Power;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox YearProdComboBox;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.Label ExtraField1;
        private System.Windows.Forms.Label ExtraField2;
        private System.Windows.Forms.ComboBox TypeBodyComboBox;
        private System.Windows.Forms.TextBox CarryingCapacityBox;
        private System.Windows.Forms.TextBox ExtraTextBox2;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}