using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // El nombre del espacio de nombres estaba escrito incorrectamente
using UnityEngine.UI;

public class ReiniciarJuego : MonoBehaviour
{
    public Text puntajeUI;

    void Awake() // El nombre del método Awake estaba escrito incorrectamente
    {
        puntajeUI.text = "puntaje = " + PreguntaManager.sPreguntaManager.puntaje.ToString(); // Cambié "puntaje" a "puntajeUI" y "Tostring" a "ToString"
    }

    public void Reiniciar()
    {
        Destroy(GameObject.Find("preguntaManager")); // Cambié "gameObject.Find" a "GameObject.Find" y "pregunta Manager" a "preguntaManager"
        SceneManager.LoadScene("SampleScene");
    }
}
