
namespace Bags
{
    partial class Insert
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.Color_tb = new System.Windows.Forms.TextBox();
            this.Normal_Price = new System.Windows.Forms.NumericUpDown();
            this.WholePrice = new System.Windows.Forms.NumericUpDown();
            this.Qunitity = new System.Windows.Forms.NumericUpDown();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BarCode_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Seller_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Normal_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WholePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qunitity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(946, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المنتج:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(946, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "اللون:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(946, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "العدد:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(946, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "السعر القطاعي:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(946, 459);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "سعر الجملة:";
            // 
            // Name_tb
            // 
            this.Name_tb.Location = new System.Drawing.Point(730, 126);
            this.Name_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(198, 20);
            this.Name_tb.TabIndex = 2;
            this.Name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Color_tb
            // 
            this.Color_tb.Location = new System.Drawing.Point(730, 210);
            this.Color_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Color_tb.Name = "Color_tb";
            this.Color_tb.Size = new System.Drawing.Size(198, 20);
            this.Color_tb.TabIndex = 3;
            this.Color_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Normal_Price
            // 
            this.Normal_Price.DecimalPlaces = 2;
            this.Normal_Price.Location = new System.Drawing.Point(730, 378);
            this.Normal_Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Normal_Price.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Normal_Price.Name = "Normal_Price";
            this.Normal_Price.Size = new System.Drawing.Size(196, 20);
            this.Normal_Price.TabIndex = 5;
            // 
            // WholePrice
            // 
            this.WholePrice.DecimalPlaces = 2;
            this.WholePrice.Location = new System.Drawing.Point(730, 462);
            this.WholePrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WholePrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.WholePrice.Name = "WholePrice";
            this.WholePrice.Size = new System.Drawing.Size(196, 20);
            this.WholePrice.TabIndex = 6;
            // 
            // Qunitity
            // 
            this.Qunitity.Location = new System.Drawing.Point(730, 294);
            this.Qunitity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Qunitity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Qunitity.Name = "Qunitity";
            this.Qunitity.Size = new System.Drawing.Size(196, 20);
            this.Qunitity.TabIndex = 4;
            this.Qunitity.ThousandsSeparator = true;
            // 
            // Insert_btn
            // 
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(76, 249);
            this.Insert_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(263, 180);
            this.Insert_btn.TabIndex = 8;
            this.Insert_btn.Text = "ادخال";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label6.Location = new System.Drawing.Point(946, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "الباركود:";
            // 
            // BarCode_tb
            // 
            this.BarCode_tb.Location = new System.Drawing.Point(730, 43);
            this.BarCode_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarCode_tb.Name = "BarCode_tb";
            this.BarCode_tb.Size = new System.Drawing.Size(198, 20);
            this.BarCode_tb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(946, 543);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "اسم التاجر:";
            // 
            // Seller_tb
            // 
            this.Seller_tb.Location = new System.Drawing.Point(730, 548);
            this.Seller_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Seller_tb.Name = "Seller_tb";
            this.Seller_tb.Size = new System.Drawing.Size(198, 20);
            this.Seller_tb.TabIndex = 7;
            this.Seller_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BarCode_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.WholePrice);
            this.Controls.Add(this.Qunitity);
            this.Controls.Add(this.Normal_Price);
            this.Controls.Add(this.Color_tb);
            this.Controls.Add(this.Seller_tb);
            this.Controls.Add(this.Name_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Insert";
            this.Size = new System.Drawing.Size(1246, 776);
            ((System.ComponentModel.ISupportInitialize)(this.Normal_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WholePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qunitity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.TextBox Color_tb;
        private System.Windows.Forms.NumericUpDown Normal_Price;
        private System.Windows.Forms.NumericUpDown WholePrice;
        private System.Windows.Forms.NumericUpDown Qunitity;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BarCode_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Seller_tb;
    }
}
