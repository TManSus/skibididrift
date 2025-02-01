using UnityEngine;

public class MoverAutito : MonoBehaviour
{
    public float carSpeed;
    public Rigidbody car;
    public AudioSource carSound;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GoForward();
        GoBack();
    }

    void GoForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            car.AddForce(Vector3.right * -carSpeed, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            carSound.Play();
        }
    }

    void GoBack()
    {
        if (Input.GetKey(KeyCode.S))
        {
            car.AddForce(Vector3.right * carSpeed, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            carSound.Play();
        }
    }
}
