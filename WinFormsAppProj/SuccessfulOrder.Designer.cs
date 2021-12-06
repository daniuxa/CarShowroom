
namespace WinFormsAppProj
{
    partial class SuccessfulOrder
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
            this.VisitDate = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OKButtn = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
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
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // VisitDate
            // 
            this.VisitDate.AutoSize = true;
            this.VisitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitDate.Location = new System.Drawing.Point(246, 173);
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.Size = new System.Drawing.Size(116, 20);
            this.VisitDate.TabIndex = 28;
            this.VisitDate.Text = "Дату візиту: ";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(246, 138);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(206, 20);
            this.Phone.TabIndex = 27;
            this.Phone.Text = "Ваш номер телефону:  ";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.Location = new System.Drawing.Point(246, 105);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(71, 20);
            this.Sex.TabIndex = 26;
            this.Sex.Text = "Стать: ";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(246, 74);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(147, 20);
            this.Surname.TabIndex = 25;
            this.Surname.Text = "Ваше прізвище: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(246, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 48);
            this.label3.TabIndex = 29;
            this.label3.Text = "Найближчим часом з вами \r\nзв\'яжуться наші менеджери";
            // 
            // OKButtn
            // 
            this.OKButtn.Location = new System.Drawing.Point(314, 294);
            this.OKButtn.Name = "OKButtn";
            this.OKButtn.Size = new System.Drawing.Size(94, 32);
            this.OKButtn.TabIndex = 30;
            this.OKButtn.Text = "ОК";
            this.OKButtn.UseVisualStyleBackColor = true;
            this.OKButtn.Click += new System.EventHandler(this.OKButtn_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerName.Location = new System.Drawing.Point(246, 41);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 31;
            this.CustomerName.Text = "Ваше ім\'я: ";
            // 
            // SuccessfulOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.OKButtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VisitDate);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessfulOrder";
            this.Text = "SuccessfulOrder";
            this.Load += new System.EventHandler(this.SuccessfulOrder_Load);
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label VisitDate;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButtn;
        private System.Windows.Forms.Label CustomerName;
    }
}