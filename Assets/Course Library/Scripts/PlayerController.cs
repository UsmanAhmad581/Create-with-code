using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{   //Editable in Editor
    public float speed;
    public float turnSpeed;

    //Cameras to switch between
    public Camera mainCamera;
    public Camera hoodCamera;

    //For Binding Input Action (WASD) to move the player
    public InputAction moveAction;
    //For Binding Input Action (C) to switch between cameras
    public InputAction cameraSwitchAction;
    
    //Current input Action (x = left/right, y = forward/backward)
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        //Enable the moveAction to start listening for input
        moveAction.Enable();
        //Enable the cameraSwitchAction to start listening for input
        cameraSwitchAction.Enable();

        mainCamera.enabled = true;
        hoodCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {   
        //Read the current value of the moveAction and store it in moveInput
        moveInput = moveAction.ReadValue<Vector2>();

       //Move the player forward/backward based on the y value of moveInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        //Rotate the player left/right based on the x value of moveInput
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);

        if(cameraSwitchAction.WasPressedThisFrame())
        {
            //Switch between mainCamera and hoodCamera
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
