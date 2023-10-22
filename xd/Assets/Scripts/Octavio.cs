using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octavio : MonoBehaviour
{
    public Transform personaje; // El objeto jugador
    public float velocidadMovimiento = 1.0f; // La velocidad de movimiento del NPC

    bool interactuando = false;

    void Update()
    {
        if (!interactuando)
        {
            // Mueve el NPC hacia el jugador
            transform.LookAt(personaje);
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime, Space.Self);
        }
    }

    public void IniciarConversacion()
    {
        // Aquí puedes poner el código para iniciar la conversación
        Debug.Log("Hola, soy el NPC. ¿Cómo estás?");
    }

    public void Irse()
    {
        // Aquí puedes poner el código para que el NPC se vaya caminando
        Debug.Log("Adiós, nos vemos luego.");
        Destroy(gameObject); // Destruye el NPC una vez se va
    }
}
