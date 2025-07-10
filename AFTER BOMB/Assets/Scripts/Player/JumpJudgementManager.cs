using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpJudgementManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(1);
        if (other.gameObject.tag == "Ground")
        {
            PlayerMoveManager.isJump = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            PlayerMoveManager.isJump = true;
        }
    }
}
