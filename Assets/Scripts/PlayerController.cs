using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float MoveSpeed = 12f; //Player movment speed (WSAD)
    [SerializeField] CharacterController controller;

    // Well to see what's happening you need to update per frame (duh)
    void Update()
    {
       float x = Input.GetAxis("Horizontal") ;
       float z = Input.GetAxis("Vertical");

       Vector3 move = transform.right * x + transform.forward * z;

       controller.Move(move * MoveSpeed * Time.deltaTime);
    }

}