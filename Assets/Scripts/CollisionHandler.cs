using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] Transform spawn;
    [SerializeField] GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected!");
        print("I, " + this.name +  " collided with trigger object " + other.name);
        Player.transform.position = spawn.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected!");
        print("I, " + this.name + " collided with trigger object " + collision.body);
        Player.transform.position = spawn.transform.position;
    }
}