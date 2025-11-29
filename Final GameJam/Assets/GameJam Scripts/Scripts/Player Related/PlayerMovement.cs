using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;
    bool crouch = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        //Crouch needs to be implemented
        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
       horizontalMove =  Input.GetAxisRaw("Horizontal") * runSpeed;
        
        

    }
    void FixedUpdate()
    {//Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
