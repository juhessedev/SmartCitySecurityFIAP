Feature: Cadastro de Ocorrências
  Como um usuário
  Quero cadastrar uma ocorrência
  Para que ela seja registrada no sistema

Scenario: Cadastro de ocorrência com sucesso
  Given que estou na página de cadastro de ocorrências
  When preencho todos os campos obrigatórios corretamente
  And clico em "Enviar"
  Then a ocorrência deve ser salva e uma mensagem de sucesso deve ser exibida

Scenario: Falha no cadastro de ocorrência por falta de informações
  Given que estou na página de cadastro de ocorrências
  When deixo um campo obrigatório em branco
  And clico em "Enviar"
  Then uma mensagem de erro deve ser exibida indicando o campo obrigatório
