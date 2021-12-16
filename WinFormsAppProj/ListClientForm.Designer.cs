
namespace WinFormsAppProj
{
    partial class ListClientForm
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
            this.ClientListView = new System.Windows.Forms.ListView();
            this.NameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VisitDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DetailInfoButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
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
            this.TopBorder.TabIndex = 17;
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
            // ClientListView
            // 
            this.ClientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameClient,
            this.Surname,
            this.Sex,
            this.PhoneNumber,
            this.VisitDate,
            this.ViewCar});
            this.ClientListView.FullRowSelect = true;
            this.ClientListView.GridLines = true;
            this.ClientListView.HideSelection = false;
            this.ClientListView.Location = new System.Drawing.Point(12, 34);
            this.ClientListView.Name = "ClientListView";
            this.ClientListView.Size = new System.Drawing.Size(776, 345);
            this.ClientListView.TabIndex = 18;
            this.ClientListView.UseCompatibleStateImageBehavior = false;
            this.ClientListView.View = System.Windows.Forms.View.Details;
            this.ClientListView.SelectedIndexChanged += new System.EventHandler(this.ClientListView_SelectedIndexChanged);
            // 
            // NameClient
            // 
            this.NameClient.Text = "Ім\'я";
            this.NameClient.Width = 96;
            // 
            // Surname
            // 
            this.Surname.Text = "Прізвище";
            this.Surname.Width = 114;
            // 
            // Sex
            // 
            this.Sex.Text = "Стать";
            this.Sex.Width = 86;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Номер телефона";
            this.PhoneNumber.Width = 149;
            // 
            // VisitDate
            // 
            this.VisitDate.Text = "Дата візиту";
            this.VisitDate.Width = 109;
            // 
            // ViewCar
            // 
            this.ViewCar.Text = "Бажане авто";
            this.ViewCar.Width = 141;
            // 
            // DetailInfoButton
            // 
            this.DetailInfoButton.Location = new System.Drawing.Point(533, 385);
            this.DetailInfoButton.Name = "DetailInfoButton";
            this.DetailInfoButton.Size = new System.Drawing.Size(255, 53);
            this.DetailInfoButton.TabIndex = 20;
            this.DetailInfoButton.Text = "Детальна інформація про авто";
            this.DetailInfoButton.UseVisualStyleBackColor = true;
            this.DetailInfoButton.Click += new System.EventHandler(this.DetailInfoButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 385);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(255, 53);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Видалити клієнта";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DetailInfoButton);
            this.Controls.Add(this.ClientListView);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListClientForm";
            this.Text = "ListClientForm";
            this.Load += new System.EventHandler(this.ListClientForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView ClientListView;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader VisitDate;
        private System.Windows.Forms.ColumnHeader ViewCar;
        private System.Windows.Forms.Button DetailInfoButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}