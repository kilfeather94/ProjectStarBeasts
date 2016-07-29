using UnityEngine;
using System.Collections;

public class TiltMovement : MonoBehaviour
{
    public float SmoothGun = 2.0f;
    public float TiltAngle = 30.0f;

    private float tiltGun;
    private Quaternion target;

    void Update()
    {

        HorizontalTilt();
        VerticalTilt();
    }

    void HorizontalTilt()
    {
        tiltGun = Input.GetAxis("Horizontal") * TiltAngle;
        target = Quaternion.Euler(tiltGun, 0f, 0f);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * SmoothGun);
    }

    void VerticalTilt()
    {
        tiltGun = Input.GetAxis("Vertical") * TiltAngle;
        target = Quaternion.Euler(0f, 0f, tiltGun);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * SmoothGun);
    }

 
}