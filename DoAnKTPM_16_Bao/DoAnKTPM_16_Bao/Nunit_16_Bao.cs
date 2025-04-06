using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnKTPM_16_Bao
{
    public partial class Nunit_16_Bao : Form
    {
        public Nunit_16_Bao()
        {
            InitializeComponent();
            txtNhapK_16_Bao.Text = "2";
        }
      

        private void btnChuyen_16_Bao_Click(object sender, EventArgs e)
        {
            txtKetQua_16_Bao.Clear();
            // Kiểm tra xem người dùng đã nhập đủ thông tin chưa
            if (string.IsNullOrEmpty(txtNhapN_16_Bao.Text) || string.IsNullOrEmpty(txtNhapK_16_Bao.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                txtNhapN_16_Bao.Focus();
                return; // Dừng thực hiện tiếp tục
            }
            int Number_16_Bao = Int32.Parse(txtNhapN_16_Bao.Text);
            int Base_16_Bao = Int32.Parse(txtNhapK_16_Bao.Text);

            // Kiểm tra cơ số k có hợp lệ không
            if (Base_16_Bao < 2 || Base_16_Bao > 16)
            {
                MessageBox.Show("Cơ số k không hợp lệ. Vui lòng nhập lại!");
                txtNhapK_16_Bao.Clear();
                txtNhapK_16_Bao.Focus();
                return;
            }
            // Gọi lớp BaseConverter để chuyển đổi
            // Chuyen du lieu sang string va hien thi len giao dien
            Radix_16_Bao radix_16_Bao = new Radix_16_Bao(Number_16_Bao);
            string result_16_Bao = radix_16_Bao.ConvertDecimalToAnother_16_Bao(Base_16_Bao);
            txtKetQua_16_Bao.Text = result_16_Bao;
        }

        private void txtNhapN_16_Bao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím điều khiển (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không hợp lệ
            }
        }

        private void txtNhapK_16_Bao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím điều khiển (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không hợp lệ
            }
        }
    }
}
