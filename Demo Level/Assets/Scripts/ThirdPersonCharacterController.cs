using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float moveSpeedDefault;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        float moveSpeed = moveSpeedDefault;
        if(Input.GetKey(KeyCode.LeftShift)){
            moveSpeed = moveSpeedDefault*2;
        }
        else {
            moveSpeed = moveSpeedDefault;
        }

        Vector3 playerMovement = new Vector3(hor,0f,ver) * moveSpeed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}
