using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace personaje
{

    public class Mocimiento : MonoBehaviour
    {
        public float velocidad;
        private Rigidbody2D rigidBody;
        private bool mirandoDerecha = true;
        private Animator animator; 

     private void Start()
        {
         rigidBody = GetComponent<Rigidbody2D>();
         animator = GetComponent<Animator>();
         }

     // Update is called once per frame
         void Update()
        {
        ProcesarMovimiento();
        }

        void ProcesarMovimiento()
         {
            float inputMovimiento = Input.GetAxis("Horizontal");

            if(inputMovimiento != 0f)
            {
            animator.SetBool("Caminar", true);
            }
            else
            {
            animator.SetBool("Caminar", false);
            }

            rigidBody.velocity = new Vector2(inputMovimiento * velocidad, rigidBody.velocity.y);

            GestionarOrientacion(inputMovimiento);
         }

        void GestionarOrientacion(float inputmovimiento)
         {
            if ((mirandoDerecha == true && inputmovimiento < 0) || (mirandoDerecha == false && inputmovimiento > 0))
            {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }
        }
    }

}
