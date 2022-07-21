using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionRayCast : MonoBehaviour
{
    RaycastHit colision;
 // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Physics.Raycast(transform.position, transform.forward,3))
        {
          if(colision.collider.gameObject.name=="SphereVerde")
          {
            colision.collider.transform.Translate(transform.forward);
          }
        }
    }
}
