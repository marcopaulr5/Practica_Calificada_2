using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionEntrenador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.name=="SphereAmarrilla")
        {
            Destroy(hit.gameObject);
        }
    }
}
