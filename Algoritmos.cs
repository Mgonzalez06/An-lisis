﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
//using CodeMonkey.Utils;



public class Algoritmos : MonoBehaviour
{

    public int[] entrances = { 5, 1500, 4800, 5500, 7000, 8300, 10000 };
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

    static List<int> generarRandom(int veces)
    {
        List<int> retornar = new List<int>();

        for (int i = 0; i < veces; i++)
        {
            int value = Random.Range(0, 500);
           // print(value);
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
		for (int i = 0; i < lista.Count; i++) {
			print (lista[i]);

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



    float calcularPosicion(int segundo,int segundo1,int milisegundo)
    {
        if(segundo == segundo1) {
            if(milisegundo <= 100)
            {
                if (milisegundo == 100)
                    return -1.5f;
                else if (milisegundo > 50)
                    return -1.90f;
                else if (milisegundo <= 50)
                    return -1.75f;
            }
            else if(milisegundo <= 200)
            {
                if (milisegundo == 200)
                    return -1f;
                else if (milisegundo > 150)
                    return -1.433f;
                else if (milisegundo <= 150)
                    return -1.29f;
            }
            else if(milisegundo <= 300)
            {
                if (milisegundo == 300)
                    return -0.5f;
                else if (milisegundo > 250)
                    return -0.80f;
                else if(milisegundo <= 250)
                    return -0.65f;
            }
            else if(milisegundo <= 400)
            {
                if (milisegundo == 400)
                    return 0f;
                else if (milisegundo > 350)
                    return -0.1f;
                else if (milisegundo <= 350)
                    return -0.35f;
            }
            else if(milisegundo <= 500)
            {
                if (milisegundo == 500)
                    return 0.5f;
                else if (milisegundo > 450)
                    return 0.35f;
                else if(milisegundo <= 450)
                        return 0.15f;
            }
            else if(milisegundo <= 600)
            {
                if (milisegundo == 600)
                    return 1f;
                else if (milisegundo > 550)
                    return 0.8f;
                else if (milisegundo <= 550)
                    return 0.655f;
            }
            else if(milisegundo <= 700)
            {
                if (milisegundo == 700)
                    return 1.5f;
                else if (milisegundo > 650)
                    return 1.355f;
                else if (milisegundo <= 650)
                    return 1.155f;

            }
            else if(milisegundo <= 800)
            {
                if (milisegundo == 800)
                    return 2f;
                else if (milisegundo > 750)
                    return 1.85f;
                else if (milisegundo <= 750)
                    return 1.655f;
            }
            else if(milisegundo <= 900)
            {
                if (milisegundo == 900)
                    return 2.5f;
                else if (milisegundo > 850)
                    return 2.355f;
                else if (milisegundo <= 850)
                    return 2.155f;
            }
        }
        else
        {
            if (milisegundo == 0 || milisegundo <= 50)
                return 3f;
            else if(milisegundo <= 100)
            {
                if (milisegundo == 100)
                    return 3.5f;
                else if (milisegundo > 50)
                    return 3.3f;
            }
            else if(milisegundo <= 200)
            {
                if (milisegundo == 200)
                    return 4f;
                else if (milisegundo > 150)
                    return 3.855f;
                else if (milisegundo <= 150)
                    return 3.655f;
            }
            else if(milisegundo <= 300)
            {
                if (milisegundo == 300)
                    return 4.5f;
                else if (milisegundo > 250)
                    return 4.355f;
                else if (milisegundo <= 250)
                    return 4.155f;
            }
            else if(milisegundo <= 400)
            {
                if (milisegundo == 400)
                    return 5f;
                else if (milisegundo > 350)
                    return 4.8f;
                else if (milisegundo <= 350)
                    return 4.655f;
            }
            else if(milisegundo <= 500)
            {
                if (milisegundo == 500)
                    return 5.5f;
                if (milisegundo > 450)
                    return 5.355f;
                else
                    return 5.155f;
            }
            else if(milisegundo <= 600)
            {
                if (milisegundo == 600)
                    return 6f;
                else if (milisegundo > 550)
                    return 5.84f;
                else if (milisegundo <= 550)
                    return 5.655f;
            }
        }
        return 0f;
       
        
    }



    // Start is called before the first frame update
    void Start()
    {
		
		crearLineas ();
        int milisegundoActual = 0;
        int segundoActual = 0;
        float posX = (float)-7.5;
		//unirPuntos (new Vector2 (12, 5), new Vector2 (8, 2));
        for (int i = 0; i < 7; i++)
        {
            int cont = 0;
            while (cont < 5)
            {
                List<int> lista = generarRandom(entrances[i]);
                print("Lista iteracion");
                //startClock();
                milisegundoActual = System.DateTime.Now.Millisecond;
                segundoActual = System.DateTime.Now.Second;
                insertSort(lista);

				//selectSort (lista);

                //  print(time);
                print(milisegundoActual); print(System.DateTime.Now.Millisecond); print(segundoActual); print(System.DateTime.Now.Second);
                print("ordenado");

			
                Instantiate(objeto, new Vector3(posX, calcularPosicion(segundoActual, System.DateTime.Now.Second, System.DateTime.Now.Millisecond - milisegundoActual), 1), Quaternion.identity); //Dibuja en grafico
//				//stopClock();
                cont++;
                

            }
            posX += (float)2.5;
        }
    }


}
