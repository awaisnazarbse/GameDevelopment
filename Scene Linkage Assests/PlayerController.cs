using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
private float movement = 0f;
    private float jumpspeed = 20f;
    private float speed = 5f;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
            }

    // Update is called once per frame
    void Update()
    {
        float movementx=Input.GetAxis("Mouse X");
        float movementy=Input.GetAxis("Mouse Y");
        if(movementx>0 && movementy>0)
        {
            print("Quadrant 1");
            print("X-Axis"+movementx);
            print("Y-Axis"+movementy);
        }
        if(movementx<0 && movementy>0)
        {
            print("Quadrant 2");
            print("X-Axis"+movementx);
            print("Y-Axis"+movementy);
        }
        if(movementx<0 && movementy<0)
        {
            print("Quadrant 3");
            print("X-Axis"+movementx);
            print("Y-Axis"+movementy);
        }
        if(movementx>0 && movementy<0)
        {
            print("Quadrant 4");
            print("X-Axis"+movementx);
            print("Y-Axis"+movementy);
        }
    //     movement = Input.GetAxis("Horizontal");
    //     Debug.Log(movement);

    //     if (movement > 0)
    //     {
    //         rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
            
    //     }
    //     else if (movement < 0)
    //     {
    //         rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
    //     }
    //     else
    //     {
    //         rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
    //     }
    //     if (Input.GetButtonDown("Down"))
    //     {
    //         rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpspeed);
    //     }
    //     movement = Input.GetAxis("Vertical");
    //      Debug.Log(movement);

    //      if (movement > 0)
    //      {
    //          rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.x);

    //      }
    //      else if (movement < 0)
    //      {
    //          rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.x);
    //      }
    //      else
    //      {
    //          rigidbody.velocity = new Vector2(0, rigidbody.velocity.x);
    //      }
    //      if (Input.GetButtonDown("Jump"))
    //     {
    //          rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpspeed);
    // }
    // }
}
}
