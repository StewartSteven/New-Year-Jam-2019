using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    float waitTime = 0.50f;
    float moveAmount;
    float moveSpeed = 1.5f;
    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("move");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator move()
    {
        moveAmount = Random.Range(5, 5);
        nextPos = transform.position;
        while (true)
        {
            nextPos = transform.position;
            nextPos.y = (Random.value < 0.5) ? moveAmount : -moveAmount;
            moveAmount = Random.Range(15, 10);
            nextPos.x = (Random.value < 0.5) ? -moveAmount : moveAmount;
            while(transform.position != nextPos)
            {
                transform.position = Vector3.MoveTowards(transform.position, nextPos, Time.deltaTime * moveSpeed);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}
