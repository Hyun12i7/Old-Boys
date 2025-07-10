using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ShootManager : MonoBehaviour
{
    public Animator GunAnime;

    public LayerMask layerMake;
    RaycastHit hitInfo;
    float rayDistance = 150f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            GunAnime.SetBool("isShoot", true);
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            if (Physics.Raycast(ray, out hitInfo, rayDistance, layerMake, QueryTriggerInteraction.Ignore))
            {
                Debug.Log("Hit");
                Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayDistance, Color.red);
            }


        }
        else
        {
            GunAnime.SetBool("isShoot", false);
        }
    }
}
