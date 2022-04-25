using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadora_masa_muscular : MonoBehaviour
{

    public string Nombre_Del_Usuario;
    public float Altura_En_Centimetros_Del_Usuario;
    public float Peso_En_Kilogramos_Del_Usuario;


    // Start is called before the first frame update
    void Start()
    {
        float imc;
        float altura_Cm_Dos;

        altura_Cm_Dos = Altura_En_Centimetros_Del_Usuario * Altura_En_Centimetros_Del_Usuario;
        imc = Peso_En_Kilogramos_Del_Usuario / altura_Cm_Dos;

        Debug.Log("El nombre del usuario es:" + Nombre_Del_Usuario);
        Debug.Log("La altura del usuario en centimerios es:" + Altura_En_Centimetros_Del_Usuario);
        Debug.Log("El peso del usuario en kilogramos es:" + Peso_En_Kilogramos_Del_Usuario);

        Debug.Log(imc);


        if (imc < 18.5f)
        {

            Debug.Log("rango de peso insuficiente.");

        }

        if (imc > 18.5f && imc < 24.9)
        {

            Debug.Log("rango de peso normal o saludable.");

        }

        if (imc > 25.0f && imc < 29.9)
        {

            Debug.Log("rango de sobrepeso.");
        }

        if (imc > 30.0 && imc < 30.0)
        {

            Debug.Log("rango de obesidad.");

        }
    }


    // Update is called once per frame
    void Update()
    {

    }

}