using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_move : MonoBehaviour
 {
    public GameObject limLeft;
    public GameObject limRight;

    public GameObject limUp;

    public GameObject limDown;
    public float movementDuration;
    public bool hasArrived = false;
    private Vector3 targetPos;
    private void Start(){
        hasArrived = false;
    }
    private void Update()
    {
        if (!hasArrived) // 1
        {
            Debug.Log("Hello");
            hasArrived = true;
            float randX = Random.Range(limLeft.transform.position.x, limRight.transform.position.x);
            float randY = Random.Range(limDown.transform.position.y, limUp.transform.position.y);
            targetPos = new Vector3(randX,randY,0);

            StartCoroutine(MoveToPoint(targetPos));
            
        }
    }
 
    private IEnumerator MoveToPoint(Vector3 targetPos)
    {
        float timer = 0.0f;
        Vector3 startPos = transform.position;
 
        while (timer < movementDuration)
        {
            timer += Time.deltaTime;
            float t = timer / movementDuration;
            transform.position = Vector3.Lerp(startPos, targetPos, t);
 
            yield return null;
        }
        hasArrived = false;
        yield return new WaitForSeconds(1f);
    }
}