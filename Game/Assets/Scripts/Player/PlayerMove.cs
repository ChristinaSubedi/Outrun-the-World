using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Space.world as the movement (run) is relative to the world around it
        transform.Translate(Vector3.forward *  moveSpeed * Time.deltaTime, Space.World);
    }
}
