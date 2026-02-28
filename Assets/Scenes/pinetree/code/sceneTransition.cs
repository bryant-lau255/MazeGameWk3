using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransition : MonoBehaviour
{
    public string gameSceneName;
    public void LoadGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
