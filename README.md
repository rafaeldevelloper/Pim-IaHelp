# 📄 Guia do Back-End — IA Help

![Logo do IA Help](https://github.com/rafaeldevelloper/Pim-IaHelp/blob/master/UI/Resources/Logo-Pim-IaHelp.jpg)

## O que é o Back-End do IA Help?

O Back-End é a parte “invisível” do sistema **IA Help**, onde acontece toda a lógica por trás das telas. É ele que recebe as informações que o usuário digita, confere se está tudo certo, e salva no banco de dados de forma segura. Além disso, cuida do registro de chamados para suporte técnico.

Esse sistema foi feito com **C#** e usa o banco de dados **PostgreSQL** para armazenar as informações.

---

## Como o sistema funciona por trás?

O IA Help foi dividido em três partes principais:

- **Interface (UI)**: onde o usuário vê e interage (feita com **Windows Forms**).
- **Lógica do sistema**: onde ficam as regras — como validar dados e decidir o que pode ou não ser salvo.
- **Banco de Dados**: onde as informações ficam guardadas de forma organizada e segura.

---

## O que o Back-End faz?

### ✅ Cadastro de Usuários

- Recebe dados como nome, e-mail, senha e data de nascimento.
- Verifica se:
  - Todos os campos foram preenchidos.
  - O e-mail está no formato correto.
  - Não existe outro usuário com o mesmo nome, e-mail ou senha (evita cadastros duplicados).
- Se tudo estiver certo, salva os dados no banco.

---

### ✅ Validações importantes

Antes de guardar qualquer coisa, o sistema confere:

- Se os campos obrigatórios foram preenchidos.
- Se o e-mail segue um formato válido (exemplo: nome@dominio.com).
- Se não há outro cadastro com os mesmos dados.

---

### ✅ Segurança

- Recomendamos guardar as senhas de forma protegida, usando **hash** (hoje, o sistema aceita, mas ainda não implementa isso por padrão).
- Usa formas de evitar ataques como **SQL Injection** ao trabalhar com comandos seguros no banco.

---

### ✅ Chamados de Suporte

O sistema também permite cadastrar **chamados**. Isso inclui:

- Quem está relatando o problema.
- Qual setor e tipo de problema.
- Qual a prioridade.
- E todos os detalhes importantes.

**Obs.:** hoje o foco está no cadastro, mas a ideia é expandir para um controle completo (CRUD).

---

## Como o banco de dados está organizado?

O sistema usa duas tabelas principais no **PostgreSQL**:

### 🗃️ Tabela de Usuários (`usuarios`)

| Campo             | Tipo de dado |
| ----------------- | ------------ |
| id                | Número único (chave primária) |
| nome_completo     | Texto |
| email             | Texto (não pode repetir) |
| senha             | Texto |
| data_nascimento   | Data |

---

### 🗃️ Tabela de Chamados (`chamados`)

| Campo               | Tipo de dado |
| ------------------- | ------------ |
| id                  | Número único (chave primária) |
| nome_usuario        | Texto |
| setor_problema      | Texto |
| tipo_problema       | Texto |
| prioridade_problema | Texto |
| detalhes_problema   | Texto longo |

---

## O que usamos para fazer isso acontecer?

- **C#**: a linguagem que usamos para programar.
- **PostgreSQL**: onde guardamos todos os dados.
- **Npgsql**: biblioteca que faz a ponte entre C# e o banco.
- **Regex**: ajuda a verificar se o e-mail está bem escrito.
- **Windows Forms**: onde criamos as janelas e formulários do sistema.

---

## Como o processo acontece passo a passo?

1. O usuário preenche as informações.
2. O sistema valida e verifica se já existe um cadastro igual.
3. Se estiver tudo certo, salva no banco.
4. O sistema avisa se deu tudo certo ou se teve algum erro.

---

## Como configurar a conexão com o banco?

Dentro do código, no arquivo `ConectionBD.cs`, tem esta configuração:

```csharp
private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=sua-senha;Database=bd-iahelp";
