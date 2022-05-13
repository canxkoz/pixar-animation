using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraReset : MonoBehaviour
{
    public Vector3 LocalPosition = Vector3.zero;
    public Vector3 LocalEulerRotation = Vector3.zero;
    public Vector3 LocalScale = Vector3.one;
    private void Start()
    {
        LocalPosition = transform.localPosition;
        LocalEulerRotation = transform.localEulerAngles;
        LocalScale = transform.localScale;
    }

    public void resetCamTransform()
    {
        Camera.main.transform.localPosition = LocalPosition;
        Camera.main.transform.localEulerAngles = LocalEulerRotation;
        Camera.main.transform.localScale = LocalScale;
    }
}
