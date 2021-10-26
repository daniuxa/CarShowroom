
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ClientButtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вас вітає автосалон \"AutoTrading\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientButtn
            // 
            this.ClientButtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientButtn.Location = new System.Drawing.Point(246, 145);
            this.ClientButtn.Name = "ClientButtn";
            this.ClientButtn.Size = new System.Drawing.Size(241, 59);
            this.ClientButtn.TabIndex = 3;
            this.ClientButtn.Text = "Підібрати авто";
            this.ClientButtn.UseVisualStyleBackColor = true;
            this.ClientButtn.Click += new System.EventHandler(this.ClientButtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(192, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автосалон, який підходить вам";
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AdminLabel.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AdminLabel.Location = new System.Drawing.Point(242, 221);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(247, 23);
            this.AdminLabel.TabIndex = 5;
            this.AdminLabel.Text = "Профіль адміністратора";
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 460);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientButtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientButtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdminLabel;
    }
}