using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    FMOD.Studio.EventInstance footstepsEvent;

    void Start()
    {
        FMODUnity.RuntimeManager.LoadBank("Master", true);

        footstepsEvent = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/FootstepsMulti");
        footstepsEvent.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
    }
    private CharacterController characterController;

    float timer = 0.0f;

    [SerializeField]
    float footstepSpeed = 0.3f;

    private void Awake()
    {
        characterController = GetComponentInParent<CharacterController>();
    }

    private void PlayFootstep()
    {
        FMOD.Studio.PLAYBACK_STATE playbackState;
        footstepsEvent.getPlaybackState(out playbackState);
        footstepsEvent.start();
        if (playbackState == FMOD.Studio.PLAYBACK_STATE.PLAYING)
        {
            footstepsEvent.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
            footstepsEvent.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
            footstepsEvent.start(); 
        }
    }
 
    private void Update()
    {
        if (characterController.velocity != Vector3.zero)
        {
            if (timer > footstepSpeed)
            {
                PlayFootstep();
                timer = 0.0f;
            }

            timer += Time.deltaTime;
        }

        if (characterController.velocity == Vector3.zero)
        {
            footstepsEvent.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }


}
