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
            rb.AddTorque(transform.forward.x * 10, transform.forward.y * 10, transform.forward.z * 10, ForceMode.Force);
        }
        CamHandle();
    }
    void CamHandle()
    {
        cameraParentGO.transform.position = transform.position;
        cameraGO.transform.rotation = Quaternion.Euler(10, transform.rotation.y -90, 0);
        cameraGO.transform.rotation = Quaternion.Euler(10, transform.rotation.y - 90, 0);
    }
}
