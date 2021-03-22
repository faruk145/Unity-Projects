using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Device : MonoBehaviour
{
    private InputDevice targetDevice;
    public GameObject VRRig;
    Vector3 amount1 = new Vector3(0f, 0f, 0.003f);
    Vector3 amount2 = new Vector3(0f, 0.003f, 0f);
    Vector3 amount3 = new Vector3(0f, 0.003f, 0.003f);
    Vector3 amount4 = new Vector3(0f, -0.003f, 0.003f);
    Vector3 amount5 = new Vector3(0f, 0.003f, -0.003f);

    bool confirm = true;

    public void FalseConfirm()
    {
        confirm = false;
    }
    public void TrueConfirm()
    {
        confirm = true;
    }

    // Start is called before the first frame update
    public void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller ;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics,devices);
        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }
    }

    // Update is called once per frame
    public void Update()
    {
        //targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggervalue);
        VRRig.GetComponent<SnapTurnProvider>().enabled = false;
        if (!confirm)
        {
            targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primaryAxisValue);

            if (primaryAxisValue.x > 0f && primaryAxisValue.y > 0f)           
                this.transform.position += amount3;
            
            else if (primaryAxisValue.x > 0f && primaryAxisValue.y < 0f)           
                this.transform.position += amount4;
                           
            else if (primaryAxisValue.x < 0f && primaryAxisValue.y > 0f)
                this.transform.position += amount5;

            else if (primaryAxisValue.x < 0f && primaryAxisValue.y < 0f)
                this.transform.position -= amount3;

            else if (primaryAxisValue.x == 0f && primaryAxisValue.y > 0f)
                this.transform.position += amount2;

            else if (primaryAxisValue.x == 0f && primaryAxisValue.y < 0f)
                this.transform.position -= amount2;

            else if (primaryAxisValue.x > 0f && primaryAxisValue.y == 0f)
               this.transform.position += amount1;

            else if (primaryAxisValue.x < 0f && primaryAxisValue.y == 0f)
                this.transform.position -= amount1;
        }
    }
}
