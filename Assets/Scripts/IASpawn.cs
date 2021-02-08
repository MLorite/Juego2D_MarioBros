using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IASpawn : MonoBehaviour
{
    public GameObject enemigo;

    public float contador;
    public float cadencia = 2;

    public Vector3 dirSpawn = Vector3.right;

    public int min = 1;
    public int max = 6;

    // Start is called before the first frame update
    void Start()
    {
        CalculoAleatorio();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Actualizar contador
        contador = contador + Time.deltaTime;

        if (contador > cadencia)
        {
            //Crear un nuevo enemigo
            GameObject nuevoEnemy = (GameObject) Instantiate(enemigo, this.transform.position, this.transform.rotation);
            nuevoEnemy.GetComponent<IAmovil>().dir = dirSpawn;
            contador = 0;
            CalculoAleatorio();
        }

    }

    void CalculoAleatorio()
    {
        cadencia = Random.Range(min, max);
    }
}
