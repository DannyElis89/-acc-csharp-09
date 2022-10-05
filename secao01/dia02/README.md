# Aceleração em C#
## C# - do zero ao deploy
### Dia 02:  Hello, World' no C# em uma aplicação de Console!

#### Criação de um projeto para console:
  ~~~shell
  dotnet new console -o <nome da pasta>
  dotnet new console -o HelloWorld
  ~~~
#### A estrutura de um projeto para console

* `Program.cs`:
  * Arquivo que possui o cod. em CS (C Sharp);

* `<nomeDoProjeto>.csproj`:
  * Arquivo de projeto e a base de configuração para projetos `.NET`;
  * Infos sobre dependências, bibliotecas e dependências de terceiros são utilizadas, requisitos da plataforma, informações de controle da versão, configurações do servidor, etc.
  * Semelhante ao `package.json` do `javascript` com `NPM`;

* `Pasta obj/`:
  * Pasta que recebe as dependências do projeto após rodar o comando `dotnet restore`. Este comando é semelhante, em termos de funcionalidade, ao comando npm install dentro dos projetos Javascript com NodeJS e NPM.
