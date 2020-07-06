#language: pt-br
Funcionalidade: Pagamento
     Para clientes com cupom de desconto
     Eu, como vendedor
     Desejo liberar o desconto
	
Cenário: Cliente com cupom de desconto
     Dado que cliente com cupom de desconto
     E compre algo
     Quando ele insere o codigo de cupom
     Então tem o desconto aplicado no valor da compra
	 
Cenário: Cliente sem cupom de desconto
     Dado que cliente sem cupom de desconto
     E compre algo
     Quando ele não insere o codigo de cupom
     Então não tem o desconto aplicado no valor da compra