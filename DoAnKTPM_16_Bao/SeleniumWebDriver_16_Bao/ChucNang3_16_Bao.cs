using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumWebDriver_16_Bao
{
    public partial class ChucNang3_16_Bao : Form
    {
        public ChucNang3_16_Bao()
        {
            InitializeComponent();
        }

        private void btnTang_16_Bao_Click(object sender, EventArgs e)
        {
            // Khai báo đường dẫn đến file chromedriver.exe
            // Khai báo một đối tượng thuộc lớp ChromeDriverService
            // Ẩn cửa sổ command prompt của trình duyệt
            ChromeDriverService chrome_16_Bao = ChromeDriverService.CreateDefaultService();
            chrome_16_Bao.HideCommandPromptWindow = true;

            // Khởi tạo ChromeOptions và bật chế độ full screen
            ChromeOptions options_16_Bao = new ChromeOptions();
            options_16_Bao.AddArgument("--start-maximized"); // Mở cửa sổ trình duyệt ở chế độ tối đa

            // Khai báo một đối tượng thuộc lớp ChromeDriver
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_16_Bao = new ChromeDriver(chrome_16_Bao, options_16_Bao);
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn");
            Thread.Sleep(2000);

            // 1. Truy cập vào giỏ hàng để lấy số lượng ban đầu
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn/gio-hang");
            Thread.Sleep(2000);

            //Số lượng sản phẩm trong giỏ hàng trước khi thêm
            int countBefore = 0;
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countBefore = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng đang trống.");
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng trước khi thêm: " + countBefore);

            // 2. Quay về trang chủ để tìm kiếm sản phẩm
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn");
            Thread.Sleep(2000);

            // 3. Tìm kiếm sản phẩm
            IWebElement searchInput_16_Bao = driver_16_Bao.FindElement(By.Id("keyword_simple"));
            IWebElement searchBtn_16_Bao = driver_16_Bao.FindElement(By.Id("searchbt_simple"));
            searchInput_16_Bao.SendKeys("iPhone 15");
            searchBtn_16_Bao.Click();
            Thread.Sleep(2000);

            // 4. Chọn sản phẩm tìm kiếm
            IWebElement Product_16_Bao = driver_16_Bao.FindElement(By.ClassName("frame_inner"));
            Product_16_Bao.Click();
            Thread.Sleep(2000);

            // 5. Thêm sản phẩm vào giỏ hàng
            IWebElement elementBtnGiaMuaNgay_16_Bao = driver_16_Bao.FindElement(By.XPath("//span[contains(text(),'Giá Mua Ngay')]"));
            IWebElement elementBtnMuaHangNgay_16_Bao = driver_16_Bao.FindElement(By.ClassName("btn-buy"));

            // Click vào nút "Giá Mua Ngay" và "Mua Hàng Ngay"
            elementBtnGiaMuaNgay_16_Bao.Click();
            Thread.Sleep(2000);
            elementBtnMuaHangNgay_16_Bao.Click();
            Thread.Sleep(2000);

            // Click vào nút "Thêm vào giỏ hàng"
            IWebElement elementBtnSumitcart_16_Bao = driver_16_Bao.FindElement(By.ClassName("submitcart"));
            elementBtnSumitcart_16_Bao.Click();
            Thread.Sleep(2000);

            // 6. Quay lại trang giỏ hàng để kiểm tra số lượng sau khi thêm
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn/gio-hang");
            Thread.Sleep(2000);

            // Lấy số lượng sau khi thêm
            int countAfter = 0;
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countAfter = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng không hiển thị số lượng, có thể lỗi xảy ra.");
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng sau khi thêm: " + countAfter);

            // 7. Kiểm tra xem số lượng sản phẩm đã tăng lên chưa
            if (countAfter > countBefore)
            {
                Console.WriteLine("Thêm vào giỏ hàng thành công!");
            }
            else
            {
                Console.WriteLine("Thêm vào giỏ hàng thất bại!");
            }

            //8. Sửa số lượng sản phẩm trong giỏ hàng
            // Lưu số lượng sản phẩm trước khi sửa
            countBefore = countAfter;
            IWebElement elementBtnPlus_16_Bao = driver_16_Bao.FindElement(By.ClassName("plus"));
            elementBtnPlus_16_Bao.Click();
            Thread.Sleep(2000);

            // 9. Kiểm tra xem số lượng sản phẩm đã được sửa chưa
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countAfter = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng trống.");
                countAfter = 0;
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng sau khi tăng: " + countAfter);
            // Kiểm tra xem số lượng sản phẩm đã giảm chưa
            if (countAfter > countBefore)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            //// Đóng trình duyệt
            //driver_16_Bao.Quit();

            //// Kết thúc chương trình
            //Environment.Exit(0);
        }

        private void btnGiam_16_Bao_Click(object sender, EventArgs e)
        {
            // Khai báo đường dẫn đến file chromedriver.exe
            // Khai báo một đối tượng thuộc lớp ChromeDriverService
            // Ẩn cửa sổ command prompt của trình duyệt
            ChromeDriverService chrome_16_Bao = ChromeDriverService.CreateDefaultService();
            chrome_16_Bao.HideCommandPromptWindow = true;

            // Khởi tạo ChromeOptions và bật chế độ full screen
            ChromeOptions options_16_Bao = new ChromeOptions();
            options_16_Bao.AddArgument("--start-maximized"); // Mở cửa sổ trình duyệt ở chế độ tối đa

            // Khai báo một đối tượng thuộc lớp ChromeDriver
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_16_Bao = new ChromeDriver(chrome_16_Bao, options_16_Bao);
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn");
            Thread.Sleep(2000);

            // 1. Truy cập vào giỏ hàng để lấy số lượng ban đầu
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn/gio-hang");
            Thread.Sleep(2000);

            //Số lượng sản phẩm trong giỏ hàng trước khi thêm
            int countBefore = 0;
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countBefore = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng đang trống.");
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng trước khi thêm: " + countBefore);

            // 2. Quay về trang chủ để tìm kiếm sản phẩm
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn");
            Thread.Sleep(2000);

            // 3. Tìm kiếm sản phẩm
            IWebElement searchInput_16_Bao = driver_16_Bao.FindElement(By.Id("keyword_simple"));
            IWebElement searchBtn_16_Bao = driver_16_Bao.FindElement(By.Id("searchbt_simple"));
            searchInput_16_Bao.SendKeys("iPhone 15");
            searchBtn_16_Bao.Click();
            Thread.Sleep(2000);

            // 4. Chọn sản phẩm tìm kiếm
            IWebElement Product_16_Bao = driver_16_Bao.FindElement(By.ClassName("frame_inner"));
            Product_16_Bao.Click();
            Thread.Sleep(2000);

            // 5. Thêm sản phẩm vào giỏ hàng
            IWebElement elementBtnGiaMuaNgay_16_Bao = driver_16_Bao.FindElement(By.XPath("//span[contains(text(),'Giá Mua Ngay')]"));
            IWebElement elementBtnMuaHangNgay_16_Bao = driver_16_Bao.FindElement(By.ClassName("btn-buy"));

            // Click vào nút "Giá Mua Ngay" và "Mua Hàng Ngay"
            elementBtnGiaMuaNgay_16_Bao.Click();
            Thread.Sleep(2000);
            elementBtnMuaHangNgay_16_Bao.Click();
            Thread.Sleep(2000);

            // Click vào nút "Thêm vào giỏ hàng"
            IWebElement elementBtnSumitcart_16_Bao = driver_16_Bao.FindElement(By.ClassName("submitcart"));
            elementBtnSumitcart_16_Bao.Click();
            Thread.Sleep(2000);

            // 6. Quay lại trang giỏ hàng để kiểm tra số lượng sau khi thêm
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn/gio-hang");
            Thread.Sleep(2000);

            // Lấy số lượng sau khi thêm
            int countAfter = 0;
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countAfter = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng không hiển thị số lượng, có thể lỗi xảy ra.");
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng sau khi thêm: " + countAfter);

            // 7. Kiểm tra xem số lượng sản phẩm đã tăng lên chưa
            if (countAfter > countBefore)
            {
                Console.WriteLine("Thêm vào giỏ hàng thành công!");
            }
            else
            {
                Console.WriteLine("Thêm vào giỏ hàng thất bại!");
            }

            //8. Sửa số lượng sản phẩm trong giỏ hàng
            // Lưu số lượng sản phẩm trước khi sửa
            countBefore = countAfter;
            IWebElement elementBtnPlus_16_Bao = driver_16_Bao.FindElement(By.ClassName("down"));
            if (countAfter == 1)
            {
                Console.WriteLine("Số lượng sản phẩm đã giảm về 1, không thể giảm nữa.");
                return;
            }
            elementBtnPlus_16_Bao.Click();
            Thread.Sleep(2000);

            // 9. Kiểm tra xem số lượng sản phẩm đã được sửa chưa
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countAfter = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng trống.");
                countAfter = 0;
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng sau khi tăng: " + countAfter);
            // Kiểm tra xem số lượng sản phẩm đã giảm chưa
            if (countAfter > countBefore)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            //// Đóng trình duyệt
            //driver_16_Bao.Quit();

            //// Kết thúc chương trình
            //Environment.Exit(0);
        }

        private void txtNhap_16_Bao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_16_Bao_Click(object sender, EventArgs e)
        {
            // Khai báo đường dẫn đến file chromedriver.exe
            // Khai báo một đối tượng thuộc lớp ChromeDriverService
            // Ẩn cửa sổ command prompt của trình duyệt
            ChromeDriverService chrome_16_Bao = ChromeDriverService.CreateDefaultService();
            chrome_16_Bao.HideCommandPromptWindow = true;

            // Khởi tạo ChromeOptions và bật chế độ full screen
            ChromeOptions options_16_Bao = new ChromeOptions();
            options_16_Bao.AddArgument("--start-maximized"); // Mở cửa sổ trình duyệt ở chế độ tối đa

            // Khai báo một đối tượng thuộc lớp ChromeDriver
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_16_Bao = new ChromeDriver(chrome_16_Bao, options_16_Bao);
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn");
            Thread.Sleep(2000);

            //Số lượng sản phẩm trong giỏ hàng trước khi thêm
            int countBefore = 0;
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countBefore = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng đang trống.");
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng trước khi thêm: " + countBefore);

            // 2. Quay về trang chủ để tìm kiếm sản phẩm
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn");
            Thread.Sleep(2000);

            // 3. Tìm kiếm sản phẩm
            IWebElement searchInput_16_Bao = driver_16_Bao.FindElement(By.Id("keyword_simple"));
            IWebElement searchBtn_16_Bao = driver_16_Bao.FindElement(By.Id("searchbt_simple"));
            searchInput_16_Bao.SendKeys("iphone 15 promax");
            searchBtn_16_Bao.Click();
            Thread.Sleep(2000);

            // 4. Chọn sản phẩm tìm kiếm
            IWebElement Product_16_Bao = driver_16_Bao.FindElement(By.ClassName("frame_inner"));
            Product_16_Bao.Click();
            Thread.Sleep(2000);

            // 5. Thêm sản phẩm vào giỏ hàng
            IWebElement elementBtnGiaMuaNgay_16_Bao = driver_16_Bao.FindElement(By.XPath("//span[contains(text(),'Giá Mua Ngay')]"));
            IWebElement elementBtnMuaHangNgay_16_Bao = driver_16_Bao.FindElement(By.ClassName("btn-buy"));

            // Click vào nút "Giá Mua Ngay" và "Mua Hàng Ngay"
            elementBtnGiaMuaNgay_16_Bao.Click();
            Thread.Sleep(2000);
            elementBtnMuaHangNgay_16_Bao.Click();
            Thread.Sleep(2000);

            // Click vào nút "Thêm vào giỏ hàng"
            IWebElement elementBtnSumitcart_16_Bao = driver_16_Bao.FindElement(By.ClassName("submitcart"));
            elementBtnSumitcart_16_Bao.Click();
            Thread.Sleep(2000);

            // 6. Tiếp tục tìm kiếm sản phẩm
            IWebElement searchInput_16_Bao1 = driver_16_Bao.FindElement(By.Id("keyword_simple"));
            IWebElement searchBtn_16_Bao1 = driver_16_Bao.FindElement(By.Id("searchbt_simple"));
            searchInput_16_Bao1.SendKeys("iPhone 16 Pro Max 1TB");
            searchBtn_16_Bao1.Click();
            Thread.Sleep(2000);

            // 7. Chọn sản phẩm tìm kiếm
            IWebElement Product_16_Bao1 = driver_16_Bao.FindElement(By.ClassName("frame_inner"));
            Product_16_Bao1.Click();
            Thread.Sleep(2000);

            // 8. Thêm sản phẩm vào giỏ hàng
            IWebElement elementBtnGiaMuaNgay_16_Bao1 = driver_16_Bao.FindElement(By.XPath("//span[contains(text(),'Giá Mua Ngay')]"));
            IWebElement elementBtnMuaHangNgay_16_Bao1 = driver_16_Bao.FindElement(By.ClassName("btn-buy"));

            // Click vào nút "Giá Mua Ngay" và "Mua Hàng Ngay"
            elementBtnGiaMuaNgay_16_Bao1.Click();
            Thread.Sleep(2000);
            elementBtnMuaHangNgay_16_Bao1.Click();
            Thread.Sleep(2000);

            // Click vào nút "Thêm vào giỏ hàng"
            IWebElement elementBtnSumitcart_16_Bao1 = driver_16_Bao.FindElement(By.ClassName("submitcart"));
            elementBtnSumitcart_16_Bao1.Click();
            Thread.Sleep(2000);

            // Lấy số lượng sau khi thêm
            int countAfter = 0;
            try
            {
                // Kiểm tra xem có hiển thị số lượng sản phẩm trong giỏ hàng không
                IWebElement cartElement = driver_16_Bao.FindElement(By.ClassName("cout_cart"));
                // Lấy số lượng sản phẩm trong giỏ hàng
                countAfter = int.Parse(cartElement.Text.Trim());
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Giỏ hàng không hiển thị số lượng, có thể lỗi xảy ra.");
            }
            Console.WriteLine("Số lượng sản phẩm trong giỏ hàng sau khi thêm: " + countAfter);

            // Tìm danh sách tất cả sản phẩm trong giỏ hàng
            IList<IWebElement> productRows_16_Bao = driver_16_Bao.FindElements(By.XPath("//tbody[@id='popup-cart']//tr"));

            // Duyệt qua từng sản phẩm trong giỏ hàng
            foreach (IWebElement product_16_Bao in productRows_16_Bao)
            {
                try
                {
                    // Tìm tên sản phẩm trong từng <tr>
                    IWebElement nameElement_16_Bao = product_16_Bao.FindElement(By.ClassName("bk-product-name"));
                    IWebElement btnDelete_16_Bao = product_16_Bao.FindElement(By.ClassName("td_delete"));
                    string productName_16_Bao = nameElement_16_Bao.Text;

                    
                    if (productName_16_Bao.Contains(txtNhap_16_Bao.Text.ToString()))
                    {
                        Console.WriteLine($"Đã tìm thấy sản phẩm: {productName_16_Bao}");
                        btnDelete_16_Bao.Click();
                        Console.WriteLine("Đã xóa sản phẩm khỏi giỏ hàng");
                        Console.WriteLine("PASS");

                        // Đóng trình duyệt
                        driver_16_Bao.Quit();

                        // Kết thúc chương trình
                        Environment.Exit(0);
                        return;
                    }
                    Console.WriteLine($" sản phẩm: {productName_16_Bao}");
                }
                catch (NoSuchElementException)
                {
                    // Nếu không tìm thấy phần tử nào, tiếp tục vòng lặp
                    continue;
                }
            }

            Console.WriteLine("Không tìm thấy sản phẩm cần xóa trong giỏ hàng");
            Console.WriteLine("FAIL");

            // Đóng trình duyệt
            driver_16_Bao.Quit();

            // Kết thúc chương trình
            Environment.Exit(0);
        }
    }
}
