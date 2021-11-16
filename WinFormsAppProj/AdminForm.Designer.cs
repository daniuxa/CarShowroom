
namespace WinFormsAppProj
{
    partial class AdminForm
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
            this.WorkersButtn = new System.Windows.Forms.Button();
            this.CustomersButtn = new System.Windows.Forms.Button();
            this.CarsButtn = new System.Windows.Forms.Button();
            this.StatButtn = new System.Windows.Forms.Button();
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
            this.TopBorder.TabIndex = 8;
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
            this.CloseButtn.TabIndex = 9;
            this.CloseButtn.Text = "X";
            this.CloseButtn.UseVisualStyleBackColor = false;
            this.CloseButtn.Click += new System.EventHandler(this.CloseButtn_Click);
            // 
            // WorkersButtn
            // 
            this.WorkersButtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkersButtn.Location = new System.Drawing.Point(34, 84);
            this.WorkersButtn.Name = "WorkersButtn";
            this.WorkersButtn.Size = new System.Drawing.Size(170, 57);
            this.WorkersButtn.TabIndex = 9;
            this.WorkersButtn.Text = "Працівники";
            this.WorkersButtn.UseVisualStyleBackColor = true;
            this.WorkersButtn.Click += new System.EventHandler(this.WorkersButtn_Click);
            // 
            // CustomersButtn
            // 
            this.CustomersButtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersButtn.Location = new System.Drawing.Point(34, 325);
            this.CustomersButtn.Name = "CustomersButtn";
            this.CustomersButtn.Size = new System.Drawing.Size(170, 57);
            this.CustomersButtn.TabIndex = 10;
            this.CustomersButtn.Text = "Покупці";
            this.CustomersButtn.UseVisualStyleBackColor = true;
            // 
            // CarsButtn
            // 
            this.CarsButtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsButtn.Location = new System.Drawing.Point(591, 84);
            this.CarsButtn.Name = "CarsButtn";
            this.CarsButtn.Size = new System.Drawing.Size(170, 57);
            this.CarsButtn.TabIndex = 11;
            this.CarsButtn.Text = "Автомобілі";
            this.CarsButtn.UseVisualStyleBackColor = true;
            this.CarsButtn.Click += new System.EventHandler(this.CarsButtn_Click);
            // 
            // StatButtn
            // 
            this.StatButtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatButtn.Location = new System.Drawing.Point(591, 325);
            this.StatButtn.Name = "StatButtn";
            this.StatButtn.Size = new System.Drawing.Size(170, 57);
            this.StatButtn.TabIndex = 12;
            this.StatButtn.Text = "Статистика";
            this.StatButtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatButtn);
            this.Controls.Add(this.CarsButtn);
            this.Controls.Add(this.CustomersButtn);
            this.Controls.Add(this.WorkersButtn);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButtn;
        private System.Windows.Forms.Button WorkersButtn;
        private System.Windows.Forms.Button CustomersButtn;
        private System.Windows.Forms.Button CarsButtn;
        private System.Windows.Forms.Button StatButtn;
    }
}