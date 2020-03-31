using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    [SerializeField] float forwardAcceleration = 100f;
    [SerializeField] float rotationAcceleration = 30f;
    [SerializeField] KeyCode keyAccelerate = KeyCode.UpArrow;
    [SerializeField] KeyCode keyRotateLeft = KeyCode.LeftArrow;
    [SerializeField] KeyCode keyRotateRight = KeyCode.RightArrow;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(keyAccelerate))
        {
            rb.AddRelativeForce(Vector3.up * Time.deltaTime * forwardAcceleration);
        }

        if (Input.GetKey(keyRotateLeft))
        {
            rb.AddTorque(Vector3.forward * Time.deltaTime * rotationAcceleration);
        }

        if (Input.GetKey(keyRotateRight))
        {
            rb.AddTorque(Vector3.back * Time.deltaTime * rotationAcceleration);
        }
    }
}
