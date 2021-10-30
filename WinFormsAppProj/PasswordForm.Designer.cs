
namespace WinFormsAppProj
{
    partial class PasswordForm
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
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.OkButtn = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть пароль:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Location = new System.Drawing.Point(188, 57);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(125, 22);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyUp);
            // 
            // OkButtn
            // 
            this.OkButtn.Location = new System.Drawing.Point(337, 57);
            this.OkButtn.Name = "OkButtn";
            this.OkButtn.Size = new System.Drawing.Size(75, 23);
            this.OkButtn.TabIndex = 2;
            this.OkButtn.Text = "Ok";
            this.OkButtn.UseVisualStyleBackColor = true;
            this.OkButtn.Click += new System.EventHandler(this.OkButtn_Click);
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
            this.CloseButton.Location = new System.Drawing.Point(438, -3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 162);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordForm";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasswordForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PasswordForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PasswordForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button OkButtn;
        private System.Windows.Forms.Button CloseButton;
    }
}