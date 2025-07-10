using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerRotateMoveManaer : MonoBehaviour
{
    public GameObject Camera;
    public float CameraAngle;
    public float mouseX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        CameraAngle += mouseX * CameraManager.CameraSpeedY;
        transform.rotation = Quaternion.Euler(0, CameraAngle, 0);

    }
}
