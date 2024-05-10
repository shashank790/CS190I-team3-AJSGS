using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.blue;   
    }

    void OnEnable()
    {
        getGrabbed.OnGrabbed += ChangeColor;
        getGrabbed.OnReleased += ChangeColorBack;
    }

    void OnDisable()
    {
        getGrabbed.OnGrabbed -= ChangeColor;
        getGrabbed.OnReleased -= ChangeColorBack;
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = Color.red;   
    }

    void ChangeColorBack()
    {
        GetComponent<Renderer>().material.color = Color.blue;   
    }
}
