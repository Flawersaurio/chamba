using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorjugador : MonoBehaviour
{
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 0;
    public bool enPiso = false; //Grounded
    public int dobleSalto;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public int saltosDisp = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Al atributo MiCuerpo le asigno el componente rigidbody 2d de este  pesonaje 
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        comprobarPiso();


        float velActualVert = miCuerpo.velocity.y;

        if (dobleSalto <= 0)
        { 
            if (enPiso == true)
            {
                dobleSalto = 2;
            }
        
        }

        //Leo si el jugador esta presionando un eje horizontal en las flechas
        float movHoriz = Input.GetAxis("Horizontal");
        if(movHoriz > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);                           
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);

        }
        else if (movHoriz < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);

        }
        else
        {

            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("Caminando", false);

        }//salto
        if (Input.GetButtonDown("Jump"))
        {
            miCuerpo.AddForce(new Vector3(0, *fuerzaSalto, 0), ForceMode2D.Impulse);

            miAnimadorSetBool("Jump", true)
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (enPiso == true)
            {
                miCuerpo.AddForce(new Vector3(0))

            }

            if (enPiso)
            {
                 saltosDisp = 1;   
            }

            if (saltosDisp > 0)
            {
                     if (Input.GetButtonDown ("Jump"))
                     {
                         miCuerpo.AddForce(transform.up * fuerzaSalto, ForceMode2D.Impulse);

                          saltosDisp--;
                     }

            }

        }




        miAnimador.SetFloat("VEL_VERT", velActualVert);

    }

   
    void comprobarPiso()
    {

        enPiso = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

    }




}
