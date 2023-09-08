using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cadenas : MonoBehaviour
{
    string s1 = "Rogelio";

    string s2 = "Trejo";

    int number = 25;

    string espacio = " ";

    string prueba = "Hola Mundo";   
    // Start is called before the first frame update
    void Start()
    {

        string temp = "";
        for (int i = prueba.Length - 1; i >= 0; i--)
        {
            temp += prueba[i];
        }

        print(temp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
