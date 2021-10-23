
namespace Bags
{
    partial class Store
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
            this.Search_text_Field = new System.Windows.Forms.TextBox();
            this.Search_All_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_Bar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(841, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الباركود:";
            // 
            // Search_text_Field
            // 
            this.Search_text_Field.Location = new System.Drawing.Point(557, 28);
            this.Search_text_Field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_text_Field.Name = "Search_text_Field";
            this.Search_text_Field.Size = new System.Drawing.Size(265, 20);
            this.Search_text_Field.TabIndex = 1;
            this.Search_text_Field.TextChanged += new System.EventHandler(this.Search_text_Field_TextChanged);
            // 
            // Search_All_btn
            // 
            this.Search_All_btn.Location = new System.Drawing.Point(229, 63);
            this.Search_All_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_All_btn.Name = "Search_All_btn";
            this.Search_All_btn.Size = new System.Drawing.Size(122, 59);
            this.Search_All_btn.TabIndex = 2;
            this.Search_All_btn.Text = "اظهار الكل";
            this.Search_All_btn.UseVisualStyleBackColor = true;
            this.Search_All_btn.Click += new System.EventHandler(this.Search_All_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 345);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1246, 431);
            this.dataGridView1.TabIndex = 3;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(460, 83);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(70, 35);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "بحث";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Search_tb
            // 
            this.Search_tb.Location = new System.Drawing.Point(557, 91);
            this.Search_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(260, 20);
            this.Search_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "الموديل:";
            // 
            // Search_Bar_btn
            // 
            this.Search_Bar_btn.Location = new System.Drawing.Point(460, 20);
            this.Search_Bar_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_Bar_btn.Name = "Search_Bar_btn";
            this.Search_Bar_btn.Size = new System.Drawing.Size(70, 35);
            this.Search_Bar_btn.TabIndex = 7;
            this.Search_Bar_btn.Text = "بحث بالباركود";
            this.Search_Bar_btn.UseVisualStyleBackColor = true;
            this.Search_Bar_btn.Click += new System.EventHandler(this.Search_Bar_btn_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Search_Bar_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_All_btn);
            this.Controls.Add(this.Search_text_Field);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Store";
            this.Size = new System.Drawing.Size(1246, 776);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_text_Field;
        private System.Windows.Forms.Button Search_All_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search_Bar_btn;
    }
}
