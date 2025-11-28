using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("BasicScene");
    }
}
