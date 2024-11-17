namespace TemplatesQA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taskKanbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugKanbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateSDTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesMRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryParaTestesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringQAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // taskKanbanToolStripMenuItem
            // 
            this.taskKanbanToolStripMenuItem.Name = "taskKanbanToolStripMenuItem";
            this.taskKanbanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taskKanbanToolStripMenuItem.Text = "Task Kanban";
            // 
            // bugKanbanToolStripMenuItem
            // 
            this.bugKanbanToolStripMenuItem.Name = "bugKanbanToolStripMenuItem";
            this.bugKanbanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bugKanbanToolStripMenuItem.Text = "Bug Kanban";
            // 
            // templateSDTitleToolStripMenuItem
            // 
            this.templateSDTitleToolStripMenuItem.Name = "templateSDTitleToolStripMenuItem";
            this.templateSDTitleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.templateSDTitleToolStripMenuItem.Text = "Título Service Desk";
            // 
            // testesMRToolStripMenuItem
            // 
            this.testesMRToolStripMenuItem.Name = "testesMRToolStripMenuItem";
            this.testesMRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testesMRToolStripMenuItem.Text = "Testes MR";
            // 
            // queryParaTestesToolStripMenuItem
            // 
            this.queryParaTestesToolStripMenuItem.Name = "queryParaTestesToolStripMenuItem";
            this.queryParaTestesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryParaTestesToolStripMenuItem.Text = "Query para testes";
            // 
            // stringQAToolStripMenuItem
            // 
            this.stringQAToolStripMenuItem.Name = "stringQAToolStripMenuItem";
            this.stringQAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stringQAToolStripMenuItem.Text = "String QA";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 74);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TemplatesQA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taskKanbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugKanbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateSDTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testesMRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryParaTestesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringQAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

