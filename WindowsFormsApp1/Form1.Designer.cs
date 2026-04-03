namespace WindowsFormsApp1
{
    partial class GhostThundraBrowser
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GhostThundraBrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.btnAvanc = new System.Windows.Forms.ToolStripButton();
            this.btnReca = new System.Windows.Forms.ToolStripButton();
            this.urlBar = new System.Windows.Forms.ToolStripTextBox();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Azure;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltar,
            this.btnAvanc,
            this.btnReca,
            this.urlBar,
            this.btnPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1276, 46);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnVoltar
            // 
            this.btnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(29, 43);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvanc
            // 
            this.btnAvanc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAvanc.Image = ((System.Drawing.Image)(resources.GetObject("btnAvanc.Image")));
            this.btnAvanc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAvanc.Name = "btnAvanc";
            this.btnAvanc.Size = new System.Drawing.Size(29, 43);
            this.btnAvanc.Text = "Avançar";
            this.btnAvanc.Click += new System.EventHandler(this.btnAvanc_Click);
            // 
            // btnReca
            // 
            this.btnReca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReca.Image = ((System.Drawing.Image)(resources.GetObject("btnReca.Image")));
            this.btnReca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReca.Name = "btnReca";
            this.btnReca.Size = new System.Drawing.Size(29, 43);
            this.btnReca.Text = "Recarregar página";
            this.btnReca.Click += new System.EventHandler(this.btnReca_Click);
            // 
            // urlBar
            // 
            this.urlBar.AutoSize = false;
            this.urlBar.BackColor = System.Drawing.Color.Azure;
            this.urlBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.urlBar.Margin = new System.Windows.Forms.Padding(40, 15, 1, 0);
            this.urlBar.Name = "urlBar";
            this.urlBar.Size = new System.Drawing.Size(1300, 27);
            this.urlBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlBar_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(29, 24);
            this.btnPesquisar.Text = "pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 46);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1276, 646);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // GhostThundraBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 692);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GhostThundraBrowser";
            this.Text = "Ghost Thudra Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GhostThundraBrowser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripButton btnAvanc;
        private System.Windows.Forms.ToolStripButton btnReca;
        private System.Windows.Forms.ToolStripTextBox urlBar;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

