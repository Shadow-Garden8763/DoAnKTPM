namespace SeleniumWebDriver_16_Bao
{
    partial class ChucNang3_16_Bao
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
            this.lbTitle_16_Bao = new System.Windows.Forms.Label();
            this.txtNhap_16_Bao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNhapTen_16_Bao = new System.Windows.Forms.Label();
            this.btnXoa_16_Bao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle_16_Bao
            // 
            this.lbTitle_16_Bao.AutoSize = true;
            this.lbTitle_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle_16_Bao.Location = new System.Drawing.Point(315, 102);
            this.lbTitle_16_Bao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle_16_Bao.Name = "lbTitle_16_Bao";
            this.lbTitle_16_Bao.Size = new System.Drawing.Size(487, 66);
            this.lbTitle_16_Bao.TabIndex = 3;
            this.lbTitle_16_Bao.Text = "Test chức năng xóa 1 loại sản phẩm\r\n trong giỏ hàng trên web 24hstore.vn";
            this.lbTitle_16_Bao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNhap_16_Bao
            // 
            this.txtNhap_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap_16_Bao.Location = new System.Drawing.Point(372, 329);
            this.txtNhap_16_Bao.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhap_16_Bao.Name = "txtNhap_16_Bao";
            this.txtNhap_16_Bao.Size = new System.Drawing.Size(430, 29);
            this.txtNhap_16_Bao.TabIndex = 7;
            this.txtNhap_16_Bao.TextChanged += new System.EventHandler(this.txtNhap_16_Bao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // lbNhapTen_16_Bao
            // 
            this.lbNhapTen_16_Bao.AutoSize = true;
            this.lbNhapTen_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapTen_16_Bao.Location = new System.Drawing.Point(447, 271);
            this.lbNhapTen_16_Bao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhapTen_16_Bao.Name = "lbNhapTen_16_Bao";
            this.lbNhapTen_16_Bao.Size = new System.Drawing.Size(259, 25);
            this.lbNhapTen_16_Bao.TabIndex = 9;
            this.lbNhapTen_16_Bao.Text = "Nhập đúng tên sản phẩm ";
            // 
            // btnXoa_16_Bao
            // 
            this.btnXoa_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_16_Bao.Location = new System.Drawing.Point(859, 326);
            this.btnXoa_16_Bao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa_16_Bao.Name = "btnXoa_16_Bao";
            this.btnXoa_16_Bao.Size = new System.Drawing.Size(75, 39);
            this.btnXoa_16_Bao.TabIndex = 10;
            this.btnXoa_16_Bao.Text = "Xóa";
            this.btnXoa_16_Bao.UseVisualStyleBackColor = true;
            this.btnXoa_16_Bao.Click += new System.EventHandler(this.btnXoa_16_Bao_Click);
            // 
            // ChucNang4_16_Bao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnXoa_16_Bao);
            this.Controls.Add(this.lbNhapTen_16_Bao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhap_16_Bao);
            this.Controls.Add(this.lbTitle_16_Bao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChucNang4_16_Bao";
            this.Text = "Sửa sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle_16_Bao;
        private System.Windows.Forms.TextBox txtNhap_16_Bao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNhapTen_16_Bao;
        private System.Windows.Forms.Button btnXoa_16_Bao;
    }
}