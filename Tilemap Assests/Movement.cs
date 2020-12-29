using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
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
        movement = Input.GetAxis("Horizontal");
        Debug.Log(movement);

        if (movement > 0)
        {
            rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);

        }
        else if (movement < 0)
        {
            rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
        }
        else
        {
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }
        if (Input.GetButtonDown("Down"))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpspeed);
        }
        movement = Input.GetAxis("Vertical");
         Debug.Log(movement);

         if (movement > 0)
         {
             rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);

         }
         else if (movement < 0)
         {
             rigidbody.velocity = new Vector2(movement * speed, rigidbody.velocity.y);
         }
         else
         {
             rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
         }
         if (Input.GetButtonDown("Jump"))
        {
             rigidbody.velocity = new Vector2(rigidbody.velocity.y, jumpspeed);
    }
    }
}
