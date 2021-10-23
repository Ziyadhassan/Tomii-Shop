
namespace Bags.Installments
{
    partial class Order_Installments
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
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Order_Out_Normal = new System.Windows.Forms.Button();
            this.Order_Out_Whole = new System.Windows.Forms.Button();
            this.Order_In_btn = new System.Windows.Forms.Button();
            this.Right_Panel = new System.Windows.Forms.Panel();
            this.orders_Out_Normal_Installment1 = new Bags.Installments.Normal.Orders_Out_Normal_Installment();
            this.orders_Out_Whole_Installments1 = new Bags.Installments.Factory.Orders_Out_Whole_Installments();
            this.order_From_Factory_Installments1 = new Bags.Installments.Order_From_Factory_Installments();
            this.Left_Panel.SuspendLayout();
            this.Right_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.Controls.Add(this.Order_Out_Normal);
            this.Left_Panel.Controls.Add(this.Order_Out_Whole);
            this.Left_Panel.Controls.Add(this.Order_In_btn);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(181, 776);
            this.Left_Panel.TabIndex = 0;
            // 
            // Order_Out_Normal
            // 
            this.Order_Out_Normal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Order_Out_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Out_Normal.Location = new System.Drawing.Point(0, 442);
            this.Order_Out_Normal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Order_Out_Normal.Name = "Order_Out_Normal";
            this.Order_Out_Normal.Size = new System.Drawing.Size(181, 221);
            this.Order_Out_Normal.TabIndex = 3;
            this.Order_Out_Normal.Text = "شغل خارج قطاعي";
            this.Order_Out_Normal.UseVisualStyleBackColor = true;
            this.Order_Out_Normal.Click += new System.EventHandler(this.Order_Out_Normal_Click);
            // 
            // Order_Out_Whole
            // 
            this.Order_Out_Whole.Dock = System.Windows.Forms.DockStyle.Top;
            this.Order_Out_Whole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Out_Whole.Location = new System.Drawing.Point(0, 221);
            this.Order_Out_Whole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Order_Out_Whole.Name = "Order_Out_Whole";
            this.Order_Out_Whole.Size = new System.Drawing.Size(181, 221);
            this.Order_Out_Whole.TabIndex = 2;
            this.Order_Out_Whole.Text = "شغل خارج جملة";
            this.Order_Out_Whole.UseVisualStyleBackColor = true;
            this.Order_Out_Whole.Click += new System.EventHandler(this.Order_Out_Whole_Click);
            // 
            // Order_In_btn
            // 
            this.Order_In_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Order_In_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_In_btn.Location = new System.Drawing.Point(0, 0);
            this.Order_In_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Order_In_btn.Name = "Order_In_btn";
            this.Order_In_btn.Size = new System.Drawing.Size(181, 221);
            this.Order_In_btn.TabIndex = 1;
            this.Order_In_btn.Text = "شغل وارد من المصنع";
            this.Order_In_btn.UseVisualStyleBackColor = true;
            this.Order_In_btn.Click += new System.EventHandler(this.Order_In_btn_Click);
            // 
            // Right_Panel
            // 
            this.Right_Panel.Controls.Add(this.orders_Out_Normal_Installment1);
            this.Right_Panel.Controls.Add(this.orders_Out_Whole_Installments1);
            this.Right_Panel.Controls.Add(this.order_From_Factory_Installments1);
            this.Right_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_Panel.Location = new System.Drawing.Point(181, 0);
            this.Right_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Right_Panel.Name = "Right_Panel";
            this.Right_Panel.Size = new System.Drawing.Size(1247, 776);
            this.Right_Panel.TabIndex = 1;
            // 
            // orders_Out_Normal_Installment1
            // 
            this.orders_Out_Normal_Installment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orders_Out_Normal_Installment1.Location = new System.Drawing.Point(0, 0);
            this.orders_Out_Normal_Installment1.Margin = new System.Windows.Forms.Padding(2);
            this.orders_Out_Normal_Installment1.Name = "orders_Out_Normal_Installment1";
            this.orders_Out_Normal_Installment1.Size = new System.Drawing.Size(1247, 776);
            this.orders_Out_Normal_Installment1.TabIndex = 2;
            // 
            // orders_Out_Whole_Installments1
            // 
            this.orders_Out_Whole_Installments1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orders_Out_Whole_Installments1.Location = new System.Drawing.Point(0, 0);
            this.orders_Out_Whole_Installments1.Margin = new System.Windows.Forms.Padding(2);
            this.orders_Out_Whole_Installments1.Name = "orders_Out_Whole_Installments1";
            this.orders_Out_Whole_Installments1.Size = new System.Drawing.Size(1247, 776);
            this.orders_Out_Whole_Installments1.TabIndex = 1;
            // 
            // order_From_Factory_Installments1
            // 
            this.order_From_Factory_Installments1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_From_Factory_Installments1.Location = new System.Drawing.Point(0, 0);
            this.order_From_Factory_Installments1.Margin = new System.Windows.Forms.Padding(2);
            this.order_From_Factory_Installments1.Name = "order_From_Factory_Installments1";
            this.order_From_Factory_Installments1.Size = new System.Drawing.Size(1247, 776);
            this.order_From_Factory_Installments1.TabIndex = 0;
            // 
            // Order_Installments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Right_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order_Installments";
            this.Size = new System.Drawing.Size(1428, 776);
            this.Left_Panel.ResumeLayout(false);
            this.Right_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Panel Right_Panel;
        private System.Windows.Forms.Button Order_Out_Normal;
        private System.Windows.Forms.Button Order_Out_Whole;
        private System.Windows.Forms.Button Order_In_btn;
        private Order_From_Factory_Installments order_From_Factory_Installments1;
        private Factory.Orders_Out_Whole_Installments orders_Out_Whole_Installments1;
        private Normal.Orders_Out_Normal_Installment orders_Out_Normal_Installment1;
    }
}
