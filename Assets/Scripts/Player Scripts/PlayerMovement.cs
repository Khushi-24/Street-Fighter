using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //private PlayerAnimation player_Animation;
    private Rigidbody mybody;

    public float walk_Speed = 2f;
    public float z_Speed = 1.5f;

    private float rotation_Y = -90f;
    private float rotation_Speed = 15f;




    // Start is called before the first frame update
    void Awake()
    {

        mybody = GetComponent<Rigidbody>();
        //player_Animation = GetComponentInChildren<PlayerAnimation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
       // print("The value is:" + Input.GetAxisRaw(Axis.HORIZONTAL_AXIS));
    }

    void FixedUpdate()
    {
        DetectMovement();
    }

    void DetectMovement()
    {
        mybody.velocity = new Vector3(
            Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) * (-walk_Speed),
            mybody.velocity.y,
            Input.GetAxisRaw(Axis.VERTICAL_AXIS) * (-z_Speed));
    }

    void RotatePlayer()
    {
        if(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) > 0)
        {
            transform.rotation = Quaternion.Euler(0f, -Mathf.Abs(rotation_Y), 0f);
        } else if(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotation_Y), 0f);
        }
    }
}
