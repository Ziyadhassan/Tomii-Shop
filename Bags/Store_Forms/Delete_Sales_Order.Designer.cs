
namespace Bags.Store_Forms
{
    partial class Delete_Sales_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Sales_Order));
            this.Delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Order_Num_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Red;
            this.Delete_btn.Location = new System.Drawing.Point(127, 111);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(97, 44);
            this.Delete_btn.TabIndex = 5;
            this.Delete_btn.Text = "الغاء";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ادخل رقم الاوردر:";
            // 
            // Order_Num_tb
            // 
            this.Order_Num_tb.Location = new System.Drawing.Point(63, 59);
            this.Order_Num_tb.Name = "Order_Num_tb";
            this.Order_Num_tb.Size = new System.Drawing.Size(100, 22);
            this.Order_Num_tb.TabIndex = 3;
            // 
            // Delete_Sales_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 216);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_Num_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete_Sales_Order";
            this.Text = "الغاء عملية شراء";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Order_Num_tb;
    }
}