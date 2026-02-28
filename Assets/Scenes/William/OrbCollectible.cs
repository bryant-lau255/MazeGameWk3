using UnityEngine;

public class OrbCollectible : MonoBehaviour
{
    public int targetScore = 3;
    public int currentScore = 0;

    private void Start()
    {
        currentScore = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentScore++;
            gameObject.SetActive(false);
        }
    }
}
