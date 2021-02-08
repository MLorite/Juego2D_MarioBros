using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAmovil : MonoBehaviour
{
    public float vel = 2;

    //Direccion en la que se va a mover por defecto
    public Vector3 dir = Vector3.right;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(dir * vel * Time.deltaTime, Space.World);
    }
}
