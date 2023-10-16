using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace personaje
{
    public class Cartel_logic : MonoBehaviour
    {
        public GameObject informacion;
        public GameObject mostrarInformacion;

        public bool informacionHabilitada;
        public bool mostrarInformacionHabilitada;

        public LayerMask personaje;

        void Start()
        {
            informacion.SetActive(false);
            mostrarInformacion.SetActive(false);
        }

        void Update()
        {
            informacionHabilitada = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);

            if (informacionHabilitada)
            {
                informacion.SetActive(true);
            }
            else
            {
                informacion.SetActive(false);
            }

            mostrarInformacionHabilitada = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);

            if (mostrarInformacionHabilitada && Input.GetKeyDown(KeyCode.E))
            {
                mostrarInformacion.SetActive(true);
            }
            else
            {
                mostrarInformacion.SetActive(false);
            }
        }
    }
}

