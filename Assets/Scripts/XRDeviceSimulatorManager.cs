using UnityEngine;

public class XRDeviceSimulatorManager : MonoBehaviour
{
    public GameObject xrDeviceSimulator; // Drag the XR Device Simulator prefab here

    void Start()
    {
        if (Application.isEditor)
        {
            // Enable the XR Device Simulator in the Editor
            if (xrDeviceSimulator != null)
            {
                xrDeviceSimulator.SetActive(true);
            }
        }
        else
        {
            // Disable the XR Device Simulator in the build
            if (xrDeviceSimulator != null)
            {
                xrDeviceSimulator.SetActive(false);
            }
        }
    }
}
