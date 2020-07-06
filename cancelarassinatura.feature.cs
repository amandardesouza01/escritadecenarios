#language: pt-br
Funcionalidade: Cancelar assinatura
     Para assinante do netflix
     Eu, como assinante
     Desejo cancelar minha assinatura
	
Cenário: Acesso a pagina de cancelamento de assinatura  
     Dado que o assinante do netflix
     E deseja cancelar a assinatura
     Quando ele acessa a opção de cancelar a assinatura
     Então retorna opção de cancelar assinatura ou trocar de plano
	 
Cenário: Cancelamento da assinatura
     Dado que o assinante do netflix
     E deseja cancelar a assinatura
     Quando seleciona a opção de cancelar a assinatura
     Então a assinatura é cancelada
	 