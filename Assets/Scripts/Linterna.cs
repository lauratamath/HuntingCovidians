using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public bool encendida = true;
    private AudioSource onOff;
    private Light luz;

    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
        onOff = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (luz && Input.GetMouseButtonDown(0))
        {
            encendida = !encendida;
            luz.enabled = encendida;
            if (onOff) onOff.Play();
        }
    }

}