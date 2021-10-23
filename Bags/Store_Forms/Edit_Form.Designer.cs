
namespace Bags.Insert_and_Edit
{
    partial class Edit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quntity_nb = new System.Windows.Forms.NumericUpDown();
            this.Normal_price_nb = new System.Windows.Forms.NumericUpDown();
            this.Whole_price_nb = new System.Windows.Forms.NumericUpDown();
            this.Update_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Seller_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quntity_nb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal_price_nb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whole_price_nb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "العدد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "السعر القطاعي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(667, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "سعر الجملة";
            // 
            // quntity_nb
            // 
            this.quntity_nb.Location = new System.Drawing.Point(412, 67);
            this.quntity_nb.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.quntity_nb.Name = "quntity_nb";
            this.quntity_nb.Size = new System.Drawing.Size(196, 22);
            this.quntity_nb.TabIndex = 1;
            // 
            // Normal_price_nb
            // 
            this.Normal_price_nb.DecimalPlaces = 2;
            this.Normal_price_nb.Location = new System.Drawing.Point(412, 148);
            this.Normal_price_nb.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Normal_price_nb.Name = "Normal_price_nb";
            this.Normal_price_nb.Size = new System.Drawing.Size(196, 22);
            this.Normal_price_nb.TabIndex = 2;
            // 
            // Whole_price_nb
            // 
            this.Whole_price_nb.DecimalPlaces = 2;
            this.Whole_price_nb.Location = new System.Drawing.Point(412, 227);
            this.Whole_price_nb.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Whole_price_nb.Name = "Whole_price_nb";
            this.Whole_price_nb.Size = new System.Drawing.Size(196, 22);
            this.Whole_price_nb.TabIndex = 3;
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(277, 335);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(182, 79);
            this.Update_btn.TabIndex = 2;
            this.Update_btn.Text = "تعديل";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "التاجر";
            // 
            // Seller_tb
            // 
            this.Seller_tb.Location = new System.Drawing.Point(49, 66);
            this.Seller_tb.Name = "Seller_tb";
            this.Seller_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Seller_tb.Size = new System.Drawing.Size(159, 22);
            this.Seller_tb.TabIndex = 4;
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Seller_tb);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Whole_price_nb);
            this.Controls.Add(this.Normal_price_nb);
            this.Controls.Add(this.quntity_nb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل البيانات منتج";
            ((System.ComponentModel.ISupportInitialize)(this.quntity_nb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal_price_nb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whole_price_nb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown quntity_nb;
        private System.Windows.Forms.NumericUpDown Normal_price_nb;
        private System.Windows.Forms.NumericUpDown Whole_price_nb;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Seller_tb;
    }
}