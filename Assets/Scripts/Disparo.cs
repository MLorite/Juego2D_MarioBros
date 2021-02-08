using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public GameObject puntoDisparo;
    public Vector3 dirDisp = Vector3.right;
    public float vel = 14;
    public Animator miAnim;
    public Animator miAnimPistola;
    public AudioSource disparo;
    public bool disparador = false;
    public GameObject pistola;

    // Start is called before the first frame update
    void Start()
    {
        pistola.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Actualizar ladireccion de disparo
        if (Input.GetKeyDown(KeyCode.J))
        {
            Disparar();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            dirDisp = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            dirDisp = Vector3.right;
        }


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Quest")
        {
            disparador = true;
            pistola.SetActive(true);
        }

    }

    void Disparar()
    {
        if (disparador == true) { 
        GameObject newBala = (GameObject) Instantiate(bala, puntoDisparo.transform.position, this.transform.rotation);
        newBala.GetComponent<Rigidbody>().velocity = dirDisp * vel;

        miAnim.SetTrigger("Shoot");
        miAnimPistola.SetTrigger("Shoot");
        disparo.Play();
        //Delay, se destruye pasado los 2s 
        Destroy(newBala, 2);
        }
    }
}
