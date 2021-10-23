
namespace Bags
{
    partial class Full_Store
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
            this.Sales_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Store_btn = new System.Windows.Forms.Button();
            this.Right_Panel = new System.Windows.Forms.Panel();
            this.Sales_Panel = new Bags.Sales();
            this.Edit_Panel = new Bags.Insert_and_Edit.Edit();
            this.Insert_Panel = new Bags.Insert();
            this.Store_Panel = new Bags.Store();
            this.Left_Panel.SuspendLayout();
            this.Right_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.Controls.Add(this.Sales_btn);
            this.Left_Panel.Controls.Add(this.Edit_btn);
            this.Left_Panel.Controls.Add(this.Insert_btn);
            this.Left_Panel.Controls.Add(this.Store_btn);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(181, 776);
            this.Left_Panel.TabIndex = 1;
            // 
            // Sales_btn
            // 
            this.Sales_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_btn.Location = new System.Drawing.Point(0, 453);
            this.Sales_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sales_btn.Name = "Sales_btn";
            this.Sales_btn.Size = new System.Drawing.Size(181, 151);
            this.Sales_btn.TabIndex = 0;
            this.Sales_btn.Text = "المبيعات";
            this.Sales_btn.UseVisualStyleBackColor = true;
            this.Sales_btn.Click += new System.EventHandler(this.Sales_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.Location = new System.Drawing.Point(0, 302);
            this.Edit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(181, 151);
            this.Edit_btn.TabIndex = 0;
            this.Edit_btn.Text = "تعديل";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(0, 151);
            this.Insert_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(181, 151);
            this.Insert_btn.TabIndex = 0;
            this.Insert_btn.Text = "ادخال";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Store_btn
            // 
            this.Store_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Store_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Store_btn.Location = new System.Drawing.Point(0, 0);
            this.Store_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Store_btn.Name = "Store_btn";
            this.Store_btn.Size = new System.Drawing.Size(181, 151);
            this.Store_btn.TabIndex = 0;
            this.Store_btn.Text = "المخزن";
            this.Store_btn.UseVisualStyleBackColor = true;
            this.Store_btn.Click += new System.EventHandler(this.Store_btn_Click);
            // 
            // Right_Panel
            // 
            this.Right_Panel.Controls.Add(this.Sales_Panel);
            this.Right_Panel.Controls.Add(this.Edit_Panel);
            this.Right_Panel.Controls.Add(this.Insert_Panel);
            this.Right_Panel.Controls.Add(this.Store_Panel);
            this.Right_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_Panel.Location = new System.Drawing.Point(181, 0);
            this.Right_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Right_Panel.Name = "Right_Panel";
            this.Right_Panel.Size = new System.Drawing.Size(1247, 776);
            this.Right_Panel.TabIndex = 2;
            // 
            // Sales_Panel
            // 
            this.Sales_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sales_Panel.Location = new System.Drawing.Point(0, 0);
            this.Sales_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sales_Panel.Name = "Sales_Panel";
            this.Sales_Panel.Size = new System.Drawing.Size(1247, 776);
            this.Sales_Panel.TabIndex = 3;
            // 
            // Edit_Panel
            // 
            this.Edit_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edit_Panel.Location = new System.Drawing.Point(0, 0);
            this.Edit_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit_Panel.Name = "Edit_Panel";
            this.Edit_Panel.Size = new System.Drawing.Size(1247, 776);
            this.Edit_Panel.TabIndex = 2;
            // 
            // Insert_Panel
            // 
            this.Insert_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Insert_Panel.Location = new System.Drawing.Point(0, 0);
            this.Insert_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Insert_Panel.Name = "Insert_Panel";
            this.Insert_Panel.Size = new System.Drawing.Size(1247, 776);
            this.Insert_Panel.TabIndex = 1;
            // 
            // Store_Panel
            // 
            this.Store_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Store_Panel.Location = new System.Drawing.Point(0, 0);
            this.Store_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Store_Panel.Name = "Store_Panel";
            this.Store_Panel.Size = new System.Drawing.Size(1247, 776);
            this.Store_Panel.TabIndex = 0;
            // 
            // Full_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Right_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Full_Store";
            this.Size = new System.Drawing.Size(1428, 776);
            this.Left_Panel.ResumeLayout(false);
            this.Right_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Button Sales_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Store_btn;
        private System.Windows.Forms.Panel Right_Panel;
        private Sales Sales_Panel;
        private Insert_and_Edit.Edit Edit_Panel;
        private Insert Insert_Panel;
        private Store Store_Panel;
    }
}
