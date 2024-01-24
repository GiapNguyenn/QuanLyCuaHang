namespace QuanLyCuaHang
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.MatHang = new System.Windows.Forms.Button();
            this.HoaDon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Thoát = new System.Windows.Forms.Button();
            this.DangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Cửa Hàng";
            // 
            // MatHang
            // 
            this.MatHang.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatHang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MatHang.Location = new System.Drawing.Point(70, 409);
            this.MatHang.Name = "MatHang";
            this.MatHang.Size = new System.Drawing.Size(118, 23);
            this.MatHang.TabIndex = 4;
            this.MatHang.Text = "Quản lý hoá đơn";
            this.MatHang.UseMnemonic = false;
            this.MatHang.UseVisualStyleBackColor = false;
            this.MatHang.Click += new System.EventHandler(this.MatHang_Click);
            // 
            // HoaDon
            // 
            this.HoaDon.BackColor = System.Drawing.Color.Black;
            this.HoaDon.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDon.ForeColor = System.Drawing.Color.White;
            this.HoaDon.Location = new System.Drawing.Point(642, 410);
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Size = new System.Drawing.Size(104, 23);
            this.HoaDon.TabIndex = 5;
            this.HoaDon.Text = "Xử Lý Đơn Hàng";
            this.HoaDon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HoaDon.UseVisualStyleBackColor = false;
            this.HoaDon.Click += new System.EventHandler(this.HoaDon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.on_line_order_pay_per_click_on_line_shopping_e_png_133134;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(588, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoá đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.mat_hang_dien_tu_nhat_ban_1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(34, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặt hàng";
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(562, 45);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(75, 23);
            this.Thoát.TabIndex = 6;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            // 
            // DangXuat
            // 
            this.DangXuat.Location = new System.Drawing.Point(695, 44);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(75, 23);
            this.DangXuat.TabIndex = 7;
            this.DangXuat.Text = "Đăng xuất";
            this.DangXuat.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.DangXuat);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.HoaDon);
            this.Controls.Add(this.MatHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MatHang;
        private System.Windows.Forms.Button HoaDon;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button DangXuat;
    }
}