using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DoAnKTPM_16_Bao;

namespace UnitTestBaseConverter_16_Bao
{
    [TestClass]
    public class UnitTest1
    {

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                     @".\Data_16_Bao\TestData3Cot_16_Bao.csv", "TestData3Cot_16_Bao#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TC1_TestWithDataSource3Cot_16_Bao()//tc1: 3 cot du lieu, 7 dong du lieu
        {

            //Lay du lieu cot 1, cot 2, cot 3 tu file csv
            //Chuyen du lieu cot 1, cot 2 tu string sang int
            int a_16_Bao = Int32.Parse(TestContext.DataRow[0].ToString());
            int b_16_Bao = Int32.Parse(TestContext.DataRow[1].ToString());
            string expected_16_Bao = TestContext.DataRow[2].ToString();

            //Goi ham ConvertToBase_16_Bao() tu class BaseConverter_16_Bao
            //so sanh gia tri tra ve voi gia tri mong doi
            Radix_16_Bao radix_16_Bao = new Radix_16_Bao(a_16_Bao);
            string result_16_Bao = radix_16_Bao.ConvertDecimalToAnother_16_Bao(b_16_Bao);
            Assert.AreEqual(expected_16_Bao, result_16_Bao);

        }
    }
}
