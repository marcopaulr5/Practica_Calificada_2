using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionNombres : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "CubeAire3")
        {
            //If the GameObject's name matches the one you suggest, output this message
           transform.Translate(0,0,-1);
        }

       
    }
}
