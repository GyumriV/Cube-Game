using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
   public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
