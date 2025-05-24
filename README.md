# 📄 Documentação do Back-End — IA Help

![Logo do IA Help](https://github.com/rafaeldevelloper/Pim-IaHelp/blob/master/UI/Resources/Logo-Pim-IaHelp.jpg)

## Visão Geral

O **Back-End** do sistema **IA Help** é responsável por implementar toda a lógica de negócios referente ao cadastro, validação e persistência de usuários, bem como a estrutura de dados relacionada aos chamados de suporte técnico. Desenvolvido em **C#** com arquitetura simples, o sistema estabelece uma comunicação eficiente com o banco de dados **PostgreSQL**, garantindo segurança, integridade e confiabilidade das informações.

## Arquitetura e Estrutura

O sistema segue um modelo monolítico baseado em **camadas** lógicas:

- **Camada de Apresentação (UI)**: Interface construída com **Windows Forms**, responsável pela interação com o usuário.
- **Camada de Lógica de Negócios**: Implementada em C#, é responsável pelas validações, regras de negócio e manipulação de dados.
- **Camada de Persistência**: Realiza a comunicação direta com o banco de dados PostgreSQL, executando comandos de inserção, consulta e validação de registros.

## Principais Funcionalidades do Back-End

### 1. Cadastro de Usuários

- Recebe dados de entrada (nome completo, e-mail, senha, data de nascimento).
- Realiza validações:
  - Campos obrigatórios.
  - Formato de e-mail utilizando **expressões regulares** (Regex).
  - Verificação de unicidade (nome completo, e-mail e senha) para evitar registros duplicados.
- Caso os dados sejam válidos e únicos, realiza a inserção no banco de dados.

### 2. Validação e Tratamento de Dados

- **Validação de Campos**: Garantia de que nenhum campo obrigatório seja deixado em branco.
- **Validação de E-mail**: Expressão regular que assegura o padrão correto.
- **Validação de Duplicatas**: Consulta prévia ao banco para verificar se já existe usuário com o mesmo e-mail, nome ou senha.

### 3. Segurança

- Implementação opcional de **hashing de senhas** (recomendado para produção), evitando o armazenamento de senhas em texto puro.
- Prevenção de **SQL Injection** através da utilização de comandos parametrizados.

### 4. Manipulação de Chamados

- Modelagem e inserção de registros na tabela **`chamados`**:
  - Armazenamento de informações como usuário solicitante, setor, tipo, prioridade e detalhes do problema.
- Possibilita futura extensão para CRUD completo de chamados.

## Estrutura do Banco de Dados

O sistema utiliza o **PostgreSQL** como Sistema Gerenciador de Banco de Dados Relacional (SGBDR), com duas principais tabelas:

### Tabela: `usuarios`

| Campo             | Tipo         | Restrições           |
| ----------------- | ------------ | -------------------- |
| id                | SERIAL       | PRIMARY KEY          |
| nome_completo     | VARCHAR(255) | NOT NULL             |
| email             | VARCHAR(255) | UNIQUE, NOT NULL     |
| senha             | VARCHAR(255) | NOT NULL             |
| data_nascimento   | DATE         | NOT NULL             |

### Tabela: `chamados`

| Campo               | Tipo         | Restrições           |
| ------------------- | ------------ | -------------------- |
| id                  | SERIAL       | PRIMARY KEY          |
| nome_usuario        | VARCHAR(100) | NOT NULL             |
| setor_problema      | VARCHAR(100) | NOT NULL             |
| tipo_problema       | VARCHAR(100) | NOT NULL             |
| prioridade_problema | VARCHAR(50)  | NOT NULL             |
| detalhes_problema   | TEXT         | NOT NULL             |

## Tecnologias e Ferramentas

- **C#**: Linguagem de desenvolvimento Back-End.
- **Npgsql**: Biblioteca para conexão entre C# e PostgreSQL.
- **PostgreSQL**: Banco de dados relacional.
- **Regex**: Para validação de e-mails.
- **Windows Forms**: Utilizado apenas para interface, mas integrado ao fluxo de Back-End.

## Fluxo de Processamento

1. **Recepção de Dados** → Usuário insere as informações.
2. **Validação** → Sistema valida o formato e unicidade dos dados.
3. **Persistência** → Caso válido, insere no banco de dados.
4. **Resposta ao Usuário** → Feedback de sucesso ou erro.

## Configuração da Conexão com o Banco de Dados

Arquivo: `ConectionBD.cs`

```csharp
private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=sua-senha;Database=bd-iahelp";
