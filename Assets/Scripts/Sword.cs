using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class Sword : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        //var device = InputSystem.GetDevice<XRController>(CommonUsages.RightHand);
        //var command = UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand.Create(0, 6f, 1f);
        //device.ExecuteCommand(ref command);
    }

    private void OnCollisionStay(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        
    }
}
