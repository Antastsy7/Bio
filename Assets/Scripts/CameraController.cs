using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Vector3 targetPos;  
    public Transform characterLoc;

  

    // Start is called before the first frame update
    void Start()
    {
        //initialize get compoent from character
        characterLoc = GameObject.Find("character").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        //update postion of camera
        if (characterLoc.position.x < 25 && characterLoc.position.x > 0)
        {
            targetPos = new Vector3(characterLoc.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            transform.position = targetPos;
        }

    }
}
