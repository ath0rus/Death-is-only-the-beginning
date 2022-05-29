using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float MoveSpeed = 12f; //Player movment speed (WSAD)
    [SerializeField] CharacterController controller;
    bool audioResumed = false;

    // Well to see what's happening you need to update per frame (duh)
    void Update()
    {
       float x = Input.GetAxis("Horizontal") ;
       float z = Input.GetAxis("Vertical");

       Vector3 move = transform.right * x + transform.forward * z;

       controller.Move(move * MoveSpeed * Time.deltaTime);
    }
    private void Start()
    {
        ResumeAudio(); 
    }

    public void ResumeAudio()
    {
        if (!audioResumed)
        {
            var result = FMODUnity.RuntimeManager.CoreSystem.mixerSuspend();
            Debug.Log(result);
            result = FMODUnity.RuntimeManager.CoreSystem.mixerResume();
            Debug.Log(result);
            audioResumed = true;
        }
    }
}