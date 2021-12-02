
namespace WinFormsAppProj
{
    partial class CarList
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
            this.CloseButtn = new System.Windows.Forms.Button();
            this.CarListView = new System.Windows.Forms.ListView();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProdYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeEngine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PowerEngine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VolumeEngine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterButton = new System.Windows.Forms.Button();
            this.SelectButtn = new System.Windows.Forms.Button();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Silver;
            this.TopBorder.Controls.Add(this.CloseButtn);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(800, 28);
            this.TopBorder.TabIndex = 16;
            this.TopBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.TopBorder_Paint);
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            // 
            // CloseButtn
            // 
            this.CloseButtn.BackColor = System.Drawing.Color.Red;
            this.CloseButtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButtn.FlatAppearance.BorderSize = 0;
            this.CloseButtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseButtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButtn.Location = new System.Drawing.Point(772, 3);
            this.CloseButtn.Name = "CloseButtn";
            this.CloseButtn.Size = new System.Drawing.Size(25, 25);
            this.CloseButtn.TabIndex = 10;
            this.CloseButtn.Text = "X";
            this.CloseButtn.UseVisualStyleBackColor = false;
            this.CloseButtn.Click += new System.EventHandler(this.CloseButtn_Click);
            // 
            // CarListView
            // 
            this.CarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brand,
            this.Model,
            this.ProdYear,
            this.Price,
            this.TypeEngine,
            this.PowerEngine,
            this.VolumeEngine});
            this.CarListView.FullRowSelect = true;
            this.CarListView.GridLines = true;
            this.CarListView.HideSelection = false;
            this.CarListView.Location = new System.Drawing.Point(0, 34);
            this.CarListView.Name = "CarListView";
            this.CarListView.Size = new System.Drawing.Size(797, 362);
            this.CarListView.TabIndex = 11;
            this.CarListView.UseCompatibleStateImageBehavior = false;
            this.CarListView.View = System.Windows.Forms.View.Details;
            this.CarListView.SelectedIndexChanged += new System.EventHandler(this.CarListView_SelectedIndexChanged);
            // 
            // Brand
            // 
            this.Brand.Text = "Бренд";
            this.Brand.Width = 82;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 89;
            // 
            // ProdYear
            // 
            this.ProdYear.Text = "Рік виготовлення";
            this.ProdYear.Width = 134;
            // 
            // Price
            // 
            this.Price.Text = "Ціна";
            this.Price.Width = 108;
            // 
            // TypeEngine
            // 
            this.TypeEngine.Text = "Тип двигуна";
            this.TypeEngine.Width = 110;
            // 
            // PowerEngine
            // 
            this.PowerEngine.Text = "Потужність";
            this.PowerEngine.Width = 93;
            // 
            // VolumeEngine
            // 
            this.VolumeEngine.Text = "Об\'єм двигуна";
            this.VolumeEngine.Width = 115;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(0, 402);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(211, 36);
            this.FilterButton.TabIndex = 17;
            this.FilterButton.Text = "Сортування по ціні";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SelectButtn
            // 
            this.SelectButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectButtn.Location = new System.Drawing.Point(553, 402);
            this.SelectButtn.Name = "SelectButtn";
            this.SelectButtn.Size = new System.Drawing.Size(211, 36);
            this.SelectButtn.TabIndex = 18;
            this.SelectButtn.Text = "Вибір авто";
            this.SelectButtn.UseVisualStyleBackColor = true;
            this.SelectButtn.Click += new System.EventHandler(this.SelectButtn_Click);
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectButtn);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.CarListView);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarList";
            this.Text = "CarList";
            this.Load += new System.EventHandler(this.CarList_Load);
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButtn;
        private System.Windows.Forms.ListView CarListView;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader ProdYear;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader TypeEngine;
        private System.Windows.Forms.ColumnHeader PowerEngine;
        private System.Windows.Forms.ColumnHeader VolumeEngine;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SelectButtn;
    }
}