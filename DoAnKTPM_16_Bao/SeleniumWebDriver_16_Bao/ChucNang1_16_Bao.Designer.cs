namespace SeleniumWebDriver_16_Bao
{
    partial class ChucNang1_16_Bao
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
            this.lbNhap_16_Bao = new System.Windows.Forms.Label();
            this.btnTim_16_Bao = new System.Windows.Forms.Button();
            this.txtTim_16_Bao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitle_16_Bao
            // 
            this.lbTitle_16_Bao.AutoSize = true;
            this.lbTitle_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle_16_Bao.Location = new System.Drawing.Point(213, 60);
            this.lbTitle_16_Bao.Name = "lbTitle_16_Bao";
            this.lbTitle_16_Bao.Size = new System.Drawing.Size(406, 66);
            this.lbTitle_16_Bao.TabIndex = 0;
            this.lbTitle_16_Bao.Text = "Test chức năng tìm kiếm\r\n theo tên trên web 24hstore.vn";
            this.lbTitle_16_Bao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNhap_16_Bao
            // 
            this.lbNhap_16_Bao.AutoSize = true;
            this.lbNhap_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhap_16_Bao.Location = new System.Drawing.Point(108, 187);
            this.lbNhap_16_Bao.Name = "lbNhap_16_Bao";
            this.lbNhap_16_Bao.Size = new System.Drawing.Size(184, 25);
            this.lbNhap_16_Bao.TabIndex = 1;
            this.lbNhap_16_Bao.Text = "Nhập kí tự cần tìm";
            // 
            // btnTim_16_Bao
            // 
            this.btnTim_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim_16_Bao.Location = new System.Drawing.Point(571, 187);
            this.btnTim_16_Bao.Name = "btnTim_16_Bao";
            this.btnTim_16_Bao.Size = new System.Drawing.Size(75, 25);
            this.btnTim_16_Bao.TabIndex = 2;
            this.btnTim_16_Bao.Text = "Tìm";
            this.btnTim_16_Bao.UseVisualStyleBackColor = true;
            this.btnTim_16_Bao.Click += new System.EventHandler(this.btnTim_16_Bao_Click);
            // 
            // txtTim_16_Bao
            // 
            this.txtTim_16_Bao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim_16_Bao.Location = new System.Drawing.Point(331, 187);
            this.txtTim_16_Bao.Name = "txtTim_16_Bao";
            this.txtTim_16_Bao.Size = new System.Drawing.Size(163, 29);
            this.txtTim_16_Bao.TabIndex = 3;
            // 
            // ChucNang1_16_Bao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTim_16_Bao);
            this.Controls.Add(this.btnTim_16_Bao);
            this.Controls.Add(this.lbNhap_16_Bao);
            this.Controls.Add(this.lbTitle_16_Bao);
            this.Name = "ChucNang1_16_Bao";
            this.Text = "Tìm kiếm sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle_16_Bao;
        private System.Windows.Forms.Label lbNhap_16_Bao;
        private System.Windows.Forms.Button btnTim_16_Bao;
        private System.Windows.Forms.TextBox txtTim_16_Bao;
    }
}

