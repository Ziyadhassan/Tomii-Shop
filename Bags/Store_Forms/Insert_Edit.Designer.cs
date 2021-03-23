
namespace Bags
{
    partial class Insert_Edit
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
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Right_Panel = new System.Windows.Forms.Panel();
            this.insert1 = new Bags.Insert();
            this.edit1 = new Bags.Insert_and_Edit.Edit();
            this.panel1.SuspendLayout();
            this.Right_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Edit_btn);
            this.panel1.Controls.Add(this.Insert_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 955);
            this.panel1.TabIndex = 1;
            // 
            // Edit_btn
            // 
            this.Edit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.Location = new System.Drawing.Point(0, 455);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(242, 455);
            this.Edit_btn.TabIndex = 1;
            this.Edit_btn.Text = "تعديل";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(0, 0);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(242, 455);
            this.Insert_btn.TabIndex = 0;
            this.Insert_btn.Text = "أدخال";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Right_Panel
            // 
            this.Right_Panel.Controls.Add(this.edit1);
            this.Right_Panel.Controls.Add(this.insert1);
            this.Right_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_Panel.Location = new System.Drawing.Point(242, 0);
            this.Right_Panel.Name = "Right_Panel";
            this.Right_Panel.Size = new System.Drawing.Size(1662, 955);
            this.Right_Panel.TabIndex = 2;
            // 
            // insert1
            // 
            this.insert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insert1.Location = new System.Drawing.Point(0, 0);
            this.insert1.Name = "insert1";
            this.insert1.Size = new System.Drawing.Size(1662, 955);
            this.insert1.TabIndex = 0;
            // 
            // edit1
            // 
            this.edit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit1.Location = new System.Drawing.Point(0, 0);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(1662, 955);
            this.edit1.TabIndex = 1;
            // 
            // Insert_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Right_Panel);
            this.Controls.Add(this.panel1);
            this.Name = "Insert_Edit";
            this.Size = new System.Drawing.Size(1904, 955);
            this.panel1.ResumeLayout(false);
            this.Right_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Panel Right_Panel;
        private Insert insert1;
        private Insert_and_Edit.Edit edit1;
    }
}
