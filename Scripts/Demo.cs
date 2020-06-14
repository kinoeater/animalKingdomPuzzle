using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour

{

    public Animator demo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startAnimations());
       
    }

    IEnumerator startAnimations()
    {

        yield return new WaitForSeconds(1);
        demo.SetTrigger("trigger1");
    

    }

}
