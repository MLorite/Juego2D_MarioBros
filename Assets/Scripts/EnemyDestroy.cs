using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public GameObject efecto;
    public GameObject refEnemigo;
    public AudioSource audioEnemigoMuere;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(efecto, this.transform.position, this.transform.rotation);
            refEnemigo = GameObject.FindGameObjectWithTag("AudioEnemigo");
            audioEnemigoMuere = refEnemigo.GetComponent<AudioSource>();
            audioEnemigoMuere.Play();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
