using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using Random = UnityEngine.Random;

public class entrega_7 : MonoBehaviour
{
    private int cuntaCincos = 0;

    private int totalSuma= 0;

    private string comprobarA = "pepito grillo era un grillo";


    void Start()
    {
        //ejrcicio 1

        ejercicio1();


        //ejercicio 2

        ejercicio2();



        //ejercicio 3

        ejercicio3();


        //ejercicio 4 



        ejercicio4();



        //ejrcicio 5


        ejercicio5();


    }



    private void ejercicio1() 
    {
        for (int i = 2; i <= 100; i += 2)
        {
            Debug.Log(i);
        }

    }

    private void ejercicio2()
    {
        string[] arrayLetras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };


        int contadorVocales = ContarVocales(arrayLetras);


        Debug.Log("En total hay  " + contadorVocales + " vocales");




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


    private void ejercicio3() 
    {
        for (int i = 10; i > 0; i--)
        {
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
    }

    private void ejercicio4 ()
    {
        while (totalSuma <= 100)
        {
            int numerorandom = Random.Range(1, 11);
            totalSuma = totalSuma + numerorandom;

            if (numerorandom == 5)
            {
                cuntaCincos++;
            }
            Debug.Log(numerorandom);
        }
        Debug.Log($"las suma del numero es " + totalSuma);
        Debug.Log($"han salido : " + cuntaCincos);
    }


    private void ejercicio5()
    {
        for (int i = 0; i < comprobarA.Length; i++)
        {
            if (comprobarA[i] == 'a')
            {
                break;
            }
            else
            {
                Debug.Log(comprobarA[i]);
            }
        }
    }


}
