namespace EditorDeTextoSI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripNegrito = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAjuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.rtxtBox = new System.Windows.Forms.RichTextBox();
            this.svdlg = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fontdlg = new System.Windows.Forms.FontDialog();
            this.refazerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip.SuspendLayout();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrip
            // 
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(579, 24);
            this.mnStrip.TabIndex = 0;
            this.mnStrip.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirTextoToolStripMenuItem,
            this.salvarTextoToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.refazerToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirTextoToolStripMenuItem
            // 
            this.abrirTextoToolStripMenuItem.Name = "abrirTextoToolStripMenuItem";
            this.abrirTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirTextoToolStripMenuItem.Text = "Abrir Texto";
            this.abrirTextoToolStripMenuItem.Click += new System.EventHandler(this.abrirTextoToolStripMenuItem_Click);
            // 
            // salvarTextoToolStripMenuItem
            // 
            this.salvarTextoToolStripMenuItem.Name = "salvarTextoToolStripMenuItem";
            this.salvarTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarTextoToolStripMenuItem.Text = "Salvar Texto";
            this.salvarTextoToolStripMenuItem.Click += new System.EventHandler(this.salvarTextoToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refazerToolStripMenuItem.Text = "Desfazer";
            this.refazerToolStripMenuItem.Click += new System.EventHandler(this.refazerToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alterarFonteToolStripMenuItem,
            this.alinharTextoToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alterarFonteToolStripMenuItem
            // 
            this.alterarFonteToolStripMenuItem.Name = "alterarFonteToolStripMenuItem";
            this.alterarFonteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alterarFonteToolStripMenuItem.Text = "Alterar Fonte";
            this.alterarFonteToolStripMenuItem.Click += new System.EventHandler(this.alterarFonteToolStripMenuItem_Click);
            // 
            // alinharTextoToolStripMenuItem
            // 
            this.alinharTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.direitaToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.centroToolStripMenuItem});
            this.alinharTextoToolStripMenuItem.Name = "alinharTextoToolStripMenuItem";
            this.alinharTextoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinharTextoToolStripMenuItem.Text = "Alinhar Texto";
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            this.centroToolStripMenuItem.Click += new System.EventHandler(this.centroToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // tStrip
            // 
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNovo,
            this.toolStripAbrir,
            this.toolStripSalvar,
            this.toolStripCopiar,
            this.toolStripColar,
            this.toolStripSeparator1,
            this.toolStripNegrito,
            this.toolStripItalico,
            this.toolStripSublinhado,
            this.toolStripFonte,
            this.toolStripSeparator2,
            this.toolStripAjuda,
            this.toolStripSair});
            this.tStrip.Location = new System.Drawing.Point(0, 24);
            this.tStrip.Name = "tStrip";
            this.tStrip.Size = new System.Drawing.Size(579, 25);
            this.tStrip.TabIndex = 1;
            this.tStrip.Text = "toolStrip1";
            // 
            // toolStripNovo
            // 
            this.toolStripNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNovo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNovo.Image")));
            this.toolStripNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNovo.Name = "toolStripNovo";
            this.toolStripNovo.Size = new System.Drawing.Size(23, 22);
            this.toolStripNovo.Text = "Novo";
            this.toolStripNovo.Click += new System.EventHandler(this.toolStripNovo_Click);
            // 
            // toolStripAbrir
            // 
            this.toolStripAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAbrir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAbrir.Image")));
            this.toolStripAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAbrir.Name = "toolStripAbrir";
            this.toolStripAbrir.Size = new System.Drawing.Size(23, 22);
            this.toolStripAbrir.Text = "Abir";
            this.toolStripAbrir.Click += new System.EventHandler(this.toolStripAbrir_Click);
            // 
            // toolStripSalvar
            // 
            this.toolStripSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSalvar.Image")));
            this.toolStripSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvar.Name = "toolStripSalvar";
            this.toolStripSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolStripSalvar.Text = "Salvar";
            this.toolStripSalvar.Click += new System.EventHandler(this.toolStripSalvar_Click);
            // 
            // toolStripCopiar
            // 
            this.toolStripCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopiar.Image")));
            this.toolStripCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopiar.Name = "toolStripCopiar";
            this.toolStripCopiar.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopiar.Text = "Copiar";
            this.toolStripCopiar.Click += new System.EventHandler(this.toolStripCopiar_Click);
            // 
            // toolStripColar
            // 
            this.toolStripColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripColar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripColar.Image")));
            this.toolStripColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripColar.Name = "toolStripColar";
            this.toolStripColar.Size = new System.Drawing.Size(23, 22);
            this.toolStripColar.Text = "Colar";
            this.toolStripColar.Click += new System.EventHandler(this.toolStripColar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripNegrito
            // 
            this.toolStripNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNegrito.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNegrito.Image")));
            this.toolStripNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNegrito.Name = "toolStripNegrito";
            this.toolStripNegrito.Size = new System.Drawing.Size(23, 22);
            this.toolStripNegrito.Text = "Negrito";
            this.toolStripNegrito.Click += new System.EventHandler(this.toolStripNegrito_Click);
            // 
            // toolStripItalico
            // 
            this.toolStripItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalico.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItalico.Image")));
            this.toolStripItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalico.Name = "toolStripItalico";
            this.toolStripItalico.Size = new System.Drawing.Size(23, 22);
            this.toolStripItalico.Text = "Itálico";
            this.toolStripItalico.Click += new System.EventHandler(this.toolStripItalico_Click);
            // 
            // toolStripSublinhado
            // 
            this.toolStripSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSublinhado.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSublinhado.Image")));
            this.toolStripSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSublinhado.Name = "toolStripSublinhado";
            this.toolStripSublinhado.Size = new System.Drawing.Size(23, 22);
            this.toolStripSublinhado.Text = "Sublinhado";
            this.toolStripSublinhado.Click += new System.EventHandler(this.toolStripSublinhado_Click);
            // 
            // toolStripFonte
            // 
            this.toolStripFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFonte.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFonte.Image")));
            this.toolStripFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFonte.Name = "toolStripFonte";
            this.toolStripFonte.Size = new System.Drawing.Size(23, 22);
            this.toolStripFonte.Text = "Alterar Fonte";
            this.toolStripFonte.Click += new System.EventHandler(this.toolStripFonte_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripAjuda
            // 
            this.toolStripAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAjuda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAjuda.Image")));
            this.toolStripAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAjuda.Name = "toolStripAjuda";
            this.toolStripAjuda.Size = new System.Drawing.Size(23, 22);
            this.toolStripAjuda.Text = "Ajuda/Sobre";
            // 
            // toolStripSair
            // 
            this.toolStripSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSair.Image")));
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(23, 22);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // rtxtBox
            // 
            this.rtxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtBox.Location = new System.Drawing.Point(0, 49);
            this.rtxtBox.Name = "rtxtBox";
            this.rtxtBox.Size = new System.Drawing.Size(579, 306);
            this.rtxtBox.TabIndex = 2;
            this.rtxtBox.Text = "";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // refazerToolStripMenuItem1
            // 
            this.refazerToolStripMenuItem1.Name = "refazerToolStripMenuItem1";
            this.refazerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.refazerToolStripMenuItem1.Text = "Refazer";
            this.refazerToolStripMenuItem1.Click += new System.EventHandler(this.refazerToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 355);
            this.Controls.Add(this.rtxtBox);
            this.Controls.Add(this.tStrip);
            this.Controls.Add(this.mnStrip);
            this.MainMenuStrip = this.mnStrip;
            this.Name = "Form1";
            this.Text = "Editor de Texto Padrão - Aula Prática";
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinharTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton toolStripNovo;
        private System.Windows.Forms.ToolStripButton toolStripAbrir;
        private System.Windows.Forms.ToolStripButton toolStripSalvar;
        private System.Windows.Forms.ToolStripButton toolStripCopiar;
        private System.Windows.Forms.ToolStripButton toolStripColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripNegrito;
        private System.Windows.Forms.ToolStripButton toolStripItalico;
        private System.Windows.Forms.ToolStripButton toolStripSublinhado;
        private System.Windows.Forms.ToolStripButton toolStripFonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripAjuda;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.RichTextBox rtxtBox;
        private System.Windows.Forms.SaveFileDialog svdlg;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FontDialog fontdlg;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem1;
    }
}

