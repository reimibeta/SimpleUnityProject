using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public static Bouncing instance;

    [SerializeField]
    private float speed = 20;
    private Rigidbody rigidBody;
    void Start()
    {
        if (instance == null)
            instance = this;
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            print("Collision Ground");
            rigidBody.AddForce(0, speed, 0,ForceMode.Impulse);
        }
    }
}
