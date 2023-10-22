using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // El nombre de este espacio de nombres estaba escrito incorrectamente

public class PreguntaManager : MonoBehaviour
{
    public static PreguntaManager sPreguntaManager;
    public CargaPregunta cargaPregunta; // Corregí la mayúscula
    public List<Pregunta> preguntas;

    public int cantidadDeRespuestas = 4; // Si este es el número de respuestas por pregunta, 10 parece demasiado alto
    public int index;

    public int puntaje;
    public Text puntajeUI;

    public int preguntasRun;
    public int maxPreguntasRun = 5;

    private void Awake()
    {
        sPreguntaManager = this;
        preguntasRun = 1;

        // No destruir preguntaManager
        DontDestroyOnLoad(gameObject);

        // pregunta random al inicio
        for (int i = 0; i < cantidadDeRespuestas; i++) // Cambié la condición a "i < cantidadDeRespuestas"
        {
            int a = Random.Range(0, preguntas.Count); // Cambié "Ramdom" a "Random" y corregí el uso de "Random.Range"
            index = a;
        }
    }

    public void Responder(bool respuestaCorrecta)
    {
        if (respuestaCorrecta)
        {
            sPreguntaManager.puntaje += 200;
        }
        else
        {
            Debug.Log("Wrong");
        }

        // preguntas randomizadas
        for (int i = 0; i < cantidadDeRespuestas; i++) // Cambié la condición a "i < cantidadDeRespuestas"
        {
            int a = Random.Range(0, preguntas.Count);
            index = a;
        }

        // solo 5 preguntas
        if (preguntasRun == maxPreguntasRun)
        {
            SceneManager.LoadScene("final"); // Cambié "SceneManeger" a "SceneManager" y "LoasScene" a "LoadScene"
        }

        // actualizar puntaje
        puntajeUI.text = "puntaje = " + puntaje.ToString(); // Cambié "Tostring" a "ToString"

        preguntasRun++;
        ShowNextQuestion();
    }

    public void ShowNextQuestion()
    {
        cargaPregunta.pregunta = preguntas[index];
        cargaPregunta.ShowQuestion();
    }

    private void Start()
    {
        ShowNextQuestion();
    }
}
