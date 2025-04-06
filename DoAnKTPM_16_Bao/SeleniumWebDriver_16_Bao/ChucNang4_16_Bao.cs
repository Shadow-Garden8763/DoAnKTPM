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
    public partial class ChucNang4_16_Bao : Form
    {
        public ChucNang4_16_Bao()
        {
            InitializeComponent();
        }

        private void btnTimDuoi10Trieu_16_Bao_Click(object sender, EventArgs e)
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
            IWebDriver driver_16_Bao = new ChromeDriver(chrome_16_Bao,options_16_Bao);
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn");
            Thread.Sleep(2000);

            // 1. Vào mục điện thoại
            IWebElement dienThoaiElement = driver_16_Bao.FindElement(By.XPath("//span[contains(text(),'Điện thoại')]"));
            dienThoaiElement.Click();
            Thread.Sleep(2000);

            // 2. Chọn mức giá dưới 10 triệu
            IWebElement giaElement_16_Bao = driver_16_Bao.FindElement(By.XPath("//a[contains(text(),'Dưới 10 triệu')]"));
            giaElement_16_Bao.Click();
            Thread.Sleep(2000);

            // 3. Lấy danh sách sản phẩm
            IList<IWebElement> products_16_Bao = driver_16_Bao.FindElements(By.ClassName("frame_inner"));
            foreach (IWebElement product_16_Bao in products_16_Bao)
            {
                // Giả sử bạn đã tìm thấy phần tử chứa giá sản phẩm
                string priceText_16_Bao = product_16_Bao.FindElement(By.XPath("//*[@id=\"box_product\"]/div[1]/div/div[2]/span[2]")).Text;

                // Loại bỏ dấu chấm và chữ "đ" và khoảng trắng
                priceText_16_Bao = priceText_16_Bao.Replace(".", "").Replace("đ", "").Trim();

                // Chuyển chuỗi giá sang kiểu int
                int price_16_Bao = Int32.Parse(priceText_16_Bao);

                // Kiểm tra giá có nằm trong khoảng trên 10 triệu
                if (price_16_Bao >= 10000000)
                {
                    // Nếu có sản phẩm nào có giá trên 10 triệu thì fail
                    Console.WriteLine("FAIL");

                    // Đóng trình duyệt
                    driver_16_Bao.Quit();

                    // Kết thúc chương trình
                    Environment.Exit(0);
                }
               
            }
            // Nếu không có sản phẩm nào có giá trên 10 triệu thì pass
            Console.WriteLine("PASS");

            // Đóng trình duyệt
            driver_16_Bao.Quit();

            // Kết thúc chương trình
            Environment.Exit(0);
        }

        private void btnTimTu10TrieuDen20Trieu_16_Bao_Click(object sender, EventArgs e)
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

            // 1. Vào mục điện thoại
            IWebElement dienThoaiElement = driver_16_Bao.FindElement(By.XPath("//span[contains(text(),'Điện thoại')]"));
            dienThoaiElement.Click();
            Thread.Sleep(2000);

            // 2. Chọn mức giá từ 10 đến 20 triệu
            IWebElement giaElement_16_Bao = driver_16_Bao.FindElement(By.XPath("//*[@id=\"main_container\"]/div/div[3]/div[1]/div/div/div[1]/div[1]/div/div/ul/li[2]/a"));
            giaElement_16_Bao.Click();
            Thread.Sleep(2000);

            // 3. Lấy danh sách sản phẩm
            IList<IWebElement> products_16_Bao = driver_16_Bao.FindElements(By.ClassName("frame_inner"));
            foreach (IWebElement product_16_Bao in products_16_Bao)
            {
                // Giả sử bạn đã tìm thấy phần tử chứa giá sản phẩm
                string priceText_16_Bao = product_16_Bao.FindElement(By.XPath("//*[@id=\"box_product\"]/div[2]/div/div[2]/span[2]")).Text;

                // Loại bỏ dấu chấm và chữ "đ" và khoảng trắng
                priceText_16_Bao = priceText_16_Bao.Replace(".", "").Replace("đ", "").Trim();

                // Chuyển chuỗi giá sang kiểu int
                int price_16_Bao = Int32.Parse(priceText_16_Bao);

                // Kiểm tra giá có nằm ngoài khoảng 10 triệu đến 20 triệu
                if (price_16_Bao < 10000000 || price_16_Bao > 20000000 )
                {
                    // Nếu có sản phẩm thì fail
                    Console.WriteLine("FAIL");

                    // Đóng trình duyệt
                    driver_16_Bao.Quit();

                    // Kết thúc chương trình
                    Environment.Exit(0);
                }
            }
            // Nếu không có sản phẩm nào có giá dưới 10 triệu hoặc trên 20 triệu thì pass
            Console.WriteLine("PASS");

            // Đóng trình duyệt
            driver_16_Bao.Quit();

            // Kết thúc chương trình
            Environment.Exit(0);
        }

        private void btnTimTren20Trieu_16_Bao_Click(object sender, EventArgs e)
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

            // 1. Vào mục điện thoại
            IWebElement dienThoaiElement = driver_16_Bao.FindElement(By.XPath("//span[contains(text(),'Điện thoại')]"));
            dienThoaiElement.Click();
            Thread.Sleep(2000);

            // 2. Chọn mức giá từ trên 20 triệu
            IWebElement giaElement_16_Bao = driver_16_Bao.FindElement(By.XPath("//a[contains(text(),'Trên 20 triệu')]"));
            giaElement_16_Bao.Click();
            Thread.Sleep(2000);

            // 3. Lấy danh sách sản phẩm
            IList<IWebElement> products_16_Bao = driver_16_Bao.FindElements(By.ClassName("frame_inner"));
            foreach (IWebElement product_16_Bao in products_16_Bao)
            {
                // Giả sử bạn đã tìm thấy phần tử chứa giá sản phẩm
                string priceText_16_Bao = product_16_Bao.FindElement(By.XPath("//*[@id=\"box_product\"]/div[1]/div/div[2]/span[2]")).Text;

                // Loại bỏ dấu chấm và chữ "đ" và khoảng trắng
                priceText_16_Bao = priceText_16_Bao.Replace(".", "").Replace("đ", "").Trim();

                // Chuyển chuỗi giá sang kiểu int
                int price_16_Bao = Int32.Parse(priceText_16_Bao);

                // Kiểm tra có giá dưới 20 triệu
                if (price_16_Bao <= 20000000)
                {
                    // Nếu có sản phẩm thì fail
                    Console.WriteLine("FAIL");

                    // Đóng trình duyệt
                    driver_16_Bao.Quit();

                    // Kết thúc chương trình
                    Environment.Exit(0);
                }
            }
            // Nếu không có sản phẩm nào có giá dưới 10 triệu hoặc trên 20 triệu thì pass
            Console.WriteLine("PASS");

            // Đóng trình duyệt
            driver_16_Bao.Quit();

            // Kết thúc chương trình
            Environment.Exit(0);
        }
    }
}
