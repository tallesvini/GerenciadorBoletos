# Boleto/Banco - Api

Este projeto foi desenvolvido em .NET Core e PostgreSQL, projetado como um sistema de boletos e bancos.

## Configura��o

Certifique-se de ter o [.NET Core SDK](https://dotnet.microsoft.com/download) e o [SQL Oracle](https://www.oracle.com/br/database/sqldeveloper/) instalado em sua m�quina.

1. Clone este reposit�rio:

   ```
   https://github.com/tallesvini/gerenciador-boletos.git
   ```

2. Acesse o diret�rio do projeto:

   ```
   cd nome-do-repositorio
   ```

3. Abra o arquivo `appsettings.json` dentro do projeto `BoletoProject.WebApi` e configure as informa��es de conex�o com o seu banco de dados PostgreSQL:

   ```json
      "ConnectionStrings": {
         "DefaultConnection": "User ID=USER;Password=PASSWORD;Host=HOST;Port=PORT;Database=NAME_DB;"
      }
   ```

4. Execute as migra��es para criar as tabelas no banco de dados:

    - Abra o `Console do Gerenciador de Pacotes`.
    - No campo `Projeto padr�o`, selecione o projeto `BoletoProject.Infra.Data`.
    - Por fim, execute o comando abaixo:
        ```
        update-database
        ```

5. Inicie o servidor:

    - No [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/), rode localmente seu projeto (seja ele via IIS ou HTTP)

## Requisitos de Sistema

- .NET Core SDK 6 ou superior.

## Como Contribuir

Se voc� deseja contribuir para este projeto, siga as etapas abaixo:

1. Fa�a um fork deste reposit�rio e clone-o em sua m�quina local.
2. Crie um novo branch para suas altera��es: `git checkout -b minha-branch`.
3. Realize as altera��es desejadas e commit-as: `git commit -m 'Minhas altera��es'`.
4. Envie suas altera��es para o branch principal do reposit�rio forkado: `git push origin minha-branch`.
5. Abra um pull request no reposit�rio original, descrevendo as altera��es propostas.

## Licen�a

Este projeto est� licenciado sob a **MIT License**.
# Boleto/Banco - Api

Este projeto foi desenvolvido em .NET Core e PostgreSQL, projetado como um sistema de boletos e bancos.

## Configura��o

Certifique-se de ter o [.NET Core SDK](https://dotnet.microsoft.com/download) e o [SQL Oracle](https://www.oracle.com/br/database/sqldeveloper/) instalado em sua m�quina.

1. Clone este reposit�rio:

   ```
   https://github.com/tallesvini/gerenciador-boletos.git
   ```

2. Acesse o diret�rio do projeto:

   ```
   cd nome-do-repositorio
   ```

3. Abra o arquivo `appsettings.json` dentro do projeto `BoletoProject.WebApi` e configure as informa��es de conex�o com o seu banco de dados PostgreSQL:

   ```json
      "ConnectionStrings": {
         "DefaultConnection": "User ID=USER;Password=PASSWORD;Host=HOST;Port=PORT;Database=NAME_DB;"
      }
   ```

4. Execute as migra��es para criar as tabelas no banco de dados:

    - Abra o `Console do Gerenciador de Pacotes`.
    - No campo `Projeto padr�o`, selecione o projeto `BoletoProject.Infra.Data`.
    - Por fim, execute o comando abaixo:
        ```
        update-database
        ```

5. Inicie o servidor:

    - No [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/), rode localmente seu projeto (seja ele via IIS ou HTTP)

## Requisitos de Sistema

- .NET Core SDK 6 ou superior.

## Como Contribuir

Se voc� deseja contribuir para este projeto, siga as etapas abaixo:

1. Fa�a um fork deste reposit�rio e clone-o em sua m�quina local.
2. Crie um novo branch para suas altera��es: `git checkout -b minha-branch`.
3. Realize as altera��es desejadas e commit-as: `git commit -m 'Minhas altera��es'`.
4. Envie suas altera��es para o branch principal do reposit�rio forkado: `git push origin minha-branch`.
5. Abra um pull request no reposit�rio original, descrevendo as altera��es propostas.

## Licen�a

Este projeto est� licenciado sob a **MIT License**.
# Boleto/Banco - Api

Este projeto foi desenvolvido em .NET Core e PostgreSQL, projetado como um sistema de boletos e bancos.

## Configura��o

Certifique-se de ter o [.NET Core SDK](https://dotnet.microsoft.com/download) e o [SQL Oracle](https://www.oracle.com/br/database/sqldeveloper/) instalado em sua m�quina.

1. Clone este reposit�rio:

   ```
   https://github.com/tallesvini/gerenciador-boletos.git
   ```

2. Acesse o diret�rio do projeto:

   ```
   cd nome-do-repositorio
   ```

3. Abra o arquivo `appsettings.json` dentro do projeto `BoletoProject.WebApi` e configure as informa��es de conex�o com o seu banco de dados PostgreSQL:

   ```json
      "ConnectionStrings": {
         "DefaultConnection": "User ID=USER;Password=PASSWORD;Host=HOST;Port=PORT;Database=NAME_DB;"
      }
   ```

4. Execute as migra��es para criar as tabelas no banco de dados:

    - Abra o `Console do Gerenciador de Pacotes`.
    - No campo `Projeto padr�o`, selecione o projeto `BoletoProject.Infra.Data`.
    - Por fim, execute o comando abaixo:
        ```
        update-database
        ```

5. Inicie o servidor:

    - No [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/), rode localmente seu projeto (seja ele via IIS ou HTTP)

## Requisitos de Sistema

- .NET Core SDK 6 ou superior.

## Como Contribuir

Se voc� deseja contribuir para este projeto, siga as etapas abaixo:

1. Fa�a um fork deste reposit�rio e clone-o em sua m�quina local.
2. Crie um novo branch para suas altera��es: `git checkout -b minha-branch`.
3. Realize as altera��es desejadas e commit-as: `git commit -m 'Minhas altera��es'`.
4. Envie suas altera��es para o branch principal do reposit�rio forkado: `git push origin minha-branch`.
5. Abra um pull request no reposit�rio original, descrevendo as altera��es propostas.

## Licen�a

Este projeto est� licenciado sob a **MIT License**.
