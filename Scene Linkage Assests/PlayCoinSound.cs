using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCoinSound : MonoBehaviour
{
    public AudioSource ticksource;
    // Start is called before the first frame update
    void Start()
    {
        ticksource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        ticksource.Play();
        if(other.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject);
        }
       
    }
}
