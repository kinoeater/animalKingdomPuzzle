using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    int totalAnimals = 3;
    int animalCount = 0;

    int nextSceneLoad;

    public Animator transition;
    public float transitionTime = 1f;


    public void nextLevelCheck()
    {
        animalCount++;

        StartCoroutine(playSounds());
   


        if (animalCount == totalAnimals)
        {    
              StartCoroutine(initiateNextLevelActions());
      
        }

    }

    IEnumerator playSounds()
    {

        SoundManagerScript.PlaySound("clickwooden");
        //Wait for 5 seconds
        yield return new WaitForSeconds(0.4f);
        SoundManagerScript.PlaySound("upRising");

    }

    IEnumerator initiateNextLevelActions()
    {
     
        yield return new WaitForSeconds(1);
        SoundManagerScript.PlaySound("success");
        yield return new WaitForSeconds(2);
        GameObject.Find("SpawnConfetti").GetComponent<Confetti>().createConfetti();
        SoundManagerScript.PlaySound("Kids");

        //Wait for 5 seconds
        yield return new WaitForSeconds(5);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);

        loadNextScene();        
    }



    public void loadNextScene()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.GetActiveScene().name != "Scene13")
        {


            SceneManager.LoadScene(nextSceneLoad);
        }
        else
        {
            SceneManager.LoadScene("Scene1");
        }
    }



}
