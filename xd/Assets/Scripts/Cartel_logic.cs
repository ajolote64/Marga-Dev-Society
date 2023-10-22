using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace personaje
{
    public class Cartel_logic : MonoBehaviour
    {
        public GameObject informacion;
        public LayerMask personaje;

        void Start()
        {
            informacion.SetActive(false);
        }

        void Update()
        {
            bool informacionHabilitada = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (informacionHabilitada)
                {
                    informacion.SetActive(true);
                    Time.timeScale = 0f; // Pausar el juego mientras se muestra el cartel
                }
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {   
                informacion.SetActive(false);
                Time.timeScale = 1f; // Despausar el juego al salir del cartel
            }
        }
    }
}



