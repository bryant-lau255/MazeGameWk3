using UnityEngine;

public class OrbScoreManager : MonoBehaviour
{
    public int targetScore = 3;
    public int currentScore;

    public GameObject door;

    private void Awake()
    {
        currentScore = 0;
    }
    private void Update()
    {
        Debug.Log("Current score: " + currentScore);
        if (currentScore == targetScore)
        {
            door.SetActive(false);
            Debug.Log("Door open");
        }
    }

    public void AddScore()
    {
        currentScore++;
    }
}
