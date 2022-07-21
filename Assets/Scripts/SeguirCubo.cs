using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCubo : MonoBehaviour
{
    public GameObject CarroNegro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CarroNegro.transform.position + new Vector3(-33,14,-8);
    }
}
