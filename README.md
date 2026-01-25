# Processador e Gerenciador de Comprovantes

Este projeto tem como objetivo criar uma aplicação de desktop para processar e gerenciar comprovantes de pagamento e outros tipos de documentos.

## Arquitetura

A aplicação está sendo desenvolvida seguindo os princípios da **Clean Architecture** para garantir que o código seja organizado, testável, e independente de tecnologias de UI, banco de dados ou outros serviços externos.

A solução está dividida nas seguintes camadas (projetos):

### 1. Domain (`ProcessadorComprovantes.Domain`)

O núcleo da aplicação. Contém as entidades de negócio e as regras de negócio mais puras e fundamentais.

- **Entidades:** Classes como `Comprovante`, `Usuario`, etc.
- **Regras de Negócio:** Lógica que não depende de fatores externos.
- **Não tem dependências** de outros projetos da solução.

### 2. Application (`ProcessadorComprovantes.Application`)

Contém a lógica da aplicação (casos de uso) e define as interfaces que serão implementadas pelas camadas externas.

- **Casos de Uso:** Orquestra o fluxo de dados para executar uma ação (ex: `ProcessarComprovanteUseCase`).
- **Interfaces:** Contratos para repositórios e serviços (ex: `IComprovanteRepository`, `ILeitorPdfService`).
- **Depende de:** `Domain`.

### 3. Infrastructure (`ProcessadorComprovantes.Infrastructure`)

Implementa as interfaces definidas na camada de `Application`. É aqui que a aplicação interage com o "mundo exterior".

- **Persistência:** Acesso a banco de dados (ex: com Entity Framework Core).
- **Serviços Externos:** Leitura de arquivos (PDFs, imagens), envio de e-mails, etc.
- **Depende de:** `Application`.

### 4. Presentation (`GerenciadorComprovante`)

A camada de interface com o usuário (UI).

- **UI:** Projeto Windows Forms, WPF, ou futuramente uma API Web.
- **Responsabilidade:** Apenas exibir dados e capturar a entrada do usuário, delegando toda a lógica para a camada de `Application`.
- **Depende de:** `Application`.

## Como Começar

1.  Clone o repositório.
2.  Abra a solução `ProcessadorComprovantes.slnx` no Visual Studio.
3.  Defina `GerenciadorComprovante` como projeto de inicialização.
4.  Compile e execute a aplicação.

## Próximos Passos

- [ ] Criar os projetos para as camadas `Domain`, `Application`, e `Infrastructure`.
- [ ] Mover a lógica de negócio existente para as camadas corretas.
- [ ] Implementar o acesso a banco de dados na camada de `Infrastructure`.
