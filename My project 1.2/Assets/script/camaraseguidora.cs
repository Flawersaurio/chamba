using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraseguidora : MonoBehaviour
{
    //Este es un atributo de la clase que funciona
    //como referencia a la pelota en la escena
    public Transform Pelota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //se coloca la posicion de la pelota ne la camara, excepto en z 
        transform.position = new Vector3(Pelota.position.x, Pelota.position.y, -1);
    }
}
