using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgoritmosT : MonoBehaviour {
	

	void Start () {
		List<int> lista = new List<int>();
		lista.Add (80);
		lista.Add (1);
		lista.Add (2);
		lista.Add (32);
		lista.Add (32);
		select(lista);
	}
	void Update () {
	}
		
	void intercambiar(List<int> lista,int i,int j){
		int cambio;
		cambio = lista [i];
		lista[i] = lista[j];
		lista [j] = cambio;
	}


	void select(List<int> lista){
		int posmin;	
		for (int actual = 0; actual < lista.Count-1;actual++){
			posmin = actual;
			for (int j = actual + 1; j < lista.Count; j++) 
				if (lista [j] < lista [posmin])
					posmin = j;
			intercambiar (lista, actual, posmin);
		}
		for (int i = 0; i < lista.Count; i++) {
			print (lista[i]);

		}
	
		



}
}
		

