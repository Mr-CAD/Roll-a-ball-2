using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    public float speedX;
    public float speedY;
    private int count;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb = GetComponent<Rigidbody>();
        count = 0;


    }
    void FixedUpdate()
    {

        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movementx = new Vector3(movementHorizontal, 0.0f, 0.0f);
        Vector3 movementy = new Vector3(0.0f, 0.0f, movementVertical);

        rb.AddForce(movementx * speedX);
        rb.AddForce(movementy * speedY);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

        }
    }
}
    

    
        











