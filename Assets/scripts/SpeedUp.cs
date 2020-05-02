using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    // Start is called before the first frame update
    public Random_move fish;
    private Collider myCollider;
    private Rigidbody myRigidbody;
    private float init;
    public float speed;
    void Start()
    {
        
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
        init = fish.movementDuration;
        InvokeRepeating("Relax", 1f, .5f);
 
    }
    // Update is called once per frame   
    private void OnTriggerEnter (Collider other) // 1
    {
        if (other.CompareTag("Arm"))
        {
            Speed();
            
        }
    }
    private void Speed()
    {
        fish.movementDuration = speed; 
    }
    private void Relax(){
        if(!fish.hasArrived){
            fish.movementDuration = init;
        }
    }
}
