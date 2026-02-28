using UnityEngine;

public class OrbCollectible : MonoBehaviour
{
    public OrbScoreManager scoreManager;

    //public int targetScore = 3;
    //public int currentScore;

    //public GameObject door;

    //private void Awake()
    //{
    //    currentScore = 0;
    //}
    //private void Update()
    //{
    //    Debug.Log("Current score: " + currentScore);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        currentScore++;
    //        Debug.Log("Current score: " +currentScore);
    //        if (currentScore == targetScore)
    //        {
    //            door.SetActive(false);
    //            Debug.Log("Door open");
    //        }
    //        gameObject.SetActive(false);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.AddScore();
            gameObject.SetActive(false);
        }
            
    }
}
