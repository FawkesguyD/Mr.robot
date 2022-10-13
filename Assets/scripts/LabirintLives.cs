using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabirintLives : MonoBehaviour
{
    MeshRenderer mr;
   [SerializeField] int hits = 10;
   
    public void OnCollisionEnter(Collision other) {
        
    
        if (other.gameObject.tag == "Lose")
        {
            hits -= 1;
            Debug.Log(hits);
        }
        if (hits == 0) {
            ReloadLevel();
        }
   }

   private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
   }

