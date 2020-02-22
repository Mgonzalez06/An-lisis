using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


public class Algoritmos : MonoBehaviour
{

	public int[] entrances = {5,1500,4800,5500,7000,8300,10000};
	public GameObject objeto;
	public float time = 0f;
	public Text labelTiempo;
	public LineRenderer lineaVertical;
	public LineRenderer lineaHorizontal;
	public Vector3 posicion1;
	public Vector3 posicion2;
	public Vector3 posicion3;
	public Vector3 posicion4;
	public Material material;
	public int currLines=0;
	public RectTransform grafico;

	void awake(){
		grafico = transform.Find ("grafico").GetComponent<RectTransform> ();
	}

	static List<int> generarRandom(int veces)
	{
		List<int> retornar = new List<int>();

		for (int i = 0; i < veces; i++)
		{
			int value = Random.Range(0, 500);

			retornar.Add(value);

		}
		return retornar;
	}
	void insertSort(List<int> lista)
	{

		for (int i = 1; i < lista.Count; i++)
		{
			int cont = i;
			while (cont != 0 && lista[cont] < lista[cont - 1])
			{
				int save = lista[cont];
				lista[cont] = lista[cont - 1];
				lista[cont - 1] = save;
				cont--;
			}
		}

		for (int i = 0; i < lista.Count; i++)
		{
			// print(lista[i]);


		}
	}

	void intercambiar(List<int> lista,int i,int j){
		int cambio;
		cambio = lista [i];
		lista[i] = lista[j];
		lista [j] = cambio;
	}
	void selectSort(List<int> lista){
		int posmin;	
		for (int actual = 0; actual < lista.Count-1;actual++){
			posmin = actual;
			for (int j = actual + 1; j < lista.Count; j++) 
				if (lista [j] < lista [posmin])
					posmin = j;
			intercambiar (lista, actual, posmin);
		}
	
	}
	void crearLineas(){

		lineaVertical = new GameObject ("lineaVertical" + currLines).AddComponent<LineRenderer> ();
		lineaHorizontal = new GameObject ("lineaHorizal" + currLines).AddComponent<LineRenderer> ();

		lineaHorizontal.material = material;
		lineaVertical.material = material;

		lineaHorizontal.positionCount = 2;
		lineaVertical.positionCount = 2;

		lineaHorizontal.startWidth = 0.15f;
		lineaHorizontal.endWidth = 0.15f;

		lineaVertical.startWidth = 0.15f;
		lineaVertical.endWidth = 0.15f;

		lineaHorizontal.useWorldSpace = true;
		lineaVertical.useWorldSpace = true;

		lineaHorizontal.numCapVertices = 1;
		lineaVertical.numCapVertices = 1;

		posicion1.x = -8;
		posicion1.y = 6;
		posicion1.z = 0;

		posicion2.x = -8;
		posicion2.y = -4;
		posicion2.z = 0;

		posicion3.x = -8;
		posicion3.y = -4;
		posicion3.z = 0;

		posicion4.x = 10;
		posicion4.y = -4;
		posicion4.z = 0;


		lineaVertical.SetPosition(0,posicion1);
		lineaVertical.SetPosition (1, posicion2);

		lineaHorizontal.SetPosition (0, posicion3);
		lineaHorizontal.SetPosition (1, posicion4);

	}



	float calcularPosicion(int segundos,int milisegundo)
	{
		if (segundos == 0) {
			if (milisegundo <= 100)
				return -4f;
			else if (milisegundo <= 200)
				return -3.8f;
			else if (milisegundo <= 300)
				return -3.6f;
			else if (milisegundo <= 400)
				return -3.4f;
			else if (milisegundo <= 500)
				return -3.2f;
			else if (milisegundo <= 600)
				return -3f;
			else if (milisegundo <= 700)
				return -2.8f;
			else if (milisegundo <= 800)
				return -2.6f;
			else if (milisegundo <= 900)
				return -2.4f;

		}
		else
		{
			float valor = (segundos * 1f);

			if (Mathf.Abs (milisegundo) <= 100) {
				
					return -2.2f + valor;
			} else if (Mathf.Abs (milisegundo) <= 200) {
					return -2f + valor;
			} else if (Mathf.Abs (milisegundo) <= 300) {
				return -1.8f + valor;
			} else if (Mathf.Abs (milisegundo) <= 400) {
				return -1.6f + valor;
			} else if (Mathf.Abs (milisegundo) <= 500) {
				return -1.4f + valor;
			} else if (Mathf.Abs (milisegundo) <= 600) {
				return -1.2f + valor;
			} else if (Mathf.Abs (milisegundo) <= 700) {
				return -1f + valor;				
			}
			else if (Mathf.Abs (milisegundo) <= 800) {
				return -0.8f + valor;
			}
			else if (Mathf.Abs (milisegundo) <= 900) {
				return -0.6f + valor;

			}
				
		}
		return 0f;


	}



	// Start is called before the first frame update
	void Start()
	{

		crearLineas ();
		int milisegundoActual = 0;
		int segundoActual = System.DateTime.Now.Second;
		float posX = (float)-7.5;

		for (int i = 0; i < 7; i++)
		{
			int cont = 0;
			while (cont < 1)
			{
				List<int> lista = generarRandom(entrances[i]);


				milisegundoActual = System.DateTime.Now.Millisecond;

				//insertSort(lista);

				selectSort (lista);


				print(System.DateTime.Now.Second -segundoActual+"Diferencia de segundos"); print(Mathf.Abs(System.DateTime.Now.Millisecond - milisegundoActual)+ "diferencia de Milisegundos");  


				Instantiate(objeto, new Vector3(posX, calcularPosicion( System.DateTime.Now.Second -segundoActual, System.DateTime.Now.Millisecond - milisegundoActual), 1), Quaternion.identity); //Dibuja en grafico

				cont++;


			}
			posX += (float)2.5;
		}
	}


}