using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladordecamara : MonoBehaviour
{
    public Transform personaje;

    private float tamañoCamara;
    private float alturaPantala;
    // Start is called before the first frame update
    void Start()
    {
        tamañoCamara = Camera.main.orthographicSize;
        alturaPantala = tamañoCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}