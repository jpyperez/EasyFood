//
//                         ---------------------------------------------------------------------------------
//                         |                                                                               |
//                         |       CLASSE PARA ARMAZENAR INFORMAÃ‡Ã•ES PASSADAS PELO USUÃ�RIO EASYFOOD        |
//                         |                                                                               |
//                         ---------------------------------------------------------------------------------
//


package br.com.worldconnection.easyfood;

public class Informacoes {
	
	private String cidade, bairro, rua, numero, complemento, pedido, coduser; //Dados necessarios para realizar o pedido
	
	//Construtor
	
	public Informacoes()
	{
		cidade = bairro = rua = numero = complemento = pedido = coduser = "";;
	}
	
    //MÃ©todos setters e getters
	
	public String getComplemento(){
		return complemento;
	}
	
	public void setComplemento(String complemento)
	{
		this.complemento = complemento;
	}

	public String getCoduser(){
		return coduser;
	}
	
	public void setCoduser(String coduser){
		this.coduser = coduser;
	}
	
	public String getCidade() {
		return cidade;
	}

	public void setCidade(String cidade) {
		this.cidade = cidade;
	}

	public String getBairro() {
		return bairro;
	}

	public void setBairro(String bairro) {
		this.bairro = bairro;
	}

	public String getRua() {
		return rua;
	}

	public void setRua(String rua) {
		this.rua = rua;
	}

	public String getNumero() {
		return numero;
	}

	public void setNumero(String numero) {
		this.numero = numero;
	}

	public String getPedido() {
		return pedido;
	}

	public void setPedido(String pedido) {
		this.pedido = pedido;
	}
	
	public void limparVariaveis() {
		cidade = bairro = rua = numero = complemento = pedido = coduser = "";
	}

}
