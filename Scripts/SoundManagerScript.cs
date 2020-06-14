using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManagerScript : MonoBehaviour
{


    public static AudioClip chalkSound, clickWoodenSound, successSound, kidsSound, upRisingSound, moveSound, beepSound, happyStartSound, counterSound, clockSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        chalkSound = Resources.Load<AudioClip>("chalk");
        clickWoodenSound = Resources.Load<AudioClip>("clickwooden");
        moveSound = Resources.Load<AudioClip>("movement");
        kidsSound = Resources.Load<AudioClip>("Kids");
        beepSound = Resources.Load<AudioClip>("beep");
        counterSound = Resources.Load<AudioClip>("counter");
        clockSound = Resources.Load<AudioClip>("clock"); //upRising
        upRisingSound = Resources.Load<AudioClip>("upRising");
        happyStartSound = Resources.Load<AudioClip>("happyStart");
        successSound = Resources.Load<AudioClip>("success");
        

        audioSrc = GetComponent<AudioSource>();
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName != "Scene1" && sceneName != "Scene13" && sceneName != "Scene2" && sceneName != "Menu")
        {

            SoundManagerScript.PlaySound("counter");
           
        } else if (sceneName == "Scene1" || sceneName == "Scene13" || sceneName == "Scene2" || sceneName == "Menu")
            {

                SoundManagerScript.PlaySound("happyStart");

            }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {

        switch(clip)
        {
            case "clickwooden":         // works
                audioSrc.PlayOneShot(clickWoodenSound);
                
                break;

            case "success":         // works
                audioSrc.PlayOneShot(successSound);

                break;
            case "upRising":         // works
                audioSrc.PlayOneShot(upRisingSound);

                break;

            case "counter":
                audioSrc.PlayOneShot(counterSound);

                break;
            case "happyStart":         // works
                audioSrc.PlayOneShot(happyStartSound);

                break;

            case "beep":         // works
                audioSrc.PlayOneShot(beepSound);

                break;
            case "chalk":
                    audioSrc.PlayOneShot(chalkSound);
                break;
            case "move":    // works
                    audioSrc.PlayOneShot(moveSound);
                break;
            case "Kids":     // works
                    audioSrc.PlayOneShot(kidsSound);
                break;

        }
    }
}
