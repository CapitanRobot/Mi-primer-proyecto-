using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour
{

    public string miNombre;
    public string nombre_Amigo;
    public int miEdad;
    public int edad_Amigo;

    void Start()
    {
        int total;
        total = miEdad + edad_Amigo;

        Debug.Log("Mi nombre es " + miNombre);
        Debug.Log("El nombre de mi amigo es " + nombre_Amigo);
        Debug.Log("Mi edad es " + miEdad);
        Debug.Log("La edad de mi amigo es " + edad_Amigo);
        Debug.Log("La suma de nuestras edades es" + total);
    }

    /*public string mensajeBienvenida; 
    public string mi_Nombre;
    public int a;
    public float b;
    public bool estaArriba; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo"  + mi_Nombre + a + b + estaArriba);
        Debug.Log (mensajeBienvenida);
    */
    }

    // Update is called once per frame



