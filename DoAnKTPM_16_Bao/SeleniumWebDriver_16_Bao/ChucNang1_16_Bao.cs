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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver_16_Bao
{
    public partial class ChucNang1_16_Bao : Form
    {
        public ChucNang1_16_Bao()
        {
            InitializeComponent();
        }

        private void btnTim_16_Bao_Click(object sender, EventArgs e)
        {
            // Khai báo đường dẫn đến file chromedriver.exe
            // Khai báo một đối tượng thuộc lớp ChromeDriverService
            // Ẩn cửa sổ command prompt của trình duyệt
            ChromeDriverService chrome_16_Bao = ChromeDriverService.CreateDefaultService();
            chrome_16_Bao.HideCommandPromptWindow = true;
            // Khai báo một đối tượng thuộc lớp ChromeDriver
            // Khởi tạo trình duyệt Chrome
            // Truy cập vào trang web 24hstore.vn
            IWebDriver driver_16_Bao = new ChromeDriver(chrome_16_Bao);
            driver_16_Bao.Navigate().GoToUrl("https://24hstore.vn/");

            // Tìm kiếm sản phẩm trên trang web 24hstore.vn
            // Tìm đến ô tìm kiếm và nút tìm kiếm
            // Gửi dữ liệu cần tìm kiếm vào ô tìm kiếm
            // Click vào nút tìm kiếm
            IWebElement elementTxt_16_Bao = driver_16_Bao.FindElement(By.Id("keyword_simple"));
            IWebElement elementBtn_16_Bao = driver_16_Bao.FindElement(By.Id("searchbt_simple"));
            elementTxt_16_Bao.SendKeys(txtTim_16_Bao.Text);
            elementBtn_16_Bao.Click();

            Thread.Sleep(5000);

            // Đợi cho đến khi trang hoàn thành tìm kiếm
            WebDriverWait wait = new WebDriverWait(driver_16_Bao, TimeSpan.FromSeconds(5));
            // Tìm tất cả các sản phẩm (giả sử class 'product' là thẻ chứa sản phẩm)
            IList<IWebElement> productElements = wait.Until(d => d.FindElements(By.ClassName("productbox")));
            // Kiểm tra số lượng sản phẩm
            if (productElements.Count == 0)
                Console.WriteLine("Không tim thay san pham");
            else
                Console.WriteLine("Tim thay san pham");
            // Đóng trình duyệt
            driver_16_Bao.Quit();

            // Kết thúc chương trình
            Environment.Exit(0);
        }
    }
}
