using UnityEngine;

public class OrbCollectible : MonoBehaviour
{
    public int targetScore = 3;
    int currentScore = 0;

    public GameObject door;

    private void Start()
    {
        currentScore = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentScore++;
            if (currentScore == targetScore)
            {
                door.SetActive(false);
                Debug.Log("Door open");
            }
            gameObject.SetActive(false);
        }
    }
}
