using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour
{

    public float speed;
    public GameObject follow;
    private Transform target;
    // Update is called once per frame
    void Start()
    {
        target = follow.transform;
    }
    void Update()
    {
    
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,target.position,step);
    
    }
}
