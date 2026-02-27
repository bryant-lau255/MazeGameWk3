using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitionCollider : MonoBehaviour
{
    public string sceneToLoad;

   
    
    public void LoadGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    } 
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
         {
            LoadGame();
            Debug.Log("Player entered trigger, loadingscene:" + sceneToLoad);
         }

    }
}
