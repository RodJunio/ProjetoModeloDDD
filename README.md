# Sobre o Projeto
Este projeto foi inspirado no vídeo do Eduardo Pires sobre DDD, IoC, Automapper. [Link](https://www.eduardopires.net.br/2014/10/tutorial-asp-net-mvc-5-ddd-ef-automapper-ioc-dicas-e-truques/)

Como principais atualizações, temos a adoção do .NET Core Simple Injector.

# Modelo DDD
![ddd1](https://github.com/RodJunio/ProjetoModeloDDD/assets/90984407/1b11d24d-9013-4f45-921b-5da84f0bef40)
## Tecnologias 
- DDD;
- Repositório Genérico e Especializado;
- Migrations/Code-First;
- FluentAPI;
- Automapper
- IoC e DI, utilizando SimpleInjector;
- ASP.NET MVC Core 2.0
- .NET Standard 2.0

# Possiveis Melhorias
- Refactoring do código;
- Utilização de programação funcional em pontos determinados da aplicação
- Projeto de Testes Unitários
- Retirar dependência da camada de repositório do projeto MVC
- Utilização do FluentValidation para a validação das entidades de domínio
- Correção/refactoring dos Produtos
- Criar um projeto de CrossCutting->IoC, objetivando retirar a dependência da camada de Front (MVC) do repositório.
