using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip coinSound;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("CoinSound");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip){
        switch(clip)
        {
            case "CoinSound":
                audiosrc.PlayOneShot(coinSound);
                break;
        }
        
    }
}
