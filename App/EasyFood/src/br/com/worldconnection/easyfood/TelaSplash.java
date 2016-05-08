//
//                         -------------------------------------
//                         |                                   |
//                         |       TELA SPLASH EASYFOOD        |
//                         |                                   |
//                         -------------------------------------
//

package br.com.worldconnection.easyfood;

import com.example.easyfood.R;

import android.os.Bundle;
import android.os.Handler;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;

public class TelaSplash extends Activity implements Runnable{

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.splash);
		
		//Definindo Tempo de duração
		Handler handler = new Handler();
		handler.postDelayed(this, 6000);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	@Override
	//Chamando classe Principal
	public void run() {
		startActivity(new Intent(this, Principal.class));
		finish();	
	}

}
