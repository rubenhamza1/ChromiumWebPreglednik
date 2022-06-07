using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WebPreglednikVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitChromium();
        }

        public ChromiumWebBrowser c;
        public void InitChromium()
        {
            Cef.Initialize(new CefSettings());
            c = new ChromiumWebBrowser("https://www.google.com");
            c.AddressChanged += c_AddressChanged;
            c.TitleChanged += c_TitleChanged;
            this.panel1.Controls.Add(c);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void c_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            txtBrowser.Text = e.Address.ToString();
        }

        private void c_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Text = e.Title;
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            c.Load("https://www.google.com"); 
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            c.Back();
        }

        private void tsbForward_Click(object sender, EventArgs e)
        {
            c.Forward();
        }

        private void tsbNewTab_Click(object sender, EventArgs e)
        {

        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            c.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
