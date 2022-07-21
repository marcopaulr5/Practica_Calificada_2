using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBasico : MonoBehaviour
{
    float velocidad = 30.0f;
    float velAngular = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0,-velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,  velAngular * Time.deltaTime,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -velAngular * Time.deltaTime, 0);
        }
    }
}
