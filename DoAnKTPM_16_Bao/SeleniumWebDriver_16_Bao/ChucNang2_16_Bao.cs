using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SeleniumWebDriver_16_Bao
{
    public partial class ChucNang2_16_Bao : Form
    {
        public ChucNang2_16_Bao()
        {
            InitializeComponent();
        }

        private void btnThem_16_Bao_Click(object sender, EventArgs e)
        {
            // Khai báo đường dẫn đến file chromedriver.exe
            // Khai báo một đối tượng thuộc lớp ChromeDriverService
            // Ẩn cửa sổ command prompt của trình duyệt
            ChromeDriverService chrome_16_Bao = ChromeDriverService.CreateDefaultService();
            chrome_16_Bao.HideCommandPromptWindow = true;
            // Khai báo một đối tượng thuộc lớp ChromeDriver
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_16_Bao = new ChromeDriver(chrome_16_Bao);
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
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // Đóng trình duyệt
            driver_16_Bao.Quit();

            // Kết thúc chương trình
            Environment.Exit(0);
        }
    }
}
