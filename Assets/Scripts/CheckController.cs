using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CheckController : MonoBehaviour
{
    private void Update()
    {
        var leftHandedControllers = new List<UnityEngine.XR.InputDevice>();
        var desiredCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.Right;
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredCharacteristics, leftHandedControllers);

        InputDevice device = leftHandedControllers[0];

        Vector2 inputAxis;

        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);

    }
}
