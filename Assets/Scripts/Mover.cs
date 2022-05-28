using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 2f;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) {return;}
        float cycles = Time.time / period; // continualy grows over time

        const float tau = Mathf.PI * 2; // cosntant value of 6.283
        float rawSineWave = Mathf.Sin(cycles * tau); // going from -1 to 1

        movementFactor = (rawSineWave + 1f) / 2f; // recalculated to go from 0 - 1 so its cleaner

        Vector3 offest = movementVector * movementFactor;
        transform.position = startingPosition + offest;
    }
}
