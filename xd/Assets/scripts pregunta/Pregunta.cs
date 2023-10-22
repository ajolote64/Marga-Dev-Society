using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pregunta", menuName = "Clase Tarde/Pregunta", order = 2)]
public class Pregunta : ScriptableObject
{


    public string preguntaTexto;
    public string respuestaCorrecta;
    public List<string> RespuestasIncorrectas;
}
