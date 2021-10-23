
namespace Bags.Installments
{
    partial class Pay_Installment_To_Factory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Installment_To_Factory));
            this.Pay_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Money_nUpDown = new System.Windows.Forms.NumericUpDown();
            this.Order_Id_nUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Money_nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Id_nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Pay_btn
            // 
            this.Pay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_btn.Location = new System.Drawing.Point(63, 50);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(121, 116);
            this.Pay_btn.TabIndex = 3;
            this.Pay_btn.Text = "دفع";
            this.Pay_btn.UseVisualStyleBackColor = true;
            this.Pay_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم المعاملة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "المبلغ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Money_nUpDown
            // 
            this.Money_nUpDown.DecimalPlaces = 2;
            this.Money_nUpDown.Location = new System.Drawing.Point(326, 122);
            this.Money_nUpDown.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Money_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Money_nUpDown.Name = "Money_nUpDown";
            this.Money_nUpDown.Size = new System.Drawing.Size(139, 22);
            this.Money_nUpDown.TabIndex = 2;
            this.Money_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Money_nUpDown.ValueChanged += new System.EventHandler(this.Money_nUpDown_ValueChanged);
            // 
            // Order_Id_nUpDown
            // 
            this.Order_Id_nUpDown.Location = new System.Drawing.Point(326, 70);
            this.Order_Id_nUpDown.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Order_Id_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Order_Id_nUpDown.Name = "Order_Id_nUpDown";
            this.Order_Id_nUpDown.Size = new System.Drawing.Size(139, 22);
            this.Order_Id_nUpDown.TabIndex = 1;
            this.Order_Id_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Order_Id_nUpDown.ValueChanged += new System.EventHandler(this.Order_Id_nUpDown_ValueChanged);
            // 
            // Pay_Installment_To_Factory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 227);
            this.Controls.Add(this.Order_Id_nUpDown);
            this.Controls.Add(this.Money_nUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pay_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pay_Installment_To_Factory";
            this.Text = "دفع دفعة جديدة";
            ((System.ComponentModel.ISupportInitialize)(this.Money_nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Id_nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pay_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Money_nUpDown;
        private System.Windows.Forms.NumericUpDown Order_Id_nUpDown;
    }
}