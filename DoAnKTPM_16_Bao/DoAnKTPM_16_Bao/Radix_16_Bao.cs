using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnKTPM_16_Bao
{
    public class Radix_16_Bao
    {
        private int number_16_Bao;

        // Constructor nhận một số nguyên và kiểm tra giá trị hợp lệ
        public Radix_16_Bao(int number)
        {
            if (number < 0)
                throw new ArgumentException("Incorrect Value"); // Ném lỗi nếu số âm

            this.number_16_Bao = number;
        }

        // Phương thức chuyển đổi từ hệ thập phân sang hệ khác (mặc định là nhị phân - radix = 2)
        public string ConvertDecimalToAnother_16_Bao(int radix_16_Bao = 2)
        {
            int n_16_Bao = this.number_16_Bao;
            if(n_16_Bao == 0) return "0"; // Nếu số là 0, trả về "0"

            // Kiểm tra giá trị radix phải nằm trong khoảng từ 2 đến 16
            if (radix_16_Bao < 2 || radix_16_Bao > 16)
                throw new ArgumentException("Invalid Radix");

            List<string> result_16_Bao = new List<string>();

            // Lặp đến khi n trở về 0
            while (n_16_Bao > 0)
            {
                int value_16_Bao = n_16_Bao % radix_16_Bao; // Lấy phần dư của phép chia n cho radix

                if (value_16_Bao < 10)
                    result_16_Bao.Add(value_16_Bao.ToString()); // Nếu nhỏ hơn 10, thêm số vào danh sách
                else
                {
                    // Nếu lớn hơn hoặc bằng 10, chuyển thành chữ cái tương ứng trong hệ 16
                    switch (value_16_Bao)
                    {
                        case 10: result_16_Bao.Add("A"); break;
                        case 11: result_16_Bao.Add("B"); break;
                        case 12: result_16_Bao.Add("C"); break;
                        case 13: result_16_Bao.Add("D"); break;
                        case 14: result_16_Bao.Add("E"); break;
                        case 15: result_16_Bao.Add("F"); break;
                    }
                }
                n_16_Bao /= radix_16_Bao; // Chia n cho radix để tiếp tục chuyển đổi
            }

            result_16_Bao.Reverse(); // Đảo ngược danh sách để có đúng thứ tự của số trong hệ radix

            return String.Join("", result_16_Bao.ToArray()); // Ghép các phần tử lại thành chuỗi kết quả
        }
    }
}
