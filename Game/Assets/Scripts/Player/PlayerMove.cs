using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float leftRightSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Space.world as the movement (run) is relative to the world around it
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        //moving left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * -leftRightSpeed);
        }
    }
}
