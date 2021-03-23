
namespace Bags
{
    partial class Password_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.Enter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 156);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "كلمة المرور:";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(266, 163);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(219, 22);
            this.password_tb.TabIndex = 1;
            this.password_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tb_KeyDown);
            // 
            // Enter_btn
            // 
            this.Enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_btn.Location = new System.Drawing.Point(301, 273);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Enter_btn.Size = new System.Drawing.Size(184, 113);
            this.Enter_btn.TabIndex = 2;
            this.Enter_btn.Text = "الدخول";
            this.Enter_btn.UseVisualStyleBackColor = true;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enter_btn);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كلمة المرور";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button Enter_btn;
    }
}