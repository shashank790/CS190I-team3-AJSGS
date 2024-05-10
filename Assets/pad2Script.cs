using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad2Script : MonoBehaviour
{
    void OnEnable()
    {
        getGrabbed.OnGrabbed += Activate;
        getGrabbed.OnReleased += Deactivate;
    }

    void OnDisable()
    {
        getGrabbed.OnGrabbed -= Activate;
        getGrabbed.OnReleased -= Deactivate;
    }

    void Deactivate()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    void Activate()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
