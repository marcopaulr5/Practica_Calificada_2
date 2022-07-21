using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    private float myVar;
    // Start is called before the first frame update
    void Start()
    {
        myVar = multiplicar(5.4f, 6f);
        print(myVar);
    }
    //Mi propio métod
    float multiplicar(float num1, float num2)
    {
        float resultado =  num1 * num2;

        return resultado;
    }

}
