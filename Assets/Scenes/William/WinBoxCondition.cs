using UnityEngine;
using UnityEngine.SceneManagement;

public class WinBoxCondition : MonoBehaviour
{
    public string nextSceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You won yippee");
            SceneManager.LoadScene(nextSceneName);
            // Level Won
            // Change scene
        }
    }
}
