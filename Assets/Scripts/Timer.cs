using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text tiempoInicio;
    public Text tiempoTotal;
    public GameObject winner;
    public GameObject loser;
    public GameObject win;
    private float tiempo = 3.0f;
    private float tiempoTota = 120.0f;
    public UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

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

        if (tiempoTota < 0)
        {
            Time.timeScale = 0.0f;
            winner.SetActive(true);
            loser.SetActive(true);
        }
        


    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.0f;
            if (tiempoTota >= 0)
            {
                winner.SetActive(true);
                win.SetActive(true);
            }
            else
            {
                winner.SetActive(true);
                loser.SetActive(true);
            }
        }

    } 
        
    
}
