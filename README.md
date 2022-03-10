# Gerenciamento de TODO's
API .NET CORE para gerenciamento de tarefas, um crud criado em DDD (Domain Driven Design) com sua arquitetura em camadas, utilizado injeção de dependencias e repositories.

# API

API para gerenciamento de tarefas.
Com esta ferramenta é possível listar, criar, alterar e excluir tarefas.


## Configurando ambiente
Necessário - SDK 5.0

Para começar a usar a API, será necessário setar o projeto ToDo.API para iniciar(Caso iniciado no Visual Studio), como a imagem:

![image](https://user-images.githubusercontent.com/74919534/157563466-4c1b88f5-fa9b-4872-a994-c4880cbde8b3.png)

Feito isto basta iniciar a aplicação!

A API possui Swagger então cada EndPoint está devidamente Documentado:

![image](https://user-images.githubusercontent.com/74919534/157568316-f9cbb54b-2ba1-441d-9382-a4552d4b0191.png)


## Banco de dados
O Banco de dados(SQLite) será criado automaticamente após acessar qualquer EndPoint da aplicação, dentro da pasta "Bank" um arquivo .db do banco de dados será criado a partir dos atributos da model colocada na pasta de models.

## Opções da API

- [ ] Listar tarefas
- [ ] Adicionar novas tarefas
- [ ] Atualizar tarefas
- [ ] Excluir tarefas

## Autor:
  - Jonathan William Scrok
