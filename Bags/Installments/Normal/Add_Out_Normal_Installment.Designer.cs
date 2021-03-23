
namespace Bags.Installments.Normal
{
    partial class Add_Out_Normal_Installment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Out_Normal_Installment));
            this.Add_btn = new System.Windows.Forms.Button();
            this.Model_tb = new System.Windows.Forms.TextBox();
            this.BarCode_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Installment_nUpDown = new System.Windows.Forms.NumericUpDown();
            this.Price_nUpDown = new System.Windows.Forms.NumericUpDown();
            this.Quantity_nUpDown = new System.Windows.Forms.NumericUpDown();
            this.Colors_tb = new System.Windows.Forms.TextBox();
            this.Factory_Name_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Installment_nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(85, 201);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(188, 162);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "اضافة الشغل";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Model_tb
            // 
            this.Model_tb.Location = new System.Drawing.Point(449, 206);
            this.Model_tb.Name = "Model_tb";
            this.Model_tb.Size = new System.Drawing.Size(176, 22);
            this.Model_tb.TabIndex = 3;
            // 
            // BarCode_tb
            // 
            this.BarCode_tb.Location = new System.Drawing.Point(449, 132);
            this.BarCode_tb.Name = "BarCode_tb";
            this.BarCode_tb.Size = new System.Drawing.Size(176, 22);
            this.BarCode_tb.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label7.Location = new System.Drawing.Point(646, 203);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "الموديل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label6.Location = new System.Drawing.Point(646, 129);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "الباركود:";
            // 
            // Installment_nUpDown
            // 
            this.Installment_nUpDown.DecimalPlaces = 2;
            this.Installment_nUpDown.Location = new System.Drawing.Point(449, 506);
            this.Installment_nUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Installment_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Installment_nUpDown.Name = "Installment_nUpDown";
            this.Installment_nUpDown.Size = new System.Drawing.Size(176, 22);
            this.Installment_nUpDown.TabIndex = 7;
            this.Installment_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Price_nUpDown
            // 
            this.Price_nUpDown.DecimalPlaces = 2;
            this.Price_nUpDown.Location = new System.Drawing.Point(449, 429);
            this.Price_nUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Price_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Price_nUpDown.Name = "Price_nUpDown";
            this.Price_nUpDown.Size = new System.Drawing.Size(176, 22);
            this.Price_nUpDown.TabIndex = 6;
            this.Price_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Quantity_nUpDown
            // 
            this.Quantity_nUpDown.Location = new System.Drawing.Point(449, 272);
            this.Quantity_nUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Quantity_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity_nUpDown.Name = "Quantity_nUpDown";
            this.Quantity_nUpDown.Size = new System.Drawing.Size(176, 22);
            this.Quantity_nUpDown.TabIndex = 4;
            this.Quantity_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Colors_tb
            // 
            this.Colors_tb.Location = new System.Drawing.Point(449, 347);
            this.Colors_tb.Name = "Colors_tb";
            this.Colors_tb.Size = new System.Drawing.Size(176, 22);
            this.Colors_tb.TabIndex = 5;
            // 
            // Factory_Name_tb
            // 
            this.Factory_Name_tb.Location = new System.Drawing.Point(449, 57);
            this.Factory_Name_tb.Name = "Factory_Name_tb";
            this.Factory_Name_tb.Size = new System.Drawing.Size(176, 22);
            this.Factory_Name_tb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(646, 499);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "دفعة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(646, 425);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "السعر:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 351);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "الوان:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 277);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "العدد:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(646, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "اسم المصنع:";
            // 
            // Add_Out_Normal_Installment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 609);
            this.Controls.Add(this.Model_tb);
            this.Controls.Add(this.BarCode_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Installment_nUpDown);
            this.Controls.Add(this.Price_nUpDown);
            this.Controls.Add(this.Quantity_nUpDown);
            this.Controls.Add(this.Colors_tb);
            this.Controls.Add(this.Factory_Name_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Out_Normal_Installment";
            this.Text = "اضافة شغل خارج قطاعي";
            ((System.ComponentModel.ISupportInitialize)(this.Installment_nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox Model_tb;
        private System.Windows.Forms.TextBox BarCode_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Installment_nUpDown;
        private System.Windows.Forms.NumericUpDown Price_nUpDown;
        private System.Windows.Forms.NumericUpDown Quantity_nUpDown;
        private System.Windows.Forms.TextBox Colors_tb;
        private System.Windows.Forms.TextBox Factory_Name_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}