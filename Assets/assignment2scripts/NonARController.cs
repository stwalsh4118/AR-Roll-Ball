using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonARController : MonoBehaviour
{

    public GameObject MyObject;
    public GameObject NotMyObject;
    public bool MyObjectActive = true;
    // Start is called before the first frame update
    void Start()
    {
        NotMyObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapObjects()
    {
        if(MyObjectActive)
        {
            MyObject.SetActive(false);
            NotMyObject.SetActive(true);
            MyObjectActive = false;
        }
        else 
        { 
            NotMyObject.SetActive(false);
            MyObject.SetActive(true);
            MyObjectActive = true;
        }

    }
}
