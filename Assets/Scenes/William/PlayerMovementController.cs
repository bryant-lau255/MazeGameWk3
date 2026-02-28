using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 200f;

    public bool isGrounded = true;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new(x, 0f, z);
        transform.Translate(moveSpeed * Time.deltaTime * movement, Space.Self);
        //rb.AddForce(movement * moveSpeed,ForceMode.Impulse);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log("Jump");
        }
    }
}
