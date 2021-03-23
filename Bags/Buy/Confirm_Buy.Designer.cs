
namespace Bags
{
    partial class Confirm_Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_Buy));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buy_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_Money_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // Buy_btn
            // 
            this.Buy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_btn.Location = new System.Drawing.Point(356, 374);
            this.Buy_btn.Name = "Buy_btn";
            this.Buy_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Buy_btn.Size = new System.Drawing.Size(140, 64);
            this.Buy_btn.TabIndex = 1;
            this.Buy_btn.Text = "اتمام عملية الشراء";
            this.Buy_btn.UseVisualStyleBackColor = true;
            this.Buy_btn.Click += new System.EventHandler(this.Buy_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 312);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "الاجمالى:";
            // 
            // Total_Money_Label
            // 
            this.Total_Money_Label.AutoSize = true;
            this.Total_Money_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Money_Label.Location = new System.Drawing.Point(63, 312);
            this.Total_Money_Label.Name = "Total_Money_Label";
            this.Total_Money_Label.Size = new System.Drawing.Size(70, 25);
            this.Total_Money_Label.TabIndex = 3;
            this.Total_Money_Label.Text = "label2";
            // 
            // Confirm_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.Total_Money_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buy_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirm_Buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتمام عملية الشراء";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Buy_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total_Money_Label;
    }
}