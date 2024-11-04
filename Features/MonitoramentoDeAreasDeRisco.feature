Feature: Monitoramento de Áreas de Risco
  Como um usuário
  Quero monitorar áreas de risco
  Para que eu possa tomar ações preventivas

Scenario: Exibir mapa com áreas de risco
  Given que estou na página de monitoramento
  When acesso o mapa
  Then as áreas de risco devem ser destacadas corretamente no mapa

Scenario: Falha ao carregar mapa
  Given que estou na página de monitoramento
  When o mapa não carregar corretamente
  Then uma mensagem de erro deve ser exibida
