using Microsoft.Win32; // Biblioteca para manipular o registro
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TemplatesQA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;

            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Visible = true;

            // Associa o evento de abertura do menu para atualizar a lista
            contextMenuStrip1.Opening += ContextMenuStrip1_Opening;

            // Associa o evento de renderização personalizada
            contextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomMenuColorTable());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarInicioComWindows();
            CarregarTemplates();
            AdicionarItemSair(); // Adiciona o item fixo "Sair"
        }

        private void ConfigurarInicioComWindows()
        {
            try
            {
                string caminhoAplicativo = Application.ExecutablePath;
                string nomeAplicativo = "TemplatesQA";

                using (RegistryKey chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (chave.GetValue(nomeAplicativo) == null)
                    {
                        chave.SetValue(nomeAplicativo, caminhoAplicativo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao configurar o início automático: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AtualizarTemplates();
        }

        private void AtualizarTemplates()
        {
            try
            {
                contextMenuStrip1.Items.Clear(); // Limpa o menu atual
                CarregarTemplates();            // Recarrega os templates
                AdicionarItemSair();            // Reinsere o item fixo "Sair"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a lista: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarTemplates()
        {
            string pastaRaiz = Application.StartupPath;

            // Obtém todas as pastas na raiz
            var pastas = Directory.GetDirectories(pastaRaiz);

            foreach (var pasta in pastas)
            {
                string nomePasta = Path.GetFileName(pasta);

                // Cria um item de menu para a pasta
                var pastaItem = new ToolStripMenuItem(nomePasta);

                // Obtém os arquivos .txt dentro da pasta
                var arquivos = Directory.GetFiles(pasta, "*.txt");

                foreach (var arquivo in arquivos)
                {
                    string nomeArquivo = Path.GetFileNameWithoutExtension(arquivo);

                    // Cria um subitem para cada arquivo
                    var arquivoItem = new ToolStripMenuItem(nomeArquivo)
                    {
                        Tag = arquivo  // Armazena o caminho do arquivo
                    };

                    // Associa o evento de clique ao subitem
                    arquivoItem.Click += TemplateMenuItem_Click;

                    // Adiciona o subitem ao item da pasta
                    pastaItem.DropDownItems.Add(arquivoItem);
                }

                // Adiciona o item da pasta ao ContextMenuStrip
                contextMenuStrip1.Items.Add(pastaItem);
            }
        }

        private void AdicionarItemSair()
        {
            var sairItem = new ToolStripMenuItem("Sair")
            {
                BackColor = Color.LightCoral,
                ForeColor = Color.White
            };
            sairItem.Click += SairMenuItem_Click;

            contextMenuStrip1.Items.Add(new ToolStripSeparator());
            contextMenuStrip1.Items.Add(sairItem);
        }

        private void TemplateMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                string caminhoArquivo = menuItem.Tag.ToString();

                try
                {
                    string conteudo = File.ReadAllText(caminhoArquivo);

                    if (string.IsNullOrWhiteSpace(conteudo))
                    {
                        MessageBox.Show("Esse item está sem conteúdo, preencha o conteúdo e reinicie o software.",
                                        "Conteúdo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Clipboard.SetText(conteudo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SairMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class CustomMenuColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.LightCoral;
        public override Color MenuItemBorder => Color.Red;
    }
}
