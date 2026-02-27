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

        bool grounded = Physics.Raycast(transform.position, -transform.up, transform.localScale.y / 2 + .2f);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector3.up*JumpHeight);
        }


        
    }

    void TestFunc()
    {



    }
}
