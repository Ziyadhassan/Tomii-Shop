
namespace Bags.Insert_and_Edit
{
    partial class Delete_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Form));
            this.yes_Delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yes_Delete_btn
            // 
            this.yes_Delete_btn.BackColor = System.Drawing.Color.Red;
            this.yes_Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_Delete_btn.Location = new System.Drawing.Point(253, 196);
            this.yes_Delete_btn.Name = "yes_Delete_btn";
            this.yes_Delete_btn.Size = new System.Drawing.Size(112, 41);
            this.yes_Delete_btn.TabIndex = 0;
            this.yes_Delete_btn.Text = "نعم ألغاء";
            this.yes_Delete_btn.UseVisualStyleBackColor = false;
            this.yes_Delete_btn.Click += new System.EventHandler(this.yes_Delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "هل انت متاكد بالغاء هذه المنتج؟";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "لا";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yes_Delete_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الغاء منتج من المخزن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes_Delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}