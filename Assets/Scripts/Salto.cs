using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public Rigidbody miRigid;
    public float vel;

    public bool tocoSuelo = false;
    public AudioSource audioSalto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tocoSuelo = false;

        //Comprobar si toco suelo
        RaycastHit resultadoRayo;
        if (Physics.Raycast(this.transform.position, Vector3.down, out resultadoRayo, 0.51f))
        {
            if ((resultadoRayo.transform.tag == "Suelo") || (resultadoRayo.transform.tag == "Quest"))
            {
                tocoSuelo = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && tocoSuelo == true)
        {
            miRigid.velocity = Vector3.up * vel; // Aplicar velocidad ascendente
            audioSalto.Play();
        }
        
    }
}
