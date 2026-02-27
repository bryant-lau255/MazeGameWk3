using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    
    public int groundLayer = 3; // Layer 3 is Ground

    public PlayerMovementController player;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == groundLayer) 
            player.isGrounded = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == groundLayer)
            player.isGrounded = false;
    }
}
