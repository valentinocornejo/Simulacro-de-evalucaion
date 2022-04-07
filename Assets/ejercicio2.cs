//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
//Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;
    
    // Start is called before the first frame update
    void Start()
    {
        float suma;
        float resto;
        suma = producto1 + producto2 + producto3;

        if(monto >= suma)
        {
            resto = monto - suma;
            Debug.Log("Te sobro" + resto);
        }
        else
        {
            resto = suma - monto;
            Debug.Log("Te falto" + resto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
