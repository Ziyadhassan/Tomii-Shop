
namespace Bags
{
    partial class Buy_Item_Model
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chosen_Quntity_nUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Whole_Chosen = new System.Windows.Forms.RadioButton();
            this.Normal_Chosen = new System.Windows.Forms.RadioButton();
            this.Money_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Color_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Model_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TotalPrice_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Index_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chosen_Quntity_nUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Chosen_Quntity_nUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(164, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 152);
            this.panel1.TabIndex = 0;
            // 
            // Chosen_Quntity_nUpDown
            // 
            this.Chosen_Quntity_nUpDown.Location = new System.Drawing.Point(25, 50);
            this.Chosen_Quntity_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Chosen_Quntity_nUpDown.Name = "Chosen_Quntity_nUpDown";
            this.Chosen_Quntity_nUpDown.Size = new System.Drawing.Size(141, 34);
            this.Chosen_Quntity_nUpDown.TabIndex = 1;
            this.Chosen_Quntity_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Chosen_Quntity_nUpDown.ValueChanged += new System.EventHandler(this.Chosen_Quntity_nUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "العدد:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Whole_Chosen);
            this.panel2.Controls.Add(this.Normal_Chosen);
            this.panel2.Controls.Add(this.Money_label);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(406, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 152);
            this.panel2.TabIndex = 1;
            // 
            // Whole_Chosen
            // 
            this.Whole_Chosen.AutoSize = true;
            this.Whole_Chosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Whole_Chosen.Location = new System.Drawing.Point(156, 88);
            this.Whole_Chosen.Name = "Whole_Chosen";
            this.Whole_Chosen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Whole_Chosen.Size = new System.Drawing.Size(64, 29);
            this.Whole_Chosen.TabIndex = 2;
            this.Whole_Chosen.TabStop = true;
            this.Whole_Chosen.Text = "جملة";
            this.Whole_Chosen.UseVisualStyleBackColor = true;
            this.Whole_Chosen.CheckedChanged += new System.EventHandler(this.Whole_Chosen_CheckedChanged);
            // 
            // Normal_Chosen
            // 
            this.Normal_Chosen.AutoSize = true;
            this.Normal_Chosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal_Chosen.Location = new System.Drawing.Point(142, 53);
            this.Normal_Chosen.Name = "Normal_Chosen";
            this.Normal_Chosen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Normal_Chosen.Size = new System.Drawing.Size(78, 29);
            this.Normal_Chosen.TabIndex = 2;
            this.Normal_Chosen.TabStop = true;
            this.Normal_Chosen.Text = "قطاعي";
            this.Normal_Chosen.UseVisualStyleBackColor = true;
            this.Normal_Chosen.CheckedChanged += new System.EventHandler(this.Normal_Chosen_CheckedChanged);
            // 
            // Money_label
            // 
            this.Money_label.AutoSize = true;
            this.Money_label.Location = new System.Drawing.Point(30, 9);
            this.Money_label.Name = "Money_label";
            this.Money_label.Size = new System.Drawing.Size(85, 29);
            this.Money_label.TabIndex = 1;
            this.Money_label.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "سعر الحبة:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Color_Label);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(668, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 152);
            this.panel3.TabIndex = 2;
            // 
            // Color_Label
            // 
            this.Color_Label.AutoSize = true;
            this.Color_Label.Location = new System.Drawing.Point(67, 52);
            this.Color_Label.Name = "Color_Label";
            this.Color_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Color_Label.Size = new System.Drawing.Size(79, 29);
            this.Color_Label.TabIndex = 1;
            this.Color_Label.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(57, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "اللون:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Model_Label);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(871, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 152);
            this.panel4.TabIndex = 3;
            // 
            // Model_Label
            // 
            this.Model_Label.AutoSize = true;
            this.Model_Label.Location = new System.Drawing.Point(83, 55);
            this.Model_Label.Name = "Model_Label";
            this.Model_Label.Size = new System.Drawing.Size(79, 29);
            this.Model_Label.TabIndex = 1;
            this.Model_Label.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "الموديل:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.TotalPrice_Label);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 152);
            this.panel5.TabIndex = 4;
            // 
            // TotalPrice_Label
            // 
            this.TotalPrice_Label.AutoSize = true;
            this.TotalPrice_Label.Location = new System.Drawing.Point(41, 73);
            this.TotalPrice_Label.Name = "TotalPrice_Label";
            this.TotalPrice_Label.Size = new System.Drawing.Size(79, 29);
            this.TotalPrice_Label.TabIndex = 1;
            this.TotalPrice_Label.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 18);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "الأجمالي:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Index_Label);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(1108, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 152);
            this.panel6.TabIndex = 5;
            // 
            // Index_Label
            // 
            this.Index_Label.AutoSize = true;
            this.Index_Label.Location = new System.Drawing.Point(83, 55);
            this.Index_Label.Name = "Index_Label";
            this.Index_Label.Size = new System.Drawing.Size(71, 29);
            this.Index_Label.TabIndex = 1;
            this.Index_Label.Text = "Index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 9);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(55, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "الرقم:";
            // 
            // Buy_Item_Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Buy_Item_Model";
            this.Size = new System.Drawing.Size(1345, 161);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chosen_Quntity_nUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Chosen_Quntity_nUpDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Money_label;
        private System.Windows.Forms.RadioButton Whole_Chosen;
        private System.Windows.Forms.RadioButton Normal_Chosen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Color_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Model_Label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label TotalPrice_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Index_Label;
        private System.Windows.Forms.Label label7;
    }
}
