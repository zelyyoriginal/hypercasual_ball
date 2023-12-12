using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformRotation : MonoBehaviour
{
    [SerializeField] private float ofsetX, ofsetZ;
    [SerializeField] private Transform platform;

    private float ofsetFactor = 0.8f;
   
    void FixedUpdate()
    {

       if (platform != null)
        {
            Rotate();
        }

    }

    private void Rotate()
    {
        platform.transform.RotateAround(transform.position, platform.transform.right, -ofsetX * ofsetFactor);
        platform.transform.RotateAround(transform.position, platform.transform.up,     ofsetZ * ofsetFactor);
    }
    public void InputDeltaRotation(InputAction.CallbackContext context)
    {
       Vector2 ofset = context.ReadValue<Vector2>();
        ofsetX = ofset.x;
        ofsetZ = ofset.y;

    }

    private void OnCollisionEnter(Collision collision)
    {
        platform= collision.gameObject.transform;
    }
    private void OnCollisionExit(Collision collision)
    {
        platform = null;

    }
}
