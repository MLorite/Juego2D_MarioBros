using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaVida : MonoBehaviour
{
    public int vida;
    public int topeVida = 3;
    public Text vidasTx;

    public AudioSource audioVida;
    public AudioSource audioGameOver;
    public AudioSource audioFinish;


    // Start is called before the first frame update
    void Start()
    {
        vida = topeVida;
        vidasTx.text = "Vidas = " + vida;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
            vida = vida - 1; //vida -=1;
            Destroy(other.gameObject);

            CheckinMuerte();
            
        }
        if (other.gameObject.tag == "Vida")
        {
           // if (vida < topeVida){}  si quiero que sume por encima del topeVida
                vida = vida + 1;
                audioVida.Play();
        }
        vidasTx.text = "Vidas = " + vida;
        if (other.gameObject.tag == "Finish")
        {
            audioFinish.Play();
            this.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EditorOnly")
        {
            vida = 0;
            CheckinMuerte();
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

    void CheckinMuerte()
    {
        if (vida <= 0)
        {
            vida = 0;
            audioGameOver.Play();
            this.gameObject.SetActive(false);
        } 
    }
}
