using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    Camera cameraVar;
    GameObject[] shadows;
    Vector2 start_position;
    //private float scaleSpeed = 1f;


    GameControl gameControl;
    // Start is called before the first frame update
    void Start()
    {
        cameraVar = GameObject.Find("camera").GetComponent<Camera>();
        shadows = GameObject.FindGameObjectsWithTag("shadow");
        start_position = transform.position;
        gameControl = GameObject.Find("GameControl").GetComponent<GameControl>();
  

        StartCoroutine(initiateStartActions());
      
    }

    IEnumerator initiateStartActions()
    {
        GameObject.Find("PageStartAnimations").GetComponent<Animations>().createAnimalAnim(2f, transform.position);
       
     
        GetComponent<Renderer>().enabled = false;

        foreach (GameObject shadow in shadows)
        {
            shadow.GetComponent<Renderer>().enabled = false;

        }

            //Wait for 2 seconds
            yield return new WaitForSeconds(2);
            GetComponent<Renderer>().enabled = true;
           
        foreach (GameObject shadow in shadows)
        {
            
            shadow.GetComponent<Renderer>().enabled = true;
        }


    }

    private void OnMouseDrag()
    {
        
        Vector3 v3_position = cameraVar.ScreenToWorldPoint(Input.mousePosition);
        v3_position.z = 0;
        transform.position = v3_position;
    

    }
    private void OnMouseDown()
    {
        SoundManagerScript.PlaySound("move");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            foreach(GameObject shadow in shadows)
            {
                if (gameObject.name == shadow.name)

                {
                    float dist = Vector3.Distance(shadow.transform.position, transform.position);
                //    Debug.Log("Distance is: " + dist);
                    if(dist <=1)
                    {
                        transform.position = shadow.transform.position;
                        Destroy(this);
                        gameControl.nextLevelCheck();
                    } else
                    {
                        transform.position = start_position;
                    }
                }
            }
        }
    }
}
