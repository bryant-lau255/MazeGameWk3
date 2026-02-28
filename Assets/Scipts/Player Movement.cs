using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int testValue = 168;
    public float JumpHeight = 150f;
    
    public Rigidbody rb;

    void Update()
    {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

        

        Vector3 movement = new Vector3(x, 0f, z);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);

       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*JumpHeight);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed * 1.5f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed / 1.5f;
        }
    }

}
