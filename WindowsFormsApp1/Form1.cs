using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GhostThundraBrowser : Form
    {
        public GhostThundraBrowser()
        {
            InitializeComponent();
        }

        private void GhostThundraBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegar(urlBar.Text);
        }

        private void Navegar(string url)
        {
            if(urlBar.Text != " ")
            {
                webBrowser1.Navigate(url);
            }
            else
            {
                MessageBox.Show("Digite alguma coisa na barra de endereço");
                urlBar.Focus();
            }
            
        }

        private void btnReca_Click(object sender, EventArgs e)
        {
            Navegar(webBrowser1.Url.ToString());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); 
        }

        private void btnAvanc_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlBar.Text = webBrowser1.Url.ToString();
        }

        private void urlBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navegar(urlBar.Text);
            }
        }
    }
}
