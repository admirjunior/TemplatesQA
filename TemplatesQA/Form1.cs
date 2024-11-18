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

            // Associa o evento de renderização personalizada
            contextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomMenuColorTable());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarTemplates();
            AdicionarItemSair(); // Adiciona o item fixo "Sair"
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
            // Cria o item fixo "Sair"
            var sairItem = new ToolStripMenuItem("Sair")
            {
                BackColor = Color.LightCoral, // Define a cor de fundo vermelha suave
                ForeColor = Color.White       // Define a cor do texto como branco
            };
            sairItem.Click += SairMenuItem_Click;

            // Adiciona o item "Sair" ao final do menu
            contextMenuStrip1.Items.Add(new ToolStripSeparator()); // Adiciona um separador antes de "Sair"
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

    // Classe personalizada para alterar cores do ContextMenuStrip
    public class CustomMenuColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.LightCoral;  // Cor ao passar o mouse
        public override Color MenuItemBorder => Color.Red;           // Borda do item ao passar o mouse
    }
}
