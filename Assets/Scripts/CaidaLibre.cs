﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaLibre : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           // other.gameObject.SetActive(false);
        } else
        {
            Destroy(other.gameObject);
        }
        
    }


}
