using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTextoSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripFonte_Click(object sender, EventArgs e)
        {
            this.AlterarFonte();
        }

        private void ChamaSalvarArquivoDialog()
        {
            if (!string.IsNullOrEmpty(rtxtBox.Text))
            {
                if ((MessageBox.Show("Deseja Salvar o arquivo ?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    SalvarArquivo();
                }
            }
        }

        private void SalvarArquivo()
        {
            try
            {
                //Configurando o componente para salvar no formato padrão RTF.
                this.svdlg.Filter = "rtf [*.rtf*]|*.rtf|All Files [*,*]|*,*";                
                this.svdlg.Title = "Salvar Arquivo";
                // Pega o nome do arquivo para salvar
                if (this.svdlg.ShowDialog() == DialogResult.OK)
                {
                    
                    // abre um stream para escrita e cria um StreamWriter para implementar o stream
                    FileStream fs = new FileStream(svdlg.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Flush();
                    // Escreve para o arquivo usando a classe StreamWriter
                    sw.BaseStream.Seek(0, SeekOrigin.Begin);
                    // escreve no controle richtextbox
                    sw.Write(this.rtxtBox.Text);
                    // fecha o arquivo
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AbrirArquivo()
        {
            //define a configuração padrão da tela de dialogo para abrir o arquivo.            
            this.ofd.Multiselect = true;
            this.ofd.Title = "Selecionar Arquivo";
            ofd.InitialDirectory = @"C:\tmp\";
            //aplicando os filtros para os tipos de arquivo.
            ofd.Filter = "Images (*.rtf)|*.rtf|" + "All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;
            DialogResult dr = this.ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    // Lê o arquivo usando a classe StreamReader
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    // Lê cada linha do stream e faz o parse até a última linha
                    this.rtxtBox.Text = "";
                    string linha = sr.ReadLine();
                    while (linha != null)
                    {
                        this.rtxtBox.Text += linha + "\n";
                        linha = sr.ReadLine();
                    }
                    // Fecha o stream
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Copiar()
        {
            if (rtxtBox.SelectionLength > 0)
            {
                rtxtBox.Copy();
            }
        }

        private void Colar()
        {
            rtxtBox.Paste();
        }

        private void Negritar()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool negrito = false;
            nome_fonte = rtxtBox.Font.Name;
            tamanho_fonte = rtxtBox.Font.Size;
            negrito = rtxtBox.Font.Bold;
            if (negrito == false)
            {
                rtxtBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
            }
            else
            {
                rtxtBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);
            }
        }
        

        private void Italico()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool italico = false;
            nome_fonte = rtxtBox.Font.Name;
            tamanho_fonte = rtxtBox.Font.Size;
            italico = rtxtBox.Font.Italic;

            if (italico == false)
            {
                rtxtBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
            else
            {
                rtxtBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
            }
        }

        private void Sublinhar()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool sublinha = false;
            nome_fonte = rtxtBox.Font.Name;
            tamanho_fonte = rtxtBox.Font.Size;
            sublinha = rtxtBox.Font.Underline;
            if (sublinha == false)
            {
                rtxtBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
            }
            else
            {
                rtxtBox.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
            }
        }

        private void AlterarFonte()
        {
            //Altera a fonte com base na invocação da janela de alteração fontdlg.
            DialogResult result = fontdlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (rtxtBox.SelectionFont != null)
                {
                    rtxtBox.SelectionFont = fontdlg.Font;
                }
            }
        }

        //Basicamente o alinhamento utiliza a enum HorizontAlignment para posicionar o texto selecionado em relação ao componente de controle.
        private void AlinharEsquerda()
        {
            rtxtBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinharDireita()
        {
            rtxtBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AlinharCentro()
        {
            rtxtBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripNovo_Click(object sender, EventArgs e)
        {
            this.ChamaSalvarArquivoDialog();
            this.rtxtBox.Clear();
            this.rtxtBox.Focus();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChamaSalvarArquivoDialog();
            this.rtxtBox.Clear();
            this.rtxtBox.Focus();
        }

        private void abrirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirArquivo();
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            this.AbrirArquivo();
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            this.ChamaSalvarArquivoDialog();
        }

        private void toolStripCopiar_Click(object sender, EventArgs e)
        {
            this.Copiar();
        }

        private void salvarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChamaSalvarArquivoDialog();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Colar();
        }

        private void toolStripColar_Click(object sender, EventArgs e)
        {
            this.Colar();
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtBox.Undo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripNegrito_Click(object sender, EventArgs e)
        {
            this.Negritar();
        }

        private void toolStripItalico_Click(object sender, EventArgs e)
        {
            this.Italico();
        }

        private void toolStripSublinhado_Click(object sender, EventArgs e)
        {
            this.Sublinhar();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Negritar();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sublinhar();
        }

        private void alterarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AlterarFonte();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AlinharDireita();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AlinharEsquerda();
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AlinharCentro();
        }

        private void refazerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.rtxtBox.Redo();
        }
    }
}
