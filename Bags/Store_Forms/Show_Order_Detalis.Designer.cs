
namespace Bags.Store_Forms
{
    partial class Show_Order_Detalis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Order_Detalis));
            this.Order_Num_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Show_Details_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Order_Num_tb
            // 
            this.Order_Num_tb.Location = new System.Drawing.Point(76, 55);
            this.Order_Num_tb.Name = "Order_Num_tb";
            this.Order_Num_tb.Size = new System.Drawing.Size(100, 22);
            this.Order_Num_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 53);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل رقم الاوردر:";
            // 
            // Show_Details_btn
            // 
            this.Show_Details_btn.Location = new System.Drawing.Point(140, 107);
            this.Show_Details_btn.Name = "Show_Details_btn";
            this.Show_Details_btn.Size = new System.Drawing.Size(97, 44);
            this.Show_Details_btn.TabIndex = 2;
            this.Show_Details_btn.Text = "اظهار";
            this.Show_Details_btn.UseVisualStyleBackColor = true;
            this.Show_Details_btn.Click += new System.EventHandler(this.Show_Details_btn_Click);
            // 
            // Show_Order_Detalis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 203);
            this.Controls.Add(this.Show_Details_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_Num_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_Order_Detalis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الاوردر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Order_Num_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Show_Details_btn;
    }
}