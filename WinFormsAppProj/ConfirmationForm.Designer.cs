
namespace WinFormsAppProj
{
    partial class ConfirmationForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.TypeAuto = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.ProdYear = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.TypeEngine = new System.Windows.Forms.Label();
            this.FstField = new System.Windows.Forms.Label();
            this.ScdField = new System.Windows.Forms.Label();
            this.SoundButtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YesButtn = new System.Windows.Forms.Button();
            this.NoButtn = new System.Windows.Forms.Button();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Silver;
            this.TopBorder.Controls.Add(this.button1);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(800, 28);
            this.TopBorder.TabIndex = 16;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(772, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TypeAuto
            // 
            this.TypeAuto.AutoSize = true;
            this.TypeAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeAuto.Location = new System.Drawing.Point(55, 66);
            this.TypeAuto.Name = "TypeAuto";
            this.TypeAuto.Size = new System.Drawing.Size(94, 20);
            this.TypeAuto.TabIndex = 18;
            this.TypeAuto.Text = "Тип авто: ";
            this.TypeAuto.Click += new System.EventHandler(this.TypeAuto_Click);
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand.Location = new System.Drawing.Point(55, 95);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(73, 20);
            this.Brand.TabIndex = 19;
            this.Brand.Text = "Бренд: ";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.Location = new System.Drawing.Point(55, 125);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(85, 20);
            this.Model.TabIndex = 20;
            this.Model.Text = "Модель: ";
            // 
            // ProdYear
            // 
            this.ProdYear.AutoSize = true;
            this.ProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdYear.Location = new System.Drawing.Point(55, 161);
            this.ProdYear.Name = "ProdYear";
            this.ProdYear.Size = new System.Drawing.Size(112, 20);
            this.ProdYear.TabIndex = 21;
            this.ProdYear.Text = "Рік випуску: ";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(55, 194);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(56, 20);
            this.Price.TabIndex = 22;
            this.Price.Text = "Ціна: ";
            // 
            // Power
            // 
            this.Power.AutoSize = true;
            this.Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Power.Location = new System.Drawing.Point(55, 259);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(115, 20);
            this.Power.TabIndex = 23;
            this.Power.Text = "Потужність: ";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Volume.Location = new System.Drawing.Point(55, 290);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(67, 20);
            this.Volume.TabIndex = 24;
            this.Volume.Text = "Об\'єм: ";
            // 
            // TypeEngine
            // 
            this.TypeEngine.AutoSize = true;
            this.TypeEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeEngine.Location = new System.Drawing.Point(55, 226);
            this.TypeEngine.Name = "TypeEngine";
            this.TypeEngine.Size = new System.Drawing.Size(122, 20);
            this.TypeEngine.TabIndex = 25;
            this.TypeEngine.Text = "Тип двигуна: ";
            // 
            // FstField
            // 
            this.FstField.AutoSize = true;
            this.FstField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FstField.Location = new System.Drawing.Point(55, 322);
            this.FstField.Name = "FstField";
            this.FstField.Size = new System.Drawing.Size(28, 20);
            this.FstField.TabIndex = 26;
            this.FstField.Text = "1: ";
            // 
            // ScdField
            // 
            this.ScdField.AutoSize = true;
            this.ScdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScdField.Location = new System.Drawing.Point(55, 354);
            this.ScdField.Name = "ScdField";
            this.ScdField.Size = new System.Drawing.Size(28, 20);
            this.ScdField.TabIndex = 27;
            this.ScdField.Text = "2: ";
            // 
            // SoundButtn
            // 
            this.SoundButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoundButtn.Location = new System.Drawing.Point(36, 392);
            this.SoundButtn.Name = "SoundButtn";
            this.SoundButtn.Size = new System.Drawing.Size(224, 46);
            this.SoundButtn.TabIndex = 28;
            this.SoundButtn.Text = "Послухати звук авто";
            this.SoundButtn.UseVisualStyleBackColor = true;
            this.SoundButtn.Click += new System.EventHandler(this.SoundButtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(386, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Підтверджуєте купівлю:";
            // 
            // YesButtn
            // 
            this.YesButtn.Location = new System.Drawing.Point(605, 402);
            this.YesButtn.Name = "YesButtn";
            this.YesButtn.Size = new System.Drawing.Size(75, 23);
            this.YesButtn.TabIndex = 30;
            this.YesButtn.Text = "Так";
            this.YesButtn.UseVisualStyleBackColor = true;
            this.YesButtn.Click += new System.EventHandler(this.YesButtn_Click);
            // 
            // NoButtn
            // 
            this.NoButtn.Location = new System.Drawing.Point(696, 402);
            this.NoButtn.Name = "NoButtn";
            this.NoButtn.Size = new System.Drawing.Size(75, 23);
            this.NoButtn.TabIndex = 31;
            this.NoButtn.Text = "Ні";
            this.NoButtn.UseVisualStyleBackColor = true;
            this.NoButtn.Click += new System.EventHandler(this.NoButtn_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoButtn);
            this.Controls.Add(this.YesButtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoundButtn);
            this.Controls.Add(this.ScdField);
            this.Controls.Add(this.FstField);
            this.Controls.Add(this.TypeEngine);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProdYear);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.TypeAuto);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TypeAuto;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label ProdYear;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label TypeEngine;
        private System.Windows.Forms.Label FstField;
        private System.Windows.Forms.Label ScdField;
        private System.Windows.Forms.Button SoundButtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesButtn;
        private System.Windows.Forms.Button NoButtn;
    }
}