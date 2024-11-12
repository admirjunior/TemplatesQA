using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void templateSDTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(@"[Service Desk 00/00/00 00:00] BACK - xxxxxxxxxxx");
        }

        private void taskKanbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(@"Descrição:

Insira uma descrição clara e concisa da tarefa.

Critério de aceitação 

Descreva o que se espera que aconteça nesse cenário.

Observações

Qualquer informação adicional, notas ou observações relevantes podem ser registradas aqui. ");
        }

        private void bugKanbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(@"Descrição:

Insira uma descrição clara e concisa da tarefa.

Como reproduzir

Descreva os passos necessários para reproduzir o caso.

Ambiente de Simulação (se aplicável):

URL: [URL do ambiente de simulação]
Login: [Nome de usuário ou e-mail]
Senha: [Senha de acesso]

Resultado Esperado 

Descreva o que se espera que aconteça nesse cenário.

Resultado Obtido

Descreva o cenário atual, ou seja, o resultado que ocorreu ou ocorre atualmente em ambientes internos ou em clientes.

Observações

Qualquer informação adicional, notas ou observações relevantes podem ser registradas aqui. Caso haja evidências anexos sinalizar aqui.");
        }

        private void testesMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(@"## Evidências dos Testes

- Imagens, gifs ou vídeos aqui!

### Checklists

- [ ] Todos os testes passaram.
- [ ] Critérios do Kanban.
- [ ] Foram abordados todos os casos de teste.
- [ ] Não há erros ou problemas visíveis nas evidências.
- [ ] Não há erros registrado nos logs.


### Observações

N/A

");
        }

        private void queryParaTestesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(@"SELECT
		U.NMUSER,
		
		-- Campos adicionais da tabela ADALLUSERS
		U.DTINSERT,
		U.CDLEADER,
		U.DSUSEREMAIL,
		'#{305178}' as CAMPO_TERMO,

		-- Exemplos de CASE WHEN 
		CASE
			WHEN 1 = 1 THEN 'Always True'
			ELSE 'Always False'
		END AS AlwaysTrueColumn,

		-- Exemplo de CASE WHEN 
		CASE
			WHEN 2 + 2 = 4 THEN 'Math Works'
			ELSE 'Math Fails'
		END AS MathTestColumn,

		-- Exemplo de CASE WHEN 
		CASE
			WHEN 5 > 3 THEN 'Greater'
			ELSE 'Smaller'
		END AS ComparisonColumn,

		-- Exemplo de CASE WHEN 
		CASE
			WHEN 'A' = 'A' THEN 'Same Letter'
			ELSE 'Different Letter'
		END AS LetterTestColumn,

		-- Exemplo de CASE WHEN 
		CASE
			WHEN 10 / 2 = 5 THEN 'Even Division'  -- Usando divisão
			ELSE 'Odd Division'
		END AS DivisionTestColumn,

		-- Campos para validar datatypes
		CAST(1 AS INTEGER) AS TestIntColumn,                     -- Inteiro
		CURRENT_TIMESTAMP AS TestTimestampColumn                 -- Timestamp

		FROM
			ADALLUSERS U
		INNER JOIN
			ADUSERDEPTPOS A ON U.CDUSER = A.CDUSER
		INNER JOIN
			ADDEPARTMENT D ON A.CDDEPARTMENT = D.CDDEPARTMENT AND A.FGDEFAULTDEPTPOS = 1
		INNER JOIN
			ADPOSITION P ON A.CDPOSITION = P.CDPOSITION	");
        }

        private void stringQAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(@"5456_àáâãçäü!@#$%¨&*()+abc=ab_ab-abc¹²³£¢¬abc€ab'c\""ab{}teste[].d,aîîïèø£åbæºcª§¶¾µ°100");
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
