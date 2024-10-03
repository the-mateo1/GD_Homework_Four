using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollisions : MonoBehaviour
{
    int collisionCount = 0;
    private Quaternion originalRotation;

    private void OnCollisionEnter(Collision other) {
        collisionCount++;
        Debug.Log("You have crashed " + collisionCount + " times");

        if(other.gameObject.tag == "Hostile")
        {
            Respawn();
        }
    }

    void Respawn() {
        transform.position = new Vector3(0.0f, 3.5f, -7.0f);
        transform.rotation = originalRotation;
    }
    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}