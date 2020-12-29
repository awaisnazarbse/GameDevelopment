using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangePackage : MonoBehaviour
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
    void OnCollisionEnter2D(Collision2D col)
    {           
                 sprnd.color = Color.red;
               
    }
    void OnCollisionExit2D(Collision2D col)
    {           
             sprnd.color = Color.white;
    }
    // void OnTriggerEnter2D(Collider2D c)
    // {
    //     sprnd.color = Color.green;
    // }
}
