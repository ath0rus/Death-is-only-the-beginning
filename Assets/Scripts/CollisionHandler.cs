using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] Transform spawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) 
    {
        switch (other.gameObject.tag)
        {
            case "Trap":
            Debug.Log("Trap has been hit");
            // transform.position = spawn.position;
            break;
        }
    }
}