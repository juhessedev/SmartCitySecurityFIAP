Feature: Notificações de Emergência
  Como um usuário
  Quero receber notificações de emergência
  Para que eu possa reagir rapidamente

Scenario: Receber notificação de emergência
  Given que sou um usuário autenticado
  When ocorre uma emergência
  Then devo receber uma notificação instantaneamente

Scenario: Falha no envio de notificação
  Given que sou um usuário autenticado
  When ocorre um problema no sistema de notificações
  Then uma mensagem de falha deve ser exibida
