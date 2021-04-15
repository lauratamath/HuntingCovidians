using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text tiempoInicio;
    public Text tiempoTotal;
    
    private float tiempo = 3.0f;
    private float tiempoTota = 120.0f;
    public UnityEngine.AI.NavMeshAgent agent;
    

    // Update is called once per frame
    void Update()
    {
       if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            tiempoInicio.text = "" + tiempo.ToString("f0");
          //  agent.enabled = false;
            tiempoInicio.enabled = true;
        }
        else
        {
          //  agent.enabled = true;
            tiempoInicio.enabled = false;
            tiempoTota -= Time.deltaTime;
            tiempoTotal.text = "Tiempo: 00" + tiempoTota.ToString("f0");
        }

        

    } 
    
}
