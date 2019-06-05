# movie-review-blog-api

## Requisitos:
.Net Core SDK 2.2
https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.107-windows-x64-installer

## Restaurar dependências e compilar o projeto
Na raiz do projeto, rodar os seguintes comandos no terminal:
-dotnet restore
-dotnet build

## Adicionar os dados gerados pelo mockaroo ao banco local do sqlite
Navegar para a pasta /Console.MockarooReader e rodar o seguinte comando no terminal:
-dotnet run
Essa sequência de frases indica sucesso:
-Running mockaroo file handler...
-Done inserting data...

## Configurando o arquivo .env
O .env deve ser colocado na raiz do projeto, junto com o .gitignore e o arquivo .sln.
O arquivo .example.env já possui as chaves, é só colocar os valores em um novo arquivo chamado .env.

Exemplo de .env:
-omdb_api=http://www.omdbapi.com
-omdb_api_key=929292929

OBS: o valor da chave omdb_api deve ser igual ao exemplo.

A sua chave deve ser adquirida no próprio site da omdb: http://www.omdbapi.com/apikey.aspx

## Rodar a API
Navegue para a pasta do projeto API e rode o seguinte comando no terminal:
-dotnet run

Antes de consumir as rotas pelo POSTMAN, certifique-se de desligar a opção SSL certificate verification nas configurações.

## Swagger

https://localhost:5001/swagger/index.html

## Consumindo as rotas
GET http://localhost:5000/posts => retornar todos os posts
GET http://localhost:5000/posts/{id} => retorna um post por ID
POST http://localhost:5000/posts => cria um post
PUT http://localhost:5000/{id} => atualiza um post por id
DELETE http://localhost:5000/{id} => deleta um post por id