using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class entrega_7 : MonoBehaviour
{
    void Start()
    {
        //ejrcicio 1
        
        for (int i = 2; i <= 100; i += 2)
        {
            Debug.Log(i);
        }



        //ejercicio 2
        
        string[] arrayLetras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

       
        int contadorVocales = ContarVocales(arrayLetras);

        
        Debug.Log("En total hay  " + contadorVocales + " vocales");



        //ejercicio 3

        for (int i = 10; i > 0; i--)
        {
            Debug.Log(i + " green bottles Hanging on the wall ");
            Debug.Log(i + " green bottles Hanging on the wall");

            if (i == 1)
            {
                Debug.Log("And if one green bottle Should accidentally fall There'll be no green bottles Hanging on the wall");
               
            }
            else
            {
                Debug.Log("And if one green bottle Should accidentally fall There'll be " + (i - 1) + " green bottles Hanging on the wall");
                
            }

            
        }


        //ejercicio 4



        //ejercicio 5









    }

    //ejercicio 2
    int ContarVocales(string[] array)
    {
        int contar = 0;

        foreach (string letra in array)
        {
            
            if ("aeiouAEIOU".Contains(letra))
            {
                contar++;
            }
        }

        return contar;

    }



























}
