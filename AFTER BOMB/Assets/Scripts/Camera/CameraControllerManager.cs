using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerManager : MonoBehaviour
{
    public CameraManager CM;

    public void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        CM = GetComponent<CameraManager>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateRotate();
    }

    public void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        CM.UpdateRotate(mouseX, mouseY);
    }
}
