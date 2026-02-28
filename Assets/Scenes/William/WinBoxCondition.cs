using UnityEngine;

public class WinBoxCondition : MonoBehaviour
{
    public GameObject door;
    public GameObject orbA;
    public GameObject orbB;
    public GameObject orbC;

    private void Update()
    {
        // If all orbs are collected, destroy door
        if (!orbA.activeSelf && !orbB.activeSelf && !orbC.activeSelf)
        {
            door.SetActive(false);
            Debug.Log("Door open");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You won yippee");
            // Level Won
            // Change scene
        }
    }
}
