using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArray : MonoBehaviour
{
    public string palabra;
    public char letra;
    public int[] arrayDeInt;
    // Start is called before the first frame update
    void Start()
    {
        // letra = palabra[palabra.Length - 1];
        // Debug.Log(arrayDeInt[0]);
        // Debug.Log(arrayDeInt[arrayDeInt.Length - 1]);
        // SumaDeLosElementosDelArray();
        BuscarLetraEnPalabra(palabra, letra);
        EscribirPalabraInvertidaLetraPorLetra(palabra);
        DevolverSiLaPalabraEsCapicua(palabra);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SumaDeLosElementosDelArray()
    {
        int suma = 0;
        for (int i = 0; i < arrayDeInt.Length; i++)
        {
            suma += arrayDeInt[i];
            Debug.Log("Sumé " + arrayDeInt[i]);
        }
        Debug.Log(suma);
    }
    void BuscarLetraEnPalabra(string palabra, char letraBuscada)
    {
        int counter = 0;
        while (counter < palabra.Length && palabra[counter] != letraBuscada)
        {
            counter++;
        }
        if (counter == palabra.Length)
        {
            Debug.Log("Letra no encontrada");
        }
        else
        {
            Debug.Log("Letra encontrada en la posición " + counter);
        }
    }

    void EscribirPalabraInvertidaLetraPorLetra(string palabra)
    {
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            Debug.Log(palabra[i]);
        }
    }
    void DevolverSiLaPalabraEsCapicua(string palabra)
    {
        for (int k = 0; k < palabra.Length; k++)
        {
            if (palabra[k] != palabra[palabra.Length - 1 - k])
            {
               Debug.Log("No es capicua");
                break;
            }
            else
            {
                Debug.Log("Es capicua");
                break;
            }
        }
    }
}
