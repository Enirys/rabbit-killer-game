using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMovement : MonoBehaviour
{
    //Target position for each rabbit
    Vector3 targetPos;

    //Map Limits
    public float maxX;
    public float maxZ;
    public float minX;
    public float minZ;

    //Rabbit movement Speed
    public float moveSpeed;

    //Time to wait before moving rabbits
    public float timer;

    //Rabbit can move?
    public bool canMove = false;
    
    // Start is called before the first frame update
    void Start()
    {
        targetPos = GetRandomPosition();
        StartCoroutine(canMoveRabbit());
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            if (transform.position != targetPos)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            } else
            {
                canMove = false;
            }
        }
    }

    //Generate Random position
    public Vector3 GetRandomPosition()
    {
        float posX = Random.Range(minX, maxX);
        float posZ = Random.Range(minZ, maxZ);

        return new Vector3(posX, transform.position.y, posZ);
    }

    //Set canMove
    IEnumerator canMoveRabbit()
    {
        yield return new WaitForSeconds(timer);
        canMove = true;
    }
}
