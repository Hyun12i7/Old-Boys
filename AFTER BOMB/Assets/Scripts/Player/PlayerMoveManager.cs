using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
    public float RunMaxSpeed;
    public float MaxSpeed;
    public float Speed;

    public float JumpPower;
    public static bool isJump;

    public float H;
    public float V;

    public Animator HandAnime;
    public bool StopRun;


    public Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        isJump = false;
        Speed = 0;
        StopRun = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();


        if (Input.GetKey(KeyCode.LeftShift))
        {
            if(StopRun == false)
            {
                HandAnime.SetBool("isRun", true);
            }
            
            if (Speed >= RunMaxSpeed)
            {
                
                Speed = RunMaxSpeed;
            }
        }
        else
        {
            
            if (Speed >= MaxSpeed)
            {
                HandAnime.SetBool("isRun", false);
                Speed = MaxSpeed;
            }

            if(Speed == 0)
            {
                HandAnime.SetBool("isRun", false);
            }
        }


    }

    public void Move()
    {
        H = Input.GetAxisRaw("Horizontal");
        V = Input.GetAxisRaw("Vertical");

        if (H != 0 | V != 0)
        {
            StopRun = false;
            HandAnime.SetBool("isWalk", true);
            Speed += 15 * Time.deltaTime;
        }
        else
        {
            StopRun = true;
            HandAnime.SetBool("isWalk", false);
            HandAnime.SetBool("isRun", false);
            Speed = 0;
        }


        Vector3 MoveVec = transform.forward * V + transform.right * H;
        Vector3 newVelovity = MoveVec.normalized * Speed;
        newVelovity.y = RB.velocity.y;
        RB.velocity = newVelovity;
    }

    public void Jump()
    {
        if (isJump == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RB.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
            }
        }

    }

}