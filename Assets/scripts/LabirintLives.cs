using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintLives : MonoBehaviour
{
    MeshRenderer mr;
   [SerializeField] int hits = 20;
   
    public void OnCollisionEnter(Collision other) {
        
    
        if (other.gameObject.tag == "Hits")
        {
            hits -= 1;
            GetComponent<MeshRenderer>().enabled = true;
        }
   }
   }

