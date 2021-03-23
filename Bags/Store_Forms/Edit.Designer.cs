
namespace Bags.Insert_and_Edit
{
    partial class Edit
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
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Show_All_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.BarCode_Search_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(920, 156);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "الموديل:";
            // 
            // Search_tb
            // 
            this.Search_tb.Location = new System.Drawing.Point(671, 166);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(229, 22);
            this.Search_tb.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Show_All_btn);
            this.panel1.Controls.Add(this.Search_btn);
            this.panel1.Controls.Add(this.BarCode_Search_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 231);
            this.panel1.TabIndex = 3;
            // 
            // Show_All_btn
            // 
            this.Show_All_btn.Location = new System.Drawing.Point(36, 74);
            this.Show_All_btn.Name = "Show_All_btn";
            this.Show_All_btn.Size = new System.Drawing.Size(209, 114);
            this.Show_All_btn.TabIndex = 4;
            this.Show_All_btn.Text = "اظهار الكل";
            this.Show_All_btn.UseVisualStyleBackColor = true;
            this.Show_All_btn.Click += new System.EventHandler(this.Show_All_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(527, 156);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(93, 43);
            this.Search_btn.TabIndex = 3;
            this.Search_btn.Text = "بحث";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // BarCode_Search_tb
            // 
            this.BarCode_Search_tb.Location = new System.Drawing.Point(671, 103);
            this.BarCode_Search_tb.Name = "BarCode_Search_tb";
            this.BarCode_Search_tb.Size = new System.Drawing.Size(229, 22);
            this.BarCode_Search_tb.TabIndex = 2;
            this.BarCode_Search_tb.TextChanged += new System.EventHandler(this.BarCode_Search_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(920, 93);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "الباركود:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 231);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1662, 724);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "بحث بالباركود";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Edit";
            this.Size = new System.Drawing.Size(1662, 955);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Show_All_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox BarCode_Search_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
