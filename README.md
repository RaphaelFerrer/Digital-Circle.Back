# Digital-Circle.Back

Este projeto é uma aplicação de gerenciamento de entidades que permite listar, incluir, excluir e atualizar registros usando .NET 7 e SQLite como banco de dados.

## Requisitos

- .NET 7 SDK instalado (https://dotnet.microsoft.com/download/dotnet/7.0)
- SQLite

## Instalação

1. Clone este repositório para o seu ambiente de desenvolvimento:

   ```shell
   git clone https://github.com/RaphaelFerrer/Digital-Circle.Back.git
   cd seu-projeto
Instale as dependências do projeto:

shell
Copy code
dotnet restore
Configure o banco de dados SQLite (caso ainda não esteja configurado):

shell
Copy code
dotnet ef migrations add Inicial
dotnet ef database update
Uso
Inicie a aplicação:

shell
Copy code
dotnet run
Abra um navegador ou ferramenta de API (por exemplo, Postman) e acesse http://localhost:5000.

Você pode realizar as seguintes ações:

Listar todas as entidades.
Incluir uma nova entidade.
Excluir uma entidade existente.
Atualizar os detalhes de uma entidade.





