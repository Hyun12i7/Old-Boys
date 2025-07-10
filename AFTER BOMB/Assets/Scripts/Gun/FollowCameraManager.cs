using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraManager : MonoBehaviour
{
    public GameObject Camera;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Camera.transform.rotation.eulerAngles.x;
        transform.rotation = Quaternion.Euler(x, 0, 0);
    }
}
