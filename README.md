# SmartCitySecurityFIAP
Projeto Aplicando Técnicas de DevOps - Capítulo 6

## Instruções para rodar o projeto

1. Clone este repositório.
2. Execute `docker-compose up --build` para subir o sistema.
3. A API estará acessível em `http://localhost:8080/api/incident` e `http://localhost:8080/api/policepatrol`.

## Funcionalidades
- Registro e gerenciamento de incidentes.
- Designação de patrulhas de segurança pública.

## Pipeline CI/CD
O pipeline CI/CD foi implementado no GitHub Actions para automatizar a compilação, testes e containerização do projeto.

## Estratégia de Containerização
Utilizamos Docker para garantir que a aplicação possa ser executada de forma consistente em qualquer ambiente. O Docker Compose orquestra os serviços da aplicação e o banco de dados MySQL.
