using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advertise : MonoBehaviour
{
    public GameObject obj;

    public int duration;

    public int occur;
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
        Invoke("show", occur);
    }

    public void show()
    {
        obj.SetActive(true);
        Invoke("close", duration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void close()
    {
        Destroy(obj);
    }
    
}
