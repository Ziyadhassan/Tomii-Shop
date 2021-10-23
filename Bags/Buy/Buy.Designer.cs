
namespace Bags
{
    partial class Buy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Item_tb = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Buy_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1040, 105);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "باركود المنتج:";
            // 
            // Item_tb
            // 
            this.Item_tb.Location = new System.Drawing.Point(776, 112);
            this.Item_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item_tb.Name = "Item_tb";
            this.Item_tb.Size = new System.Drawing.Size(257, 22);
            this.Item_tb.TabIndex = 1;
            this.Item_tb.TextChanged += new System.EventHandler(this.Item_tb_TextChanged);
            this.Item_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Item_tb_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 364);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1904, 591);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "الغاء شيء من السلة";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Buy_btn
            // 
            this.Buy_btn.Location = new System.Drawing.Point(1531, 89);
            this.Buy_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buy_btn.Name = "Buy_btn";
            this.Buy_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Buy_btn.Size = new System.Drawing.Size(173, 69);
            this.Buy_btn.TabIndex = 7;
            this.Buy_btn.Text = "اتمام عملية الشراء";
            this.Buy_btn.UseVisualStyleBackColor = true;
            this.Buy_btn.Click += new System.EventHandler(this.Buy_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1844, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Credit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(488, 102);
            this.Insert_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(155, 42);
            this.Insert_btn.TabIndex = 9;
            this.Insert_btn.Text = "ادخال";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buy_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Item_tb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Buy";
            this.Size = new System.Drawing.Size(1904, 955);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Item_tb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buy_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Insert_btn;
    }
}
