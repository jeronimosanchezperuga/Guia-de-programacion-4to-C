﻿//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capital1;
    public float capital2;
    public float capital3;

    float capitalTotal;
    float porc1;
    float porc2;
    float porc3;


    // Start is called before the first frame update
    void Start()
    {
        capitalTotal = capital1 + capital2 + capital3;

        porc1 = capital1 / capitalTotal * 100;
        porc2 = capital2 / capitalTotal * 100;
        porc3 = capital3 / capitalTotal * 100;

        Debug.Log("Nombre: " + nombre1 + " capital aportado: $ " + capital1 + 
            ", Porcentaje del capital: %" + porc1 +", Monto total aportado: $" + capitalTotal);
        Debug.Log("Nombre: " + nombre2 + " capital aportado: $ " + capital2 +
            ", Porcentaje del capital: %" + porc2 + ", Monto total aportado: $" + capitalTotal);
        Debug.Log("Nombre: " + nombre3 + " capital aportado: $ " + capital3 +
            ", Porcentaje del capital: %" + porc3 + ", Monto total aportado: $" + capitalTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
