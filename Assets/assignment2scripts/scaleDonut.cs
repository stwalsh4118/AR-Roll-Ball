using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scaleDonut : MonoBehaviour
{

    public Slider scaler;
    public Vector3 startingScale;
    // Start is called before the first frame update
    void Start()
    {
        startingScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = startingScale * scaler.value;
    }

}
