using System;
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

            // Define o ContextMenuStrip do NotifyIcon
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarTemplates();
        }

        // Método para carregar os templates da pasta Template
        private void CarregarTemplates()
        {
            string pastaTemplate = Path.Combine(Application.StartupPath, "Template");

            // Verifica se a pasta existe
            if (!Directory.Exists(pastaTemplate))
            {
                // Cria a pasta Template caso não exista
                Directory.CreateDirectory(pastaTemplate);
                Console.WriteLine("Pasta 'Template' criada.");
            }

            // Agora tenta ler os arquivos .txt da pasta Template
            var arquivos = Directory.GetFiles(pastaTemplate, "*.txt");

            if (arquivos.Length == 0)
            {
                Console.WriteLine("Nenhum arquivo .txt encontrado na pasta 'Template'.");
                return;  // Se não houver arquivos, não faz nada
            }

            // Caso existam arquivos .txt, cria itens no menu para cada um
            foreach (var arquivo in arquivos)
            {
                // Pega o nome do arquivo sem a extensão
                string nomeTemplate = Path.GetFileNameWithoutExtension(arquivo);

                // Cria um novo item de menu para o template
                var menuItem = new ToolStripMenuItem(nomeTemplate)
                {
                    Tag = arquivo  // Armazenamos o caminho do arquivo no Tag para usá-lo posteriormente
                };

                // Associa o evento de clique
                menuItem.Click += TemplateMenuItem_Click;

                // Adiciona o item ao contexto do menu
                contextMenuStrip1.Items.Add(menuItem);
            }
        }

        // Evento de clique para os itens do menu
        private void TemplateMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                string caminhoArquivo = menuItem.Tag.ToString();

                // Lê o conteúdo do arquivo
                try
                {
                    string conteudo = File.ReadAllText(caminhoArquivo);

                    // Verifica se o conteúdo do arquivo está vazio
                    if (string.IsNullOrWhiteSpace(conteudo))
                    {
                        MessageBox.Show("Esse item está sem conteúdo, preencha o conteúdo e reinicie o software.",
                                        "Conteúdo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;  // Não faz nada, caso o conteúdo esteja vazio
                    }

                    // Caso o arquivo tenha conteúdo, coloca no Clipboard
                    Clipboard.SetText(conteudo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
