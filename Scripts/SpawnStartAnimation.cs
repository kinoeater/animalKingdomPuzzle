using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStartAnimation : MonoBehaviour
{

    public GameObject animalAnimation1;
    public GameObject animalAnimation2;
    public GameObject animalAnimation3;

    public void createAnimalAnim(float duration, Vector3 position)
    {
        //   Debug.Log("Confetti created");
        GameObject objAnimal = Instantiate(animalAnimation1, position,Quaternion.identity);
        GameObject objAnima2 = Instantiate(animalAnimation2, position, Quaternion.identity);
        GameObject objAnima3 = Instantiate(animalAnimation3, position, Quaternion.identity);

        Destroy(objAnimal, duration);
        Destroy(objAnima2, duration);
        Destroy(objAnima3, duration);
    }

}
