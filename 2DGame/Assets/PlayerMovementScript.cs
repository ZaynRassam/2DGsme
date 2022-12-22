using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] characterController controller;
    [SerializeField] float runSpeed;
    private float xMove;
    private float zMove;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        zMove = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Move Character
        controller.Move(xMove * Time.fixedDeltaTime, false, false);

    }
}
