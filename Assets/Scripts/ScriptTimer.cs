using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTimer : MonoBehaviour
{
    public Text contador;
    private float tiempo = 30f;
    public Text fin;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = " "+ tiempo;
        fin.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo-= Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");

        if(tiempo <=0)
        {
            contador.text="0";
            fin.enabled=true;
        }
    }
}
