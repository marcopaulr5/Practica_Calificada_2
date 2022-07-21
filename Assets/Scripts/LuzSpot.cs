using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzSpot : MonoBehaviour
{
    public Light lt;
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.myLight.range += 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.myLight.range -= 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.myLight.spotAngle += 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.myLight.spotAngle -= 1.0f;
        }

        // Rotacion de Luz

         if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }
         if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }

         if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }
         if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }
    }
}
