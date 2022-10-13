using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{

    [SerializeField] int lives = 10;
void  OnCollisionEnter(Collision other) {
    

    switch (other.gameObject.tag)
    {
        case "Lose":
        lives --; Debug.Log(lives); break;
        case "Finish":
        LoadNextLevel(); break;
    }

    if (lives == 0)
        ReloadLevel();

}

private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
private void LoadNextLevel()
{
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    int nextSceneIndex = currentSceneIndex + 1;
    if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
    {
        nextSceneIndex = 0;
    }
}
}
