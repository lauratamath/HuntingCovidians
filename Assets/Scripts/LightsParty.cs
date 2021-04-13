using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsParty : MonoBehaviour
{
    private Light emergencyLight;
    private int intensidad = 13;
    private int frec = 3;
    // Start is called before the first frame update
    void Start()
    {
        emergencyLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (emergencyLight)
            emergencyLight.intensity = intensidad * Mathf.Sin(frec * Time.time);
    }


    private void OnTriggerExit(Collider other)
    {
        if (emergencyLight)
            emergencyLight.intensity = 0;
    }
}
