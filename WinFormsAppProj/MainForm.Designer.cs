
namespace WinFormsAppProj
{
    partial class MainForm
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
            this.ClientButtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вас вітає автосалон \"AutoTrading\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientButtn
            // 
            this.ClientButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientButtn.Location = new System.Drawing.Point(226, 186);
            this.ClientButtn.Name = "ClientButtn";
            this.ClientButtn.Size = new System.Drawing.Size(241, 59);
            this.ClientButtn.TabIndex = 3;
            this.ClientButtn.Text = "Підібрати авто";
            this.ClientButtn.UseVisualStyleBackColor = true;
            this.ClientButtn.Click += new System.EventHandler(this.ClientButtn_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(703, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автосалон, який підходить вам";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AdminLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminLabel.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AdminLabel.Location = new System.Drawing.Point(222, 258);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(247, 23);
            this.AdminLabel.TabIndex = 5;
            this.AdminLabel.Text = "Профіль адміністратора";
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CloseButtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 100);
            this.panel1.TabIndex = 6;
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
            this.CloseButtn.Location = new System.Drawing.Point(675, 3);
            this.CloseButtn.Name = "CloseButtn";
            this.CloseButtn.Size = new System.Drawing.Size(25, 25);
            this.CloseButtn.TabIndex = 9;
            this.CloseButtn.Text = "X";
            this.CloseButtn.UseVisualStyleBackColor = false;
            this.CloseButtn.Click += new System.EventHandler(this.CloseButtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsAppProj.Properties.Resources.depositphotos_19167731_stock_illustration_mavi_otomobil_logosu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 460);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.ClientButtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientButtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButtn;
    }
}