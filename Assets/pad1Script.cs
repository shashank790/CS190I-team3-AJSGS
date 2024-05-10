using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad1Script : MonoBehaviour
{
    void OnEnable()
    {
        getGrabbed.OnGrabbed += Deactivate;
        getGrabbed.OnReleased += Activate;
    }

    void OnDisable()
    {
        getGrabbed.OnGrabbed -= Deactivate;
        getGrabbed.OnReleased -= Activate;
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
