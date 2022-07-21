using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzPunto : MonoBehaviour
{
    public Light lt;
    Light myLight;
    private float r = 0.0f;
    private float g = 0.0f;
    private float b = 0.0f;
    
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
            r = Random.value;
            g = Random.value;
            b = Random.value;

            Color micolor = new Color(r, g, b);
            lt.color = micolor;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            myLight.intensity += 0.1f;
        }
         if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            myLight.intensity -= 0.1f;
        }
         if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.myLight.range += 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            this.myLight.range -= 0.1f;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(0, 0, 0.1f);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(0, 0, 0.1f);
        }

    }
}
