//////////////////////////////////////////////////////////////////////////////////////////////////
//
//											C A B E Ç A L H O
//
//
//
// EasyFood App - Para realizar pedidos delivery
//
// Feito por: World Connection(André Luiz, José Pedro, Thiago dos Santos, Rodrigo Almeida e Miguel Sales)
// Email: programadores_sedentarios@outlook.com
//
//------------------------------------------------------------------------------------------------
//
// Este app recebe dados do usuário necessarios para a 
// realização de um pedido delivery e envia ao um 
// banco de dados mysql que o restaurante irá ter acesso.
//
//-----------------------------------------------------------------------------------------------
//
// Tags:
// 	btn = Button
// 	et = EditText
// 	rg = RadioGroup
//	rb = RadioButton
// 	tv = TextView
// 	obj = Objeto
// 	BD = Banco de Dados
//
//------------------------------------------------------------------------------------------------
//
//
//
// Histórico:
//
// V0.1 10-02-2014, André Luiz:
//
//		-Versão inicial do app.
//	
//
// V0.2 01-04-2014, André Luiz:
// 
//      	-Implementação do Banco de Dados SQLite.
//
//
// V0.3 04-04-2014, André Luiz:
//
//		-Ajuste menus(inserção de icones);
//		-Inserção de caixas de dialogo(SIM/NÃO) nos métodos 
//		 para sair e voltar ao inicio.
//
//
// V0.4 16-04-2014, André Luiz:
//
//		-Método para conexão http;
//		-Registrando pedidos em BD Mysql;
//		-Api level minimo de 8 trocado para 9;
//		-Resolvido bug quando procura valores no 
//		 bd sqlite pela primeira vez.
//
//
// V0.5 18-04-2014, André Luiz:
//
//		-Cadastro e Login de usuários;
//
//
// V0.6 01-05-2014, André Luiz:
//
//		-Recuperação de produtos cadastrados;
//		-Recuperação de histórico de pedidos;
//		-Ajustes xml em Login;
//		-Ajuste erro ao tentar cadastrar usuário já existente
//		-Capturando numero do celular
//		-Confirmação de senha ao cadastrar
//		-Função Deslogar
//
// V0.7 11-05-2014, André Luiz:
//
//		-Bug deslogar resolvido;
//		-Layout melhorado;
//
//
//////////////////////////////////////////////////////////////////////////////////////////////////


package br.com.worldconnection.easyfood;

import org.apache.http.NameValuePair;
import org.apache.http.message.BasicNameValuePair;

import java.util.ArrayList;

import com.example.easyfood.R.id;
import br.com.worldconnection.conexaoweb.*;
import com.example.easyfood.R;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.os.StrictMode;
import android.telephony.TelephonyManager;
import android.util.Log;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
//import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;
import android.database.sqlite.*;
import android.database.Cursor;


public class Principal extends Activity {
	
//
//--------------------------------------------------V A R I A V E I S------------------------------------------
//
	//Banco de Dados MYSQL
	final String endereco = "http://192.168.0.102/";
	
	//Banco de Dados SQLITE
	
	SQLiteDatabase bancoDeDados = null;
	Cursor cursorBD = null;
	final String nomeBD = "easyfoodBD"; //Nome base de dados
	
	//Variáveis de elementos xml
		
		//Login.xml
			
			Button btnEntrar, btnRegistrar;
			EditText etUsuario, etSenha;
			
		//Cadastrar.xml
			
			Button btnCadastrar;
			EditText etUsuarioCadastro, etSenhaCadastro, etSenhaCadastro2/*Para confirmar senha*/, etNomeCadastro;
	
		//Local1.xml
	
			RadioGroup rgCidade;
			Button btnProximoLocal2;
			
		//Local2.xml
			
			EditText etBairro, etRua, etNum, etComplemento;
			Button btnProximoPedido;
	
		//Pedido.xml
			
			Button btnProximoCarrinho, btnInserir;
			EditText etCodProd, etQuantidade, etProdutos;
			
		//Carrinho.xml
			
			TextView tvCidade, tvBairro, tvRua, tvNum;
			EditText etHistorico;
			Button btnVoltarPedido;
			
		//Variavel de alerta		
			AlertDialog alerta = null; 
			
		//Flag's
				
			Boolean login = false; //Se logado recebe true se não recebe false
	
	//Objeto para armazenar os dados do pedido na memoria
			
	Informacoes objInformacoes = new Informacoes();
	
//
//----------------------------------------------F I M - V A R I A V E I S------------------------------------------
//
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		criarOuConectarBD(); //Criando ou Conectando BD
		chamarLogin(); // Primeira tela do app		
		
	}
	
//
//--------------------------------------------------B A N C O - D E - D A D O S--------------------------------
//
	
	@SuppressWarnings("deprecation")
	
	//Criando ou Abrindo BD
	
	private void criarOuConectarBD()
	{
		
		try
		{			
			bancoDeDados = openOrCreateDatabase(nomeBD, MODE_WORLD_READABLE, null);		
			
			//Tabela para armazenamento do local do pedido
			
			String sql = "CREATE TABLE IF NOT EXISTS Local"
						+"("
						+  "cod Integer PRIMARY KEY,"
						+  "cidade TEXT,"
						+  "bairro TEXT,"
						+  "rua TEXT,"
						+  "numero TEXT"
						+");";
			bancoDeDados.execSQL(sql);
			
		} 
		catch(Exception erro) 
		{
			menssagemAlerta("Erro", "Erro ao conectar ou criar o Banco de Dados. " + erro.getMessage(), "Estamos trabalhando para corrigir este problema.");
		}
	}
	
	//Fechando o BD
	
	private void fecharBD()
	{
		try{
			bancoDeDados.close();
		}
		catch (Exception erro) 
		{
			menssagemAlerta("Opss...Ocorreu um erro", "Erro ao fechar o Banco de Dados. " + erro.getMessage(), "Desculpe pelo transtorno");
		}
	}
	
	//Buscando Itens no BD
	
	private boolean buscarDadosBD()
	{
		try
		{
			cursorBD = bancoDeDados.query("Local", new String[] {"cidade", "bairro", "rua", "numero"}, null, null, null, null, null);
			
			//Se houver registros passar o valor para os EditText
			
			int numeroRegistro = cursorBD.getCount(); //Buscando a quantidade de registros no bd	
			if (numeroRegistro != 0)
			{
				cursorBD.moveToLast();
				return true;
			}
			
			return true;
		} 
		catch(Exception erro)
		{
			menssagemAlerta("Erro ao buscar", "Erro ao buscar no Banco de Dados. "+erro.getMessage(), "Verifique os valores inseridos");
			return false;
		}
	}
	
	//Passando os dados do BD para as textview em Local2.xml
	private void mostrarDadosBD()
	{
		try
		{
			etBairro.setText(cursorBD.getString(cursorBD.getColumnIndex("bairro")));
			etRua.setText(cursorBD.getString(cursorBD.getColumnIndex("rua")));
			etNum.setText(cursorBD.getString(cursorBD.getColumnIndex("numero")));
		}
		catch (Exception erro)
		{
			etBairro.setText("");
			etRua.setText("");
			etNum.setText("");
		}
	}
	
	//Gravando dados no BD
	private void gravarDadosBD()
	{
		try
		{
			
			String sql = "INSERT INTO Local (bairro, rua, numero) VALUES ('"
						 +etBairro.getText().toString()+"','"
						 +etRua.getText().toString()+"','"
						 +etNum.getText().toString()+"')";
			
			bancoDeDados.execSQL(sql);
		} 
		catch (Exception erro) 
		{
			menssagemAlerta("Erro ao gravar dados", "Erro ao Gravar no Banco de Dados. "+erro.getMessage(), "Verifique os valores inseridos");
		}
	}
//
//------------------------------------------F I M - B A N C O - D E - D A D O S--------------------------------------
//

//
//---------------------------------------------------M E N U S-------------------------------------------------------
//
	
	//Definindo e exibindo itens de menu
	
	public boolean onCreateOptionsMenu(Menu menu)
	{
		MenuInflater menuinflater = getMenuInflater();
		menuinflater.inflate(R.menu.main, menu);
	    StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
	    StrictMode.setThreadPolicy(policy);
		return true;
	}
	
	//Ação para itens de menu
	
	public boolean onOptionsItemSelected(MenuItem itemMenu)
	{
		//Verificando qual item foi selecionado
		
		switch(itemMenu.getItemId())
		{
		case id.itmSair:
			fecharBD(); 	
			//Saindo do App
			menssagemSair();
			break;
			
		case id.itmDeslogar:
			login = false;
			objInformacoes.limparVariaveis();
			chamarLogin();
			break;
					
		case id.itmManual:
			chamarManual();
			break;
		}
		
		return super.onOptionsItemSelected(itemMenu);
	}

//
//--------------------------------------------------F I M - M E N U S---------------------------------------------------
//
	
//
//---------------------------------------------------A L E R T A S-----------------------------------------------------
//	
	
											//Métodos para menssagens de alerta
	
	public void menssagemAlerta(String title, String message, final String message2)
	{
		//Cria o gerador do AlertDialog
		
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        
        //define o titulo
        
        builder.setTitle(title);
        
        //define a mensagem
        
        builder.setMessage(message);
        
        //define um botão como positivo
        
        builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface arg0, int arg1) {
                Toast.makeText(Principal.this, message2, Toast.LENGTH_SHORT).show(); //Menssagem após apertar no botão OK
            }
        });
        
        //cria o AlertDialog
        
        alerta = builder.create();
        
        //Exibe
        
        alerta.show();
	}
	
	public void menssagemSair()
	{
		//Cria o gerenciador do AlertDialog
		
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        
        //Define o titulo
        
        builder.setTitle("Sair?");
        
        //Define a menssagem
        
        builder.setMessage("Deseja realmente sair?");
        
        //Cria o botão SIM
        
        builder.setPositiveButton("SIM", new DialogInterface.OnClickListener() {
           
        	//Evento do botão SIM
        	
        	public void onClick(DialogInterface arg0, int arg1) {
        		fecharBD();
                finish();
            }
        });
        
        //Cria o botão Não
        
        builder.setNegativeButton("NÃO", new DialogInterface.OnClickListener() {
          
        	//Evento do botão NÃO
        	
        	public void onClick(DialogInterface arg0, int arg1) {
            }
        });
        
        //Cria o alerta
        
        alerta = builder.create();
        
        //Exibe
        alerta.show();
	}
	
	public void menssagemVoltarTudo()
	{
		//Cria o gerenciador do AlertDialog
		
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        
        //Define o titulo
        
        builder.setTitle("Voltar ao inicio?");
        
        //Define a menssagem
        
        builder.setMessage("Deseja realmente voltar ao inicio?");
        
        //Cria o botão SIM
        
        builder.setPositiveButton("SIM", new DialogInterface.OnClickListener() {
           
        	//Evento do botão SIM
        	
        	public void onClick(DialogInterface arg0, int arg1) {
        		
        		if(login == true)
        			chamarMenuPrincipal(); //Se estiver logado
        		else
        			chamarLogin(); //Se não estiver logado
            }
        });
        
        //Cria o botão Não
        
        builder.setNegativeButton("NÃO", new DialogInterface.OnClickListener() {
          
        	//Evento do botão NÃO
        	
        	public void onClick(DialogInterface arg0, int arg1) {
            }
        });
        
        //Cria o alerta
        
        alerta = builder.create();
        
        //Exibe
        alerta.show();
	}
	
	@SuppressLint("ShowToast")
	public void menssagemInserirProduto()
	{
		//Cria o gerenciador do AlertDialog
		
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        
        //Define o titulo
        
        builder.setTitle("Deseja pedir este produto?");
        
        //Define a menssagem
        	builder.setMessage("Deseja realmente pedir "+etQuantidade.getText().toString()+" produto(s) de código "+etCodProd.getText().toString()+"?");
        
        //Cria o botão SIM
        
        builder.setPositiveButton("SIM", new DialogInterface.OnClickListener() {
           
        	//Evento do botão SIM
        	
        	public void onClick(DialogInterface arg0, int arg1) {
        		
        		//Gravando no Banco de Dados Mysql
				
				String vazios = "";
			    if (etCodProd.getText().toString().equals("")) 
			    	vazios="Campo Cod Produto não pode estar vazio\n\n";
			    
			     if (etQuantidade.getText().toString().equals(""))
			    	 vazios+="Campo Quantidade não pode estar vazio";
			    
				if (etCodProd.getText().toString().equals("") || etQuantidade.getText().toString().equals(""))
					menssagemAlerta("Erro na Gravação.:", ""+vazios,"Erro");
			  else
			  {
				//Criando logs
				Log.i("gravar", "entrou no evento");
				String urlPost=endereco+"cadastrarPedido.php";
				ArrayList<NameValuePair> iparametrosPost = new ArrayList<NameValuePair>();
				Log.i("ArrayList", "NameValuePair");
				
				//Parametros
				iparametrosPost.add(new BasicNameValuePair("fkcodprod",etCodProd.getText().toString()));
				iparametrosPost.add(new BasicNameValuePair("qtddpedido",etQuantidade.getText().toString()));
				iparametrosPost.add(new BasicNameValuePair("endpedido", objInformacoes.getCidade()+", "+objInformacoes.getBairro()+", "+objInformacoes.getRua()+", "+objInformacoes.getNumero()+", "+objInformacoes.getComplemento().toString()));
				iparametrosPost.add(new BasicNameValuePair("coduser",objInformacoes.getCoduser()));
				
				Log.i("parametros", ""+iparametrosPost.toString());
				String respostaRetornada = null;
				Log.i("gravar", "vai entrar no try");
				try {
					respostaRetornada = ConexaoHttpClient.executaHttpPost(urlPost, iparametrosPost);
					String resposta = respostaRetornada.toString();
					Log.i("gravar", "resposta = "+resposta);
					resposta = resposta.replaceAll("\\s+", "");
					
					//Tratando erro de produto que não existe
					if(resposta.equals("Erro"))
					{
						menssagemAlerta("Erro", "Campo inválido ou falha na conexão com o Banco de Dados", "Verifique os campos novamente");
					} 
					else 
					{
						Toast.makeText(Principal.this, "Pedido Realizado com Sucesso", Toast.LENGTH_SHORT).show(); 
					}
					
				}
				catch(Exception erro)
				{
					Log.i("erro", "erro = "+erro);
					menssagemAlerta("Erro", "Verifique os parametros passados " + erro,"Erro");
				}
				
			}
        		
            }
        });
        
        //Cria o botão Não
        
        builder.setNegativeButton("NÃO", new DialogInterface.OnClickListener() {
          
        	//Evento do botão NÃO
        	
        	public void onClick(DialogInterface arg0, int arg1) {
            }
        });
        
        //Cria o alerta
        
        alerta = builder.create();
        
        //Exibe
        alerta.show();
	}
	
//
//---------------------------------------------------F I M - A L E R T A S--------------------------------------------------
//				
	
//
//-------------------------------------------N A V E G A N D O - E N T R E - T E L A S--------------------------------------
//		
	
	//Métodos para chamar outra tela
	
	public void chamarLocal2()
	{
		criarOuConectarBD(); //Conectando BD
		
		buscarDadosBD(); //Buscando dados no BD
		
		//Gravando Informações
	
		//Recuperando Index do Button Selecionado
		
		int radioButtonID = rgCidade.getCheckedRadioButtonId();
		View radioButton = rgCidade.findViewById(radioButtonID);
		int idx = rgCidade.indexOfChild(radioButton);
		
		if(idx == 0)
		{
			objInformacoes.setCidade("Poá");	
		}
		else if(idx == 1)
		{
			objInformacoes.setCidade("Ferraz de Vasconcelos");
		} 
		else if(idx == 2){
			objInformacoes.setCidade("Suzano");
		} 
		else 
		{
			objInformacoes.setCidade("Mogi das Cruzes");
		}	
		
		setContentView(R.layout.local2); //Mostrando a pagina xml
		
		//Vinculando variáveis com elementos xml
		
			//EditTexts
		
			etBairro = (EditText) findViewById(R.id.etBairro);
			etRua = (EditText) findViewById(R.id.etRua);
			etNum = (EditText) findViewById(R.id.etNum);
			etComplemento = (EditText) findViewById(R.id.etComplemento);
		
			//Buttons	
		
			btnProximoPedido = (Button) findViewById(R.id.btnPedido);
			
		//Passando os dados do ultimo pedido registrado no BD para os editText
			mostrarDadosBD();
		
		//Criando evento clique para o botão ProximoPedido(xml)
		
     	btnProximoPedido.setOnClickListener(new View.OnClickListener() 
     	{		
			@Override
			public void onClick(View arg0) {
				if(etBairro.getText().toString().equals("") || etRua.getText().toString().equals("") || etNum.getText().toString().equals(""))
					menssagemAlerta("Opss... está faltando algo", "Preencha todos os campos", "Informações Incorretas" );
				else 
				{
					//Gravando Informações	
					
					//Na Memória
					objInformacoes.setBairro(etBairro.getText().toString());
					objInformacoes.setRua(etRua.getText().toString());
					objInformacoes.setNumero(etNum.getText().toString());
					if(etComplemento.getText().toString().equals(""))
						objInformacoes.setComplemento(" - ");
					else
						objInformacoes.setComplemento(etComplemento.getText().toString());
					
					//No BD Interno
					gravarDadosBD();
					
					chamarPedido();
					
				}
				
			}
		});
     	
	}
	
	@SuppressLint("ShowToast")
	public void chamarPedido()
	{
		
		//Mostrando a pagina xml
		
		setContentView(R.layout.pedido);
		
		//Passando valor dos produtos
		etProdutos = (EditText) findViewById(id.etProdutos);
		
		try {
			
			//Recuperando Produtos do Banco de Dados Mysql
				
				Log.i("produtos", "entrou no evento");
				String urlPost=endereco+"listarProdutos.php";
				Log.i("urlPost", ""+urlPost);
				ArrayList<NameValuePair> iparametrosPost = new ArrayList<NameValuePair>();
				Log.i("ArrayList", "NameValuePair");
				String respostaRetornada = null;
				Log.i("recuperar", "vai entrar no try");
				try {
					respostaRetornada = ConexaoHttpClient.executaHttpPost(urlPost, iparametrosPost);
					String resposta = respostaRetornada.toString();
					
					String produtos = ""; //String para armazenar os valores recuperados
					
					if(resposta.contains("#"))
					{
						
						for(int i = 0; i < resposta.length(); i++)
						{
							if(resposta.charAt(i) != '#')
								produtos += resposta.charAt(i);
							else
								produtos += "\n\n";
						}	
					} 	
					
					//Passando os valores recuperado para EditText
					etProdutos.setText(produtos);
					
				}
				catch(Exception erro)
				{
					Log.i("erro", "erro = "+erro);
					//Toast.makeText(CadastroUsuario.this, "Erro.: "+erro, Toast.LENGTH_LONG).show();
					menssagemAlerta("Erro", "Erro ao recuperar lista de produtos " + erro,"Erro");
				}
			
	 }
			catch(Exception erro2)
			{
				menssagemAlerta("Erro2",""+erro2,"Erro");
			}
			
		
		//Vinculando variáveis com elementos xml
		
			//EditText
				etCodProd = (EditText) findViewById(id.etCodProd);
				etQuantidade = (EditText) findViewById(id.etQuantidade);
		
			//Buttons
		
				btnProximoCarrinho = (Button) findViewById(id.btnCarrinho);
				btnInserir = (Button) findViewById(R.id.btnInserir);
				
		//Eventos Clique
				
				btnProximoCarrinho.setOnClickListener(new View.OnClickListener() {
					
					@Override
					public void onClick(View v) {
						
						chamarCarrinho();
						
					}
				});
				
				btnInserir.setOnClickListener(new View.OnClickListener() {
					
					@Override
					public void onClick(View v) {
							
						menssagemInserirProduto();
					
					}
				});
		
	}
	
	
	public void chamarRegistrar()
	{
		//Mostrando a pagina xml
		
		setContentView(R.layout.cadastrar);
		
		//Vinculando variáveis com elementos xml
		
			//EditText
			
			etUsuarioCadastro = (EditText) findViewById(id.etUsuarioCadastro);
			etSenhaCadastro = (EditText) findViewById(id.etSenhaCadastro);	
			etSenhaCadastro2 = (EditText) findViewById(id.etSenhaCadastro2);
			etNomeCadastro = (EditText) findViewById(id.etNomeCadastro);		
			
			//Pegando o numero do celular
			TelephonyManager tm = (TelephonyManager)getSystemService(TELEPHONY_SERVICE); 
			final String numeroTelefone = tm.getLine1Number();
			
			//Buttons
			
			btnCadastrar = (Button) findViewById(id.btnCadastrarCadastro);
			
			//Eventos Clique
			btnCadastrar.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					
					try {
					//Gravando usuario no Banco de Dados Mysql
						
						String erros = "";
						
						 if(etSenhaCadastro.getText().toString().length() < 8)
							erros += "Crie uma senha de no mínimo 8 caracteres\n\n";
						 
						 if(!etSenhaCadastro.getText().toString().equals(etSenhaCadastro2.getText().toString()))
							 erros += "As Senhas não podem ser diferentes\n\n";
							 
					     if (etSenhaCadastro.getText().toString().equals(""))
					    	 erros += "Campo Senha não pode estar vazio\n\n";
						 
					     if (etUsuarioCadastro.getText().toString().equals("")) 
					    	erros += "Campo Usuario não pode estar vazio\n\n";
					     
					     if (etNomeCadastro.getText().toString().equals(""))
					    	 erros += "Campo Nome não pode estar vazio\n\n";
					    
						if (etUsuarioCadastro.getText().toString().equals("") || etSenhaCadastro.getText().toString().equals("") || etNomeCadastro.getText().toString().equals("") || etSenhaCadastro.getText().toString().length() < 8 || !etSenhaCadastro.getText().toString().equals(etSenhaCadastro2.getText().toString()))
							menssagemAlerta("Erro no Cadastro:", ""+erros,"Erro");
						else
						{
							Log.i("gravar", "entrou no evento");
							String urlPost=endereco+"cadastrarUsuario.php";
							Log.i("urlPost", ""+urlPost);
							ArrayList<NameValuePair> iparametrosPost = new ArrayList<NameValuePair>();
							Log.i("ArrayList", "NameValuePair");
							iparametrosPost.add(new BasicNameValuePair("loginusuario",etUsuarioCadastro.getText().toString()));
							iparametrosPost.add(new BasicNameValuePair("senhausuario",etSenhaCadastro.getText().toString()));
							iparametrosPost.add(new BasicNameValuePair("nomeusuario",etNomeCadastro.getText().toString()));
							iparametrosPost.add(new BasicNameValuePair("telefoneusuario",numeroTelefone));
							Log.i("parametros", ""+iparametrosPost.toString());
							String respostaRetornada = null;
							Log.i("gravar", "vai entrar no try");
							
							try {
								respostaRetornada = ConexaoHttpClient.executaHttpPost(urlPost, iparametrosPost);
								String resposta = respostaRetornada.toString();
			
								//Verificando se usuário já existe antes
								Log.i("gravar", "resposta = "+resposta);
								resposta = resposta.replaceAll("\\s+", "");
									
								if(resposta.equals("0"))
									menssagemAlerta("Falha ao cadastrar", "Usuário já existe", "Tente novamente");
								else
									menssagemAlerta("Sucesso", "Cadastrado com sucesso", "Aproveite o EasyFood App :)");
									chamarLogin();
							}	
							catch(Exception erro)
							{
								Log.i("erro", "erro = "+erro);
								menssagemAlerta("Erro", "Verifique os parametros passados " + erro,"Erro");
							}
						
					   }
					
			 }
					catch(Exception erro2)
					{
						menssagemAlerta("Erro2",""+erro2,"Erro");
					}
					
				}
		  });
	}
	
	public void chamarLogin()
	{
		//Mostrando a pagina xml
		
		setContentView(R.layout.login);
		
		//Vinculando variáveis com elementos xml
			
			//Buttons
		
				btnEntrar = (Button) findViewById(id.btnEntrar);
				btnRegistrar = (Button) findViewById(id.btnRegistrar);
				
			//EditText
				
				etUsuario = (EditText) findViewById(id.etUsuarioLogin);
				etSenha = (EditText) findViewById(id.etSenhaLogin);
				
			//Eventos Cliques
				
				//Fazendo Login do usuario
				btnEntrar.setOnClickListener(new View.OnClickListener() {
					
					@Override
					public void onClick(View v) {
						
						Log.i("logar", "entrou no evento");
						String urlPost=endereco+"login.php";
						ArrayList<NameValuePair> parametrosPost = new ArrayList<NameValuePair>();
						parametrosPost.add(new BasicNameValuePair("loginusuario",etUsuario.getText().toString()));
						parametrosPost.add(new BasicNameValuePair("senhausuario",etSenha.getText().toString()));
						String respostaRetornada = null;
						Log.i("logar", "vai entrar no try");
						try {
							respostaRetornada = ConexaoHttpClient.executaHttpPost(urlPost, parametrosPost);
							//respostaRetornada = ConexaoHttpClient.executaHttpGet(urlGet);
							String resposta = respostaRetornada.toString();
							Log.i("logar", "resposta = "+resposta);
							resposta = resposta.replaceAll("\\s+", "");
							//Usuario e senha não escontrados
							if (resposta.equals("0"))
							{
								menssagemAlerta("Login", "Usuario ou Senha Inválido(s)","Verifique os campos usuario e senha");
								
							}					
							//Login confirmado
							else
							{
							 objInformacoes.setCoduser(resposta);
							 login = true;
							 chamarMenuPrincipal();
							}
						}
						catch(Exception erro)
						{
							Log.i("erro", "erro = "+erro);
							Toast.makeText(Principal.this, "Erro.: "+erro, Toast.LENGTH_LONG).show();
						}	
					}
				});
				
				btnRegistrar.setOnClickListener(new View.OnClickListener() {
					
					@Override
					public void onClick(View v) {
						
						chamarRegistrar();
						
					}
				});
	}
	
	public void chamarMenuPrincipal()
	{
		
		//Mostrando a pagina xml
		
		setContentView(R.layout.local1);
		
		//Vinculando variáveis com elementos xml
		
			//Buttons
		
				btnProximoLocal2 = (Button) findViewById(R.id.btnLocal);
				
			//RadioButtons
				
				rgCidade = (RadioGroup) findViewById(R.id.rgCidade);
				
		//Criando evento clique para o botão btnLocal(xml)
				
				btnProximoLocal2.setOnClickListener(new View.OnClickListener() {
					
					@Override
					public void onClick(View v) {
						chamarLocal2();
						
					}
				});
				
	}
	
	public void chamarManual()
	{
		setContentView(R.layout.manual);
	}
	
	public void chamarCarrinho()
	{
		
		//Mostrando a pagina xml
		
			setContentView(R.layout.carrinho);
			
			etHistorico = (EditText) findViewById(id.etHistorico);
			
			try {
				
				//Recuperando Pedidos do Banco de Dados Mysql
					
					Log.i("pedidos", "entrou no evento");
					String urlPost=endereco+"listarCompra.php";
					Log.i("urlPost", ""+urlPost);
					ArrayList<NameValuePair> iparametrosPost = new ArrayList<NameValuePair>();
					Log.i("ArrayList", "NameValuePair");
					iparametrosPost.add(new BasicNameValuePair("codusuario",objInformacoes.getCoduser()));
					String respostaRetornada = null;
					Log.i("recuperar", "vai entrar no try");
					try {
						respostaRetornada = ConexaoHttpClient.executaHttpPost(urlPost, iparametrosPost);
						String resposta = respostaRetornada.toString();
						
						String pedidos = ""; //String para armazenar os valores recuperados
							
							for(int i = 0; i < resposta.length(); i++)
							{		
								if(resposta.charAt(i) != '#' && resposta.charAt(i) != '@')
									pedidos += resposta.charAt(i);
								else
									if(resposta.charAt(i) == '@')
										pedidos += "\n";
									else
										pedidos += "\n\n";
							}	
						
						//Passando os valores recuperado para EditText
						etHistorico.setText(pedidos);
						
					}
					catch(Exception erro)
					{
						Log.i("erro", "erro = "+erro);
						//Toast.makeText(CadastroUsuario.this, "Erro.: "+erro, Toast.LENGTH_LONG).show();
						menssagemAlerta("Erro", "Erro ao recuperar histórico de pedidos. " + erro,"Erro");
					}
				
		 }
				catch(Exception erro2)
				{
					menssagemAlerta("Erro2",""+erro2,"Erro");
				}
		
		//Vinculando variáveis com elementos xml
			
			//Buttons
			
				btnVoltarPedido = (Button) findViewById(R.id.btnCardapio);
			
			//TextViews
				
				tvCidade = (TextView) findViewById(R.id.tvCidade);
				tvBairro = (TextView) findViewById(R.id.tvBairro);
				tvRua = (TextView) findViewById(R.id.tvRua);
				tvNum = (TextView) findViewById(R.id.tvNum);
				
			//Passando dados para os TextViews
				
				tvCidade.setText(objInformacoes.getCidade());
				tvBairro.setText(objInformacoes.getBairro());
				tvRua.setText(objInformacoes.getRua());
				if(objInformacoes.getComplemento() != "")
					tvNum.setText(objInformacoes.getNumero() + ", " + objInformacoes.getComplemento());
				else
					tvNum.setText(objInformacoes.getNumero());
				
			//Eventos Cliques
				
				btnVoltarPedido.setOnClickListener(new View.OnClickListener() {
					
					@Override
					public void onClick(View v) {
						chamarPedido();
						
					}
				});
		
	}
	
	// VOLTAR AO INICIO NO BOTAO "BACK" 
	
	@Override
		public void onBackPressed() {	
	
				menssagemVoltarTudo();	
				
		} 

//
//----------------------------------F I M - N A V E G A N D O - E N T R E - T E L A S--------------------------------------
//	
	
}
