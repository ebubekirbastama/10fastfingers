using System;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace _10fastfingers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        string url = "https://10fastfingers.com/typing-test/turkish";
        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(bsl);th.Start();
        }
        ChromeDriver drv;ArrayList ary = new ArrayList();
        private void bsl()
        {
            for (int i = 0; i < drv.FindElementsByXPath("//div[@id='row1']/span").Count; i++)
            {
                drv.FindElementByXPath("//input[@id='inputfield']").SendKeys(drv.FindElementsByXPath("//div[@id='row1']/span")[i].Text);
                drv.FindElementByXPath("//input[@id='inputfield']").SendKeys(OpenQA.Selenium.Keys.Space);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            drv = new ChromeDriver();
            drv.Navigate().GoToUrl(url);
        }
    }
}
