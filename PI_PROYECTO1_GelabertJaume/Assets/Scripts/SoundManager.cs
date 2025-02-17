using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip Coin, Jump;

    public static AudioClip CoinSound, JumpSound;
    static AudioSource audioSRC;


    // Start is called before the first frame update
    void Start()
    {
        audioSRC = GetComponent<AudioSource>();
        JumpSound = Jump;
        CoinSound = Coin;
    }

    public static void PlaySound(string soundClip)
    {
        switch(soundClip)
        {
            case "Coin":
                audioSRC.PlayOneShot(CoinSound);
                break;
            case "Jump":
                audioSRC.PlayOneShot(JumpSound);
                break;
        }
    }
}
