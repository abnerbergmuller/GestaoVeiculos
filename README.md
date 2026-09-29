# Gestão de Veículos - Sistema de Cadastro e Controle

Aplicação desktop para gestão, auditoria e controle de veículos e marcas, desenvolvida em C# e Windows Forms sobre .NET 10. O sistema segue uma arquitetura em camadas baseada em MVP (Model-View-Presenter), Repository Pattern, Factory Method e auditoria automatizada em banco de dados via triggers PL/pgSQL no PostgreSQL.

---

## Sumário

1. [Sobre o Projeto](#sobre-o-projeto)
2. [Funcionalidades Principais](#funcionalidades-principais)
3. [Tecnologias Utilizadas](#tecnologias-utilizadas)
4. [Pré-requisitos](#pré-requisitos)
5. [Configuração do Banco de Dados (PostgreSQL)](#configuração-do-banco-de-dados-postgresql)
   - [Criação e Carga via CLI (psql)](#criação-e-carga-via-cli-psql)
   - [Configuração da Connection String (`appsettings.json`)](#configuração-da-connection-string-appsettingsjson)
6. [Compilação e Execução](#compilação-e-execução)
7. [Testes Automatizados](#testes-automatizados)
8. [Decisões Técnicas e Padrões de Projeto](#decisões-técnicas-e-padrões-de-projeto)

---

## Sobre o Projeto

O Gestão de Veículos é uma aplicação desktop para gerenciamento de frotas e marcas de veículos, estruturada para manter separação de responsabilidades entre interface, regras de negócio e acesso a dados, com testabilidade das regras de negócio via mocks e auditoria completa de alterações em nível de banco de dados.

### Funcionalidades Principais

- **Gestão de Veículos**:
  - Cadastro, listagem, edição e exclusão de veículos polimórficos (`Carro` e `Moto`).
  - Associação obrigatória com marca cadastrada.
  - Validações de domínio: formato e unicidade de placa, intervalo de ano de fabricação (1950 até o ano corrente) e integridade de modelo.
  - Instanciação de tipos de veículo via Factory Method (`VeiculoFactory`).
- **Gestão de Marcas**:
  - Cadastro e listagem de marcas com garantia de unicidade de nome e validação de preenchimento.
- **Auditoria e Logs de Transação**:
  - Rastreabilidade de operações de `INSERT`, `UPDATE` e `DELETE` em veículos, gravadas automaticamente via trigger PL/pgSQL na tabela `log_transacao`.
  - Visualização do histórico de transações com data/hora e tipo de operação.
- **Rastreamento de Falhas (Logs de Erro)**:
  - Captura e persistência de exceções e erros de integridade, com data/hora, mensagem amigável, local da ocorrência, código de erro e stack trace.

---

## Tecnologias Utilizadas

| Componente | Tecnologia | Versão | Finalidade |
| :--- | :--- | :--- | :--- |
| Plataforma / Runtime | [.NET SDK](https://dotnet.microsoft.com/) | 10.0 (net10.0-windows) | Runtime e SDK base da aplicação |
| Linguagem | C# | 14 / Latest | Linguagem de programação |
| Interface Gráfica | Windows Forms (WinForms) | .NET 10 | Interface de usuário desktop |
| Banco de Dados | [PostgreSQL](https://www.postgresql.org/) | 14+ / 16+ | SGDB relacional para persistência e triggers |
| Driver / Provider | [Npgsql](https://www.nuget.org/packages/Npgsql) | 10.0.3 | Driver ADO.NET para PostgreSQL |
| ORM | [Entity Framework Core](https://learn.microsoft.com/ef/core/) | 10.0.11 | Mapeamento objeto-relacional e queries |
| Convenção de Nomes | [EFCore.NamingConventions](https://www.nuget.org/packages/EFCore.NamingConventions) | 10.0.1 | Mapeamento automático em snake_case |
| Configuração | Microsoft.Extensions.Configuration | 10.0.12 | Leitura do arquivo `appsettings.json` |
| Testes Unitários | [NUnit](https://nunit.org/) | 4.6.1 | Framework de testes unitários |
| Mocking / Test Doubles | [NSubstitute](https://nsubstitute.github.io/) | 6.2.0 | Mocks e asserções de chamadas |
| Test Runner / SDK | Microsoft.NET.Test.Sdk | 17.14.0 | Execução de testes via CLI e IDEs |

---

## Pré-requisitos

1. **Sistema Operacional**: Windows 10 (versão 1809+) ou Windows 11 (necessário para execução de aplicações Windows Forms .NET).
2. **.NET 10 SDK**:
   - Baixe e instale o [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).
   - Verifique a instalação no terminal:
     ```powershell
     dotnet --version
     # Deve exibir uma versão 10.0.xxx
     ```
3. **PostgreSQL Server (14, 15, 16 ou superior)**:
   - Servidor PostgreSQL instalado e em execução (localmente na porta padrão `5432` ou em servidor acessível).
   - Ferramenta de administração de banco de dados (`psql` via terminal ou interface gráfica `pgAdmin 4` / `DBeaver`).

---

## Configuração do Banco de Dados (PostgreSQL)

O banco de dados utiliza o script unificado DDL/DML localizado em `Database/script_criacao.sql`. Esse script cria as tabelas, constraints de unicidade e validação, a função de auditoria PL/pgSQL, a trigger e insere os registros iniciais (seed de marcas).

### Criação e Carga via CLI (`psql`)

1. Abra o terminal na raiz do projeto:
   ```powershell
   cd "C:\Projetos Pessoais\GestaoVeiculos"
   ```

2. Crie o banco de dados `gestao_veiculos`:
   ```powershell
   psql -U postgres -h localhost -p 5432 -c "CREATE DATABASE gestao_veiculos;"
   ```
   *(informe a senha do usuário `postgres` quando solicitado)*

3. Execute o script de criação e carga de dados:
   ```powershell
   psql -U postgres -h localhost -p 5432 -d gestao_veiculos -f Database/script_criacao.sql
   ```

### Configuração da Connection String (`appsettings.json`)

Verifique e ajuste, se necessário, as credenciais de acesso ao PostgreSQL em `GestaoVeiculos/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=gestao_veiculos;Username=postgres;Password=postgres"
  }
}
```

> Caso o seu PostgreSQL local utilize uma porta diferente de `5432`, outro usuário ou senha distinta de `postgres`, atualize os respectivos parâmetros em `DefaultConnection`.

---

## Compilação e Execução

1. **Restaurar dependências e compilar a solução**:
   ```powershell
   dotnet build GestaoVeiculos.slnx
   ```

2. **Executar a aplicação**:
   ```powershell
   dotnet run --project GestaoVeiculos/GestaoVeiculos.csproj
   ```

---

## Testes Automatizados

O projeto conta com testes unitários em `GestaoVeiculos.Tests`, desenvolvidos com NUnit e NSubstitute. Os testes validam as regras de negócio dos Presenters simulando a camada de visualização (`IVeiculoView`) e os repositórios (`IVeiculoRepository`, `IMarcaRepository`, `ILogRepository`) através de mocks.

### Executando os Testes via CLI

```powershell
dotnet test
```

Para uma saída detalhada, com o nome de cada teste executado:

```powershell
dotnet test --logger "console;verbosity=detailed"
```

### Cenários Cobertos

| Classe de Teste | Método / Cenário | Regra de Negócio Validada |
| :--- | :--- | :--- |
| `VeiculoPresenterTests` | `Cadastrar_AnoMenorQue1950_DeveExibirMensagemDeErro` | Veículos com ano de fabricação inferior a 1950 disparam mensagem de erro e não são persistidos. |
| `VeiculoPresenterTests` | `Cadastrar_PlacaObrigatoria_DeveExibirMensagemDeErro` | Obrigatoriedade do preenchimento da placa antes de prosseguir com o cadastro. |
| `VeiculoPresenterTests` | `Cadastrar_PlacaJaExistenteNoBanco_DeveExibirMensagemDeErro` | Violações de duplicidade de placa tratadas por `BancoException` são convertidas em mensagens amigáveis na View. |

---

## Decisões Técnicas e Padrões de Projeto

```mermaid
graph TD
    subgraph UI_Layer [Camada de Apresentação - Windows Forms]
        Views[Views / Formulários\nFrmMenuPrincipal, FrmCadastroVeiculo, FrmCadastroMarca, FrmLog]
    end

    subgraph Presenter_Layer [Camada de Apresentação / Lógica de Aplicação]
        Presenters[Presenters\nMenuPrincipalPresenter, VeiculoPresenter, MarcaPresenter, LogPresenter]
        Factory[VeiculoFactory\nCriação de Carro / Moto]
    end

    subgraph Data_Layer [Camada de Dados e Acesso a Banco]
        Repositories[Repositories\nVeiculoRepository, MarcaRepository, LogRepository]
        BancoEx[BancoException\nTradutor de Constraints Npgsql]
        DbContext[AppDbContext EF Core]
    end

    subgraph Database_Layer [PostgreSQL]
        DB[(Banco: gestao_veiculos\nmarca, veiculo, log_transacao, log_erro)]
        Trigger[Trigger: tg_veiculo_after_iud\nAuditoria automática em log_transacao]
    end

    Views <-->|Eventos / Interfaces IView| Presenters
    Presenters -->|Instanciação Polimórfica| Factory
    Presenters -->|Operações de Domínio| Repositories
    Presenters -->|Tratamento de Exceções| BancoEx
    Repositories -->|Consultas e Comandos| DbContext
    DbContext -->|Npgsql Driver| DB
    DB -->|Dispara na Inserção/Atualização/Exclusão| Trigger
```

### 1. Padrão MVP (Model-View-Presenter)
Para evitar o acoplamento comum em aplicações Windows Forms tradicionais, onde regras de negócio ficam no code-behind dos formulários, o projeto adota o padrão MVP:
- **Views**: contêm apenas componentes visuais e disparam eventos de interface (`ClickBtnCadastrar`, `ClickBtnEditar`, etc.), implementando interfaces desacopladas (`IVeiculoView`, `IMarcaView`, `ILogView`, `IMenuPrincipalView`).
- **Presenters**: concentram o fluxo de telas, chamadas aos repositórios e tratamento de retorno, recebendo as interfaces de View e Repository via injeção por construtor. Isso permite testar as regras de negócio sem depender de janelas do sistema operacional.
- **Models / DTOs**: estruturas de dados tipadas (`Veiculo`, `Carro`, `Moto`, `Marca`, `VeiculoDTO`).

### 2. Factory Method (`VeiculoFactory`)
A instanciação de tipos de veículo (`Carro` e `Moto`) é encapsulada na classe `VeiculoFactory`. O Presenter delega o tipo selecionado na View (`"Carro"` ou `"Moto"`) para a factory, facilitando a adição de novos tipos de veículo no futuro.

### 3. Repository Pattern com Entity Framework Core
O acesso a dados é isolado através de interfaces de repositório (`IVeiculoRepository`, `IMarcaRepository`, `ILogRepository`):
- O `AppDbContext` mapeia entidades para tabelas PostgreSQL usando a extensão `EFCore.NamingConventions`, mantendo nomes em snake_case compatíveis com o script SQL.
- Consultas de leitura utilizam `AsNoTracking()` para melhor performance.

### 4. Tratamento Centralizado de Constraints (`BancoException`)
Erros originados pelo PostgreSQL durante transações (violações de chave única, chave estrangeira, checks ou valores nulos) disparam `PostgresException` empacotadas em `DbUpdateException`.

A classe `BancoException` intercepta esses códigos de erro (`PostgresErrorCodes`) e retorna mensagens claras ao usuário final:
- `23505 (Unique Violation)`: identifica qual campo foi duplicado (ex.: placa já existente ou marca duplicada).
- `23514 (Check Violation)`: informa quando um valor está fora da faixa permitida (ex.: ano entre 1950 e ano atual).
- `23503 (Foreign Key Violation)`: notifica sobre registros vinculados que impedem exclusão ou chaves inválidas.
- `23502 (Not Null Violation)`: informa qual campo obrigatório não foi preenchido.
- `08001 / 08006 (Connection Exceptions)`: alerta sobre falha de comunicação com o servidor PostgreSQL.

### 5. Auditoria via Triggers PL/pgSQL
A rastreabilidade de dados é implementada diretamente no banco de dados através da trigger `tg_veiculo_after_iud` e da função `tg_fn_veiculo_auditoria()`:
- Qualquer operação de `INSERT`, `UPDATE` ou `DELETE` na tabela `veiculo` gera um registro na tabela `log_transacao`, com tipo de operação, data/hora e o identificador do veículo modificado.

### 6. Tabela `log_erro`
A tabela `log_erro` foi adicionada para persistir erros e exceções diretamente no banco, como forma de manter um histórico centralizado e consultável durante o desenvolvimento e a avaliação do projeto. Em um cenário de produção real, essa responsabilidade normalmente seria de um sistema de logging dedicado (arquivo, serviço externo, etc.).

---

Desenvolvido para avaliação técnica de desenvolvimento de software em .NET / C#.
