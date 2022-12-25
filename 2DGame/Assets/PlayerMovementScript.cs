using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] characterController controller;
    [SerializeField] float runSpeed;
    private float xMove;
    private bool jump;
    private bool crouch;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        } 
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

        void FixedUpdate()
    {
        // Move Character
        controller.Move(xMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
