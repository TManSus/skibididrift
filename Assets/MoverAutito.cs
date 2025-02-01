using UnityEngine;

public class MoverAutito : MonoBehaviour
{
    public float carSpeed;
    public Rigidbody car;
    public AudioSource carSound;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (Input.GetKey(KeyCode.W))
        {
            car.AddForce(Vector3.right * -carSpeed, ForceMode.Acceleration);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            carSound.Play();
        }
=======
        Destroy(gameObject);
>>>>>>> f3ec071af5fd2701399657dea67978a2c7820cfd
    }
}
