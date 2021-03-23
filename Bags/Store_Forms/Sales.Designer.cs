
namespace Bags
{
    partial class Sales
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
            this.To_Date = new System.Windows.Forms.DateTimePicker();
            this.From_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Show_With_ID_btn = new System.Windows.Forms.Button();
            this.Delete_Order_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // To_Date
            // 
            this.To_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_Date.Location = new System.Drawing.Point(453, 80);
            this.To_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.To_Date.Name = "To_Date";
            this.To_Date.Size = new System.Drawing.Size(200, 22);
            this.To_Date.TabIndex = 0;
            // 
            // From_Date
            // 
            this.From_Date.CustomFormat = "";
            this.From_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_Date.Location = new System.Drawing.Point(929, 80);
            this.From_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.From_Date.Name = "From_Date";
            this.From_Date.Size = new System.Drawing.Size(200, 22);
            this.From_Date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1155, 78);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "من:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "الى:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 417);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1661, 538);
            this.dataGridView1.TabIndex = 2;
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(785, 158);
            this.Show_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(111, 63);
            this.Show_btn.TabIndex = 3;
            this.Show_btn.Text = "اظهار";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Show_With_ID_btn
            // 
            this.Show_With_ID_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_With_ID_btn.Location = new System.Drawing.Point(67, 78);
            this.Show_With_ID_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show_With_ID_btn.Name = "Show_With_ID_btn";
            this.Show_With_ID_btn.Size = new System.Drawing.Size(171, 81);
            this.Show_With_ID_btn.TabIndex = 3;
            this.Show_With_ID_btn.Text = "اظهار التفاصيل بالرقم";
            this.Show_With_ID_btn.UseVisualStyleBackColor = true;
            this.Show_With_ID_btn.Click += new System.EventHandler(this.Show_With_ID_btn_Click);
            // 
            // Delete_Order_btn
            // 
            this.Delete_Order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Order_btn.Location = new System.Drawing.Point(1294, 62);
            this.Delete_Order_btn.Name = "Delete_Order_btn";
            this.Delete_Order_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Delete_Order_btn.Size = new System.Drawing.Size(164, 97);
            this.Delete_Order_btn.TabIndex = 4;
            this.Delete_Order_btn.Text = "الغاء عملية شراء";
            this.Delete_Order_btn.UseVisualStyleBackColor = true;
            this.Delete_Order_btn.Click += new System.EventHandler(this.Delete_Order_btn_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_Order_btn);
            this.Controls.Add(this.Show_With_ID_btn);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From_Date);
            this.Controls.Add(this.To_Date);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sales";
            this.Size = new System.Drawing.Size(1661, 955);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker To_Date;
        private System.Windows.Forms.DateTimePicker From_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.Button Show_With_ID_btn;
        private System.Windows.Forms.Button Delete_Order_btn;
    }
}
