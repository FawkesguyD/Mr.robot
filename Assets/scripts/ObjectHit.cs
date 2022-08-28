using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
void  OnCollisionEnter(Collision other) {
    

    switch (other.gameObject.tag)
    {
        case "Lose":
        ReloadLevel(); break;
        case "Dictionary":
        LoadNextLevel(); break;
    }

}

private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
void LoadNextLevel()
{
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    int nextSceneIndex = currentSceneIndex + 1;
    if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
    {
        nextSceneIndex = 0;
    }
}
}
