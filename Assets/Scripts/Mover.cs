using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float vel = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
            //Girar o dar escala correcta
            this.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
            this.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
