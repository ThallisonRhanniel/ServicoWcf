# Serviço Windows WCF

Serviço responsável por validar informações e retornar os dados encontrados

### Pré-requisitos

Sinta-se livre para baixar ou clonar o código:

```
git@github.com:ThallisonRhanniel/ServicoWcf.git
```
Antes de iniciar o projeto, por favor instale:

**Para visualização dos dados é necessário um Sistema Web. [Clique Aqui](https://github.com/ThallisonRhanniel/ValidadorHashPHP) para saber mais.**

Ao instalar o MySql marque todas opções relacionadas a .NET e Visual Studio:

[MySql](https://dev.mysql.com/get/Downloads/MySQLInstaller/mysql-installer-web-community-5.7.19.0.msi)

```
https://dev.mysql.com
```
Caso queira baixar as depedências separadamente:

* [Connector/NET](https://dev.mysql.com/downloads/file/?id=463758)
* [MySQL for Visual Studio](https://dev.mysql.com/downloads/file/?id=469617)


```
  * https://dev.mysql.com/downloads/connector/net/

  * https://dev.mysql.com/downloads/windows/visualstudio/
```
Instale o EntityFramework no projeto:

[EntityFramework](https://www.nuget.org/packages/entityframework/)

```
  * Install-Package EntityFramework
```

### Instalando

No MyQql Workbench crie uma tabela. Criei uma com o nome **dados**

![Criar Banco](https://raw.githubusercontent.com/ThallisonRhanniel/ServicoWcf/master/Screenshot/criarBanco.png)

Para usar o banco utilize a Query: **use nomeBanco;**
```sql
use dados;
```
Utilize esse comando para evitar futuros erros com o Entity Framework:

```sql
set global optimizer_switch='derived_merge=OFF';
```
Criaremos uma tabela no banco com nome de **pessoas**:

```sql
create table pessoas (
id int auto_increment NOT NULL,
primary key(id) ,
idHash int NOT NULL,
valorHash varchar(100) NOT NULL,
nome varchar(30) NOT NULL
);
```
Insira esses dados iniciais:

```sql
INSERT INTO pessoas(id, idHash, valorHash, nome)
VALUES (null, '985412', 'f5d1278e8109edd94e1e4197e04873b9', 'Miguel');

INSERT INTO pessoas(id, idHash, valorHash, nome)
VALUES (null, '354712', 'a5d1abc2e8109ed54e1e4197e04873b9', 'Davi');

INSERT INTO pessoas(id, idHash, valorHash, nome)
VALUES (null, '488912', 'b5d1278e8109edd94e1e4197e04111b9', 'Arthur');

INSERT INTO pessoas(id, idHash, valorHash, nome)
VALUES (null, '425012', 'bc41278e8109edd94e1e4197e04111b9', 'Pedro');

INSERT INTO pessoas(id, idHash, valorHash, nome)
VALUES (null, '951912', 'df141278817532d94e1e4197e04111b9', 'Sophia');

INSERT INTO pessoas(id, idHash, valorHash, nome)
VALUES (null, '852912', '945avc8e8109edd94e1e4197e04111b9', 'Alice');

INSERT INTO pessoas(id, idHash, valorHash, nome)
VALUES (null, '456912', '7943188e8109edd94e1e4197e04111b9', 'Isabela');
```
Caso prefira fazer em **C#**:

```C#

Dados db = new Dados();

db.pessoas.Add(new pessoas()
{
    idHash = 985412,
    valorHash = "f5d1278e8109edd94e1e4197e04873b9",
    nome = "Miguel"
});

db.pessoas.Add(new pessoas()
{
    idHash = 354712,
    valorHash = "a5d1abc2e8109ed54e1e4197e04873b9",
    nome = "Davi"
});

db.pessoas.Add(new pessoas()
{
    idHash = 488912,
    valorHash = "b5d1278e8109edd94e1e4197e04111b9",
    nome = "Arthur"
});

db.pessoas.Add(new pessoas()
{
    idHash = 425012,
    valorHash = "bc41278e8109edd94e1e4197e04111b9",
    nome = "Pedro"
});

db.pessoas.Add(new pessoas()
{
    idHash = 951912,
    valorHash = "df141278817532d94e1e4197e04111b9",
    nome = "Sophia"
});

db.pessoas.Add(new pessoas()
{
    idHash = 852912,
    valorHash = "945avc8e8109edd94e1e4197e04111b9",
    nome = "Alice"
});

db.pessoas.Add(new pessoas()
{
    idHash = 456912,
    valorHash = "7943188e8109edd94e1e4197e04111b9",
    nome = "Isabela"
});

db.SaveChanges();
```

Verifique o arquivo **Web.config** seu **usuario** e **senha**:

```xml
connectionString="server=localhost;user id=root;password=suasenha123;persistsecurityinfo=True;database=dados" providerName="MySql.Data.MySqlClient" />
```

## Como usar

Como estamos trabalhando em **localhost** basta iniciar o projeto:

![Iniciar Projeto](https://raw.githubusercontent.com/ThallisonRhanniel/ServicoWcf/master/Screenshot/iniciarProjeto.png)

## Resultado

![Resultado](https://raw.githubusercontent.com/ThallisonRhanniel/ServicoWcf/master/Screenshot/resultadoProjeto.png)


