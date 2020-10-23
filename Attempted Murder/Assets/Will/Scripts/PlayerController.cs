using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // movement variables
    public float moveSpeed = 4f;

    Rigidbody playerBody;

    Vector3 forward;
    Vector3 right;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();

        forward = Camera.main.transform.forward;
        forward.y = 0; // set to zero or else player will be pushed into the ground while moving forward
        right = Camera.main.transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        MoveControls();
        
    }
    // Move the player
    void MoveControls()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerBody.AddForce(forward * moveSpeed);
            Debug.Log(this.gameObject.transform.position);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerBody.AddForce(forward * -moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerBody.AddForce(right * -moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerBody.AddForce(right * moveSpeed);
        }
    }
}
