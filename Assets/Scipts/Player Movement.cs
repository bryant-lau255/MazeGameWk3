using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int testValue = 168;


    void Update()
    {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

        

        Vector3 movement = new Vector3(x, 0f, z);
        Debug.Log("This is movement Vetor:" + movement);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);




        
    }

    void TestFunc()
    {



    }
}
