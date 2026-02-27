using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Vector3 rotateAmount;

    void Update()
    {
        transform.Rotate(rotateAmount);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Collect(other.gameObject);

        }
    }

    void Collect(GameObject player)
    {

        Debug.Log("Item Collected!");

        Destroy(gameObject);

    }
    
}
