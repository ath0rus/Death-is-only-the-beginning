using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float MoveSpeed = 0.1f; //Player movment speed (WSAD)
    [SerializeField] float RotSpeed = 1f; //Player rotation speed (Mouse/Arrow keys)

    // Setup stuff, Idk how it works, it just .... does, It's Magic
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //probs pointless
        rb.freezeRotation = true; //prevents issues
    }

    // Well to see what's happening you need to update per frame (duh)
    void Update()
    {
        ProcessMovement();
        ProcessRotation();
    }


    //Process the player movment, For the game to work you need to move
    void ProcessMovement()
    {
       if (Input.GetKey(KeyCode.W))
       {
            rb.AddRelativeForce(Vector3.forward * MoveSpeed * Time.deltaTime);
       }
       else if (Input.GetKey(KeyCode.S))
       {
            rb.AddRelativeForce(Vector3.back * MoveSpeed * Time.deltaTime);
       }
        else if (Input.GetKey(KeyCode.A))
       {
            rb.AddRelativeForce(Vector3.left * MoveSpeed * Time.deltaTime);
       }
        else if (Input.GetKey(KeyCode.D))
       {
            rb.AddRelativeForce(Vector3.right * MoveSpeed * Time.deltaTime);
       }
        
        
    }

    //Process player rotation, This game will be boring if you can't look about
    void ProcessRotation()
    {

    }


}