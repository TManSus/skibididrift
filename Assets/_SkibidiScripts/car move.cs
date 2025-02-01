using UnityEngine;

public class carmove : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddTorque(0, 0, 10, ForceMode.Force);
        }
    }
}
