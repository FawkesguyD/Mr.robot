using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
        private void OnControllerColliderHit(ControllerColliderHit hit) {
            switch (hit.gameObject.tag)
        {
            case ("Cafe"):
                NextLevel();
                break;
        }
        void NextLevel(){
            SceneManager.LoadScene("Cafe");
        }
        }
}
