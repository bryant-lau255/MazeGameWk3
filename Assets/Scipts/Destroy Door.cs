using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("Door unlocked");
            door.SetActive(false);
        }
    }
}
