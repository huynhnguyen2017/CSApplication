namespace LAB8
{
    partial class Form2
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
            this.Name = new System.Windows.Forms.Label();
            this.HoanThanh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tensinhvien = new System.Windows.Forms.Label();
            this.ThayDoiDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(38, 66);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(76, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Nguyen Van A";
            // 
            // HoanThanh
            // 
            this.HoanThanh.Location = new System.Drawing.Point(91, 122);
            this.HoanThanh.Name = "HoanThanh";
            this.HoanThanh.Size = new System.Drawing.Size(75, 23);
            this.HoanThanh.TabIndex = 1;
            this.HoanThanh.Text = "Xong";
            this.HoanThanh.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tensinhvien
            // 
            this.tensinhvien.AutoSize = true;
            this.tensinhvien.Location = new System.Drawing.Point(38, 24);
            this.tensinhvien.Name = "tensinhvien";
            this.tensinhvien.Size = new System.Drawing.Size(26, 13);
            this.tensinhvien.TabIndex = 3;
            this.tensinhvien.Text = "Ten";
            // 
            // ThayDoiDiem
            // 
            this.ThayDoiDiem.AutoSize = true;
            this.ThayDoiDiem.Location = new System.Drawing.Point(133, 24);
            this.ThayDoiDiem.Name = "ThayDoiDiem";
            this.ThayDoiDiem.Size = new System.Drawing.Size(73, 13);
            this.ThayDoiDiem.TabIndex = 4;
            this.ThayDoiDiem.Text = "Thay doi diem";
            this.ThayDoiDiem.Click += new System.EventHandler(this.ThayDoiDiem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThayDoiDiem);
            this.Controls.Add(this.tensinhvien);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HoanThanh);
            this.Controls.Add(this.Name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button HoanThanh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tensinhvien;
        private System.Windows.Forms.Label ThayDoiDiem;
    }
}