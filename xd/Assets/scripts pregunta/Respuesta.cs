using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta : MonoBehaviour
{
    public bool esCorrecta;

    public void Responder()
    {
        PreguntaManager.sPreguntaManager.Responder(esCorrecta);
    }
}
