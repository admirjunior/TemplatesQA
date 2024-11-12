### TemplatesQA
TemplatesQA é uma aplicação Windows Forms em C# desenvolvida para facilitar o uso de templates pré-definidos em tarefas rotineiras de cadastro no Kanban e em Merge Requests (MRs), além de incluir consultas SQL para testes e strings com caracteres especiais para casos específicos. Esta ferramenta visa agilizar o processo de trabalho, permitindo copiar diferentes tipos de templates para a área de transferência com apenas um clique.

### Como Utilizar
Ao iniciar o software, ele é minimizado automaticamente na bandeja do sistema (área de notificações).
Clique com o botão direito no ícone do programa na bandeja para abrir o menu e acessar as diferentes opções de templates disponíveis.
Selecionar uma das opções irá copiar automaticamente o conteúdo correspondente para a área de transferência, permitindo colá-lo onde necessário.

#### Estrutura de Código
##### Componentes Principais
NotifyIcon com ContextMenuStrip: O ícone do programa na bandeja do sistema, com um menu de contexto para acessar os templates e opções.
Métodos de Templates (templateSDTitleToolStripMenuItem_Click, taskKanbanToolStripMenuItem_Click, bugKanbanToolStripMenuItem_Click, testesMRToolStripMenuItem_Click, queryParaTestesToolStripMenuItem_Click, stringQAToolStripMenuItem_Click): Cada um desses métodos é responsável por copiar um template específico para a área de transferência.
sairToolStripMenuItem_Click: Método que finaliza a aplicação.
Requisitos
.NET Framework 4.5 ou superior.
Visual Studio (para editar o código-fonte, se necessário).

#### Contribuição
Se desejar contribuir com melhorias, sinta-se à vontade para enviar pull requests ou abrir issues.
