using UnityEngine;

public class carmove : MonoBehaviour
{
    Rigidbody rb;
    public GameObject cameraGO;
    public GameObject cameraParentGO;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(-transform.right * 10, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-transform.right * 10, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.right * 10, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(transform.right * 10, ForceMode.Force);
        }
        CamHandle();
    }
    void CamHandle()
    {
        cameraParentGO.transform.position = transform.position;
        cameraGO.transform.rotation = Quaternion.Euler(10, cameraGO.transform.rotation.eulerAngles.y, 0);
        cameraParentGO.transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 90, 0);
    }
}
