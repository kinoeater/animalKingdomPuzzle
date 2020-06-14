using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public GameObject confettiFx;
  public void createConfetti()
    {
      //   Debug.Log("Confetti created");
        GameObject ob = Instantiate(confettiFx);
        Destroy(ob, 5f);
    }

}
