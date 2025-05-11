# IA Help

<img src="https://raw.githubusercontent.com/rafaeldevelloper/Pim-IaHelp/main/UI/Resources/Logo-Pim-IaHelp.jpg" alt="Logo do IA Help" width="300"/>

**Sistema Integrado para Gestão de Chamados e Suporte Técnico Baseado em IA**

Este é um sistema de cadastro de usuários simples desenvolvido em C# com integração ao banco de dados PostgreSQL. O sistema permite o registro de novos usuários com validações de dados e prevenção de cadastros duplicados (por e-mail, nome completo e senha). A aplicação também conta com segurança na senha, com possibilidade de hashing para armazená-las de forma segura.

## Funcionalidades

- **Cadastro de Usuários**: Permite que novos usuários se cadastrem no sistema com nome completo, e-mail, senha e data de nascimento.
- **Validação de Dados**: O sistema valida campos obrigatórios e checa se os dados fornecidos são válidos, como e-mail e senha.
- **Prevenção de Dados Duplicados**: Antes de inserir um novo usuário, o sistema verifica se já existe um cadastro com o mesmo nome completo, e-mail ou senha.
- **Erro de Cadastro**: Caso os dados já estejam cadastrados, o sistema retorna uma mensagem de erro e limpa os campos para o usuário tentar novamente.
- **Banco de Dados**: Utiliza PostgreSQL para armazenar os dados dos usuários, com tabelas e relacionamento simples.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação principal para a construção da aplicação.
- **PostgreSQL**: Banco de dados relacional para armazenamento dos dados.
- **Windows Forms**: Interface gráfica para interação com o usuário.
- **Regex**: Validação de e-mail usando expressões regulares.

## Instalação

### Pré-requisitos

- .NET Framework (Recomenda-se a versão 4.7 ou superior)
- PostgreSQL instalado e configurado
- Visual Studio ou IDE compatível com C#

### Passos para Configuração

1. Clone este repositório para sua máquina local:

    ```bash
    git clone https://github.com/seu-usuario/sistema-cadastro-usuarios.git
    ```

2. Abra o projeto no Visual Studio ou sua IDE de preferência.

3. No arquivo `ConectionBD.cs`, configure a string de conexão com o banco de dados PostgreSQL:

    ```csharp
    private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=sua-senha;Database=bd-iahelp";
    ```

4. Certifique-se de que a tabela de usuários no PostgreSQL já foi criada e contém os campos adequados, ou use o seguinte script para criar:

    ```sql
    CREATE TABLE usuarios (
        id SERIAL PRIMARY KEY,
        nome_completo VARCHAR(255) NOT NULL,
        email VARCHAR(255) UNIQUE NOT NULL,
        senha VARCHAR(255) NOT NULL,
        data_nascimento DATE NOT NULL
    );
    ```

5. Compile e execute o projeto.

## Uso

1. Abra a aplicação.
2. Preencha os campos no formulário de cadastro (nome completo, e-mail, senha, confirmação de senha e data de nascimento).
3. Clique em **"Cadastrar"** para tentar registrar o usuário.
4. Caso o e-mail já esteja registrado, ou qualquer outro dado esteja duplicado, o sistema exibirá uma mensagem de erro e limpará os campos.
5. Caso o cadastro seja bem-sucedido, o sistema mostrará uma mensagem de sucesso.

## Contribuições

Contribuições são bem-vindas! Se você tiver alguma sugestão, correção ou melhoria para o projeto, sinta-se à vontade para abrir uma *issue* ou enviar um *pull request*.

## Licença

Distribuído sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
