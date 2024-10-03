using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    
    [SerializeField] float mainThrust = 1f;
    [SerializeField] float rotationThrust = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessRotation();
        ProcessThrust();
    }

    // Rocket Rotation Movement
    void ProcessRotation()
    {
        if(Input.GetKey(Keycode.J))
        {
            ApplyRotation(rotationThrust);
            Debug.Log("pressed J - rotating left");
        }
        if(Input.GetKey(Keycode.L))
        {
            ApplyRotation(-rotationThrust);
            Debug.Log("pressed L - rotating right");
        }    
    }

    void ApplyRotation(float rotationThisFrame)
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        GetComponent<Rigidbody>().freezeRotation = false;
    }

    // Rocket Thrust Movement
    void ProcessThrust()
    {
        if(Input.GetKey(Keycode.W))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
            Debug.Log("pressed W");
        }
    }
}