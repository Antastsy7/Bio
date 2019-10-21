using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    private int i = 0;
    private Vector3 pos1 = new Vector3(-5, 3, -7);
    private Vector3 pos2 = new Vector3(3, 3, -7);
    private  Vector3 pos3 = new Vector3(-2,3,-7);
    private Vector3 pos4 = new Vector3(1, 3, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        //Debug.Log(pos);
        throw new NotImplementedException();
    }

    public void spawn()
    {
        
        
        
        
    }

    private void FixedUpdate()
    {
        i++;
        if (i % 100 == 0)
        {
            GameObject _instance1 = Instantiate(prefab1, pos1, Quaternion.identity);
            Destroy(_instance1, 3);
        }

        if (i % 130 == 0)
        {
            GameObject _instance2 = Instantiate(prefab2, pos2, Quaternion.identity);
            Destroy(_instance2, 2);
        }

        if (i % 170 == 0)
        {
            GameObject _instance3 = Instantiate(prefab1, pos4, Quaternion.identity);
            Destroy(_instance3, 1);
        }

        if (i % 290 == 0)
        {
            GameObject _instance4 = Instantiate(prefab2, pos3, Quaternion.identity);
            Destroy(_instance4, 4);
        }

        if (i % 600 == 0)
        {
            i = 0;
        }
        
    }

    
}
