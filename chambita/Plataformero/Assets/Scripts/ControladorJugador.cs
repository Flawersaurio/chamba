using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 0;
    private Rigidbody2D MiCuerpo;
    private Animator miAnimador;
    public bool enPiso; //Grounded
    public int saltoExtra = 0;

    // Start is called before the first frame update
    void Start()
    {
        /*Al atributi MiCueroi le asigno
          el componente RigidBody2D de
          este personaje*/
        MiCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*La comprobación de Piso
         es lo primero que se hace
        cada frame*/
        comprobarPiso();
        if (enPiso)
        {
            miAnimador.SetBool("EnPiso", true);
        }
        if (!enPiso)
        {
            miAnimador.SetBool("EnPiso", false);
        }

        float velActualVert = MiCuerpo.velocity.y;

        if (enPiso == true)
        {
            saltoExtra = 1;
        }

        /*Leo si el jugador está presionando un
         eje horizontal en las flechas*/
        float movHorizontal = Input.GetAxis("Horizontal");
        if (movHorizontal > 0)  //Derecha
        {
            transform.rotation= Quaternion.Euler(0, 0, 0);
            //El 3 es Hardcore :(     //Parametrizado :D
            MiCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHorizontal < 0) //Izquierda
        {

            transform.rotation = Quaternion.Euler(0, 180, 0);
            MiCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            {
                MiCuerpo.velocity = new Vector3(0, velActualVert, 0);
                miAnimador.SetBool("CAMINANDO", false);
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (enPiso == true)
            {
                MiCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
            }
            else if (enPiso == false && saltoExtra > 0)
            {
                MiCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
                saltoExtra = saltoExtra - 1;
            }

        }

        miAnimador.SetFloat("VEL.VERT", velActualVert);
    }

    void comprobarPiso()
    {
        /*Lanzo un rayo de deteccion
         de colisiones hacia abajo
        desde la posición de este
        objeto (Personaje)*/       //Desde donde       //Hacia donde //distancia   
        enPiso = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
    }
}