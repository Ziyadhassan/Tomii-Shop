
namespace Bags
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Out_In_Order_btn = new System.Windows.Forms.Button();
            this.Store_btn = new System.Windows.Forms.Button();
            this.Buy_btn = new System.Windows.Forms.Button();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Order_Installments_Panel = new Bags.Installments.Order_Installments();
            this.Full_Store_Panel = new Bags.Full_Store();
            this.Buy_Panel = new Bags.Buy();
            this.Top_Panel.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Top_Panel.Controls.Add(this.Out_In_Order_btn);
            this.Top_Panel.Controls.Add(this.Store_btn);
            this.Top_Panel.Controls.Add(this.Buy_btn);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(1712, 100);
            this.Top_Panel.TabIndex = 0;
            // 
            // Out_In_Order_btn
            // 
            this.Out_In_Order_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Out_In_Order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out_In_Order_btn.Location = new System.Drawing.Point(1133, 12);
            this.Out_In_Order_btn.Name = "Out_In_Order_btn";
            this.Out_In_Order_btn.Size = new System.Drawing.Size(579, 82);
            this.Out_In_Order_btn.TabIndex = 0;
            this.Out_In_Order_btn.Text = "خارج و وارد";
            this.Out_In_Order_btn.UseVisualStyleBackColor = true;
            this.Out_In_Order_btn.Click += new System.EventHandler(this.Out_In_Order_btn_Click);
            // 
            // Store_btn
            // 
            this.Store_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Store_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Store_btn.Location = new System.Drawing.Point(486, 12);
            this.Store_btn.Name = "Store_btn";
            this.Store_btn.Size = new System.Drawing.Size(624, 82);
            this.Store_btn.TabIndex = 0;
            this.Store_btn.Text = "المخزن";
            this.Store_btn.UseVisualStyleBackColor = true;
            this.Store_btn.Click += new System.EventHandler(this.Store_btn_Click);
            // 
            // Buy_btn
            // 
            this.Buy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_btn.Location = new System.Drawing.Point(3, 12);
            this.Buy_btn.Name = "Buy_btn";
            this.Buy_btn.Size = new System.Drawing.Size(580, 82);
            this.Buy_btn.TabIndex = 0;
            this.Buy_btn.Text = "عملية شراء";
            this.Buy_btn.UseVisualStyleBackColor = true;
            this.Buy_btn.Click += new System.EventHandler(this.Buy_btn_Click);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.Order_Installments_Panel);
            this.Main_Panel.Controls.Add(this.Full_Store_Panel);
            this.Main_Panel.Controls.Add(this.Buy_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 100);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1712, 835);
            this.Main_Panel.TabIndex = 1;
            // 
            // Order_Installments_Panel
            // 
            this.Order_Installments_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order_Installments_Panel.Location = new System.Drawing.Point(0, 0);
            this.Order_Installments_Panel.Name = "Order_Installments_Panel";
            this.Order_Installments_Panel.Size = new System.Drawing.Size(1712, 835);
            this.Order_Installments_Panel.TabIndex = 4;
            // 
            // Full_Store_Panel
            // 
            this.Full_Store_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Full_Store_Panel.Location = new System.Drawing.Point(0, 0);
            this.Full_Store_Panel.Name = "Full_Store_Panel";
            this.Full_Store_Panel.Size = new System.Drawing.Size(1712, 835);
            this.Full_Store_Panel.TabIndex = 3;
            // 
            // Buy_Panel
            // 
            this.Buy_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buy_Panel.Location = new System.Drawing.Point(0, 0);
            this.Buy_Panel.Name = "Buy_Panel";
            this.Buy_Panel.Size = new System.Drawing.Size(1712, 835);
            this.Buy_Panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 935);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Top_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Top_Panel.ResumeLayout(false);
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Button Store_btn;
        private System.Windows.Forms.Button Buy_btn;
        private System.Windows.Forms.Panel Main_Panel;
        private Buy Buy_Panel;
        private Full_Store Full_Store_Panel;
        private System.Windows.Forms.Button Out_In_Order_btn;
        private Installments.Order_Installments Order_Installments_Panel;
    }
}

