using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //public float speed = 3;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical") * 10;
        float horizontal = Input.GetAxis("Horizontal") * 10;
        Vector3 translate = new Vector3(horizontal, rb.velocity.y, vertical);
        transform.LookAt(transform.position + new Vector3(horizontal, 0, vertical));
        rb.velocity = translate;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

}
