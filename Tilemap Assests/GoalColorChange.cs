using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalColorChange : MonoBehaviour
{
    public SpriteRenderer sprnd;
    // Start is called before the first frame update
    void Start()
    {
        sprnd = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // void OnCollisionEnter2D(Collision2D col)
    // {           
    //          sprnd.color = Color.blue;
    // }
    void OnTriggerEnter2D(Collider2D c)
     {
         sprnd.color = Color.green;
     }
     void OnTriggerExit2D(Collider2D c)
     {
         sprnd.color = Color.white;
     }
}
