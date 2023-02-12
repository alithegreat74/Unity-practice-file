using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInputs Inputs;
    CharacterController Ybot;
    Animator animator;
    Vector2 currentPlayerInput;
    Vector3 currentMovement;
    Vector3 Rotation;
    Vector3 RelativeMovement;
    float speed = 3f;
    float runSpeed = 7f;
    public float gravity = -7f;
    float groundGravity = -0.5f;
    public float initialJumpVelocity = 0.5f;
    public float realTimeSpeed = 5f;
    public bool isMoving;
    public bool isRunning;
    public bool isGrounded;
    public bool isJumping = false;
    public bool isRolling=false;
    bool isRollPressed = false;
    bool isJumpPressed= false;
    
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.visible=false;
        Inputs=new PlayerInputs();
        Ybot=GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        readInputs();
        
    }
    
   
    void readInputs()
    {
        Inputs.CharacterContorls.Move.started+=context =>
        {
            currentPlayerInput=context.ReadValue<Vector2>();
            currentMovement.x=currentPlayerInput.x;
            currentMovement.z=currentPlayerInput.y;
            isMoving=currentMovement.x!=0 || currentMovement.z!=0;
        };
        Inputs.CharacterContorls.Move.performed+=context =>
        {
            currentPlayerInput=context.ReadValue<Vector2>();
            currentMovement.x=currentPlayerInput.x;
            currentMovement.z=currentPlayerInput.y;
            isMoving=currentMovement.x!=0 || currentMovement.z!=0;
        };
        Inputs.CharacterContorls.Move.canceled+=context =>
        {
            currentPlayerInput=context.ReadValue<Vector2>();
            currentMovement.x=currentPlayerInput.x;
            currentMovement.z=currentPlayerInput.y;
            isMoving=currentMovement.x!=0 || currentMovement.z!=0;
        };
        Inputs.CharacterContorls.Run.started+=context =>
        {
            isRunning=context.ReadValueAsButton();
        };
        Inputs.CharacterContorls.Run.performed+=context =>
        {
            isRunning=context.ReadValueAsButton();
        };
        Inputs.CharacterContorls.Run.canceled+=context =>
        {
            isRunning=context.ReadValueAsButton();
        };
        Inputs.CharacterContorls.Jump.started+=context =>
        {
            isJumpPressed=context.ReadValueAsButton();
        };
        
        Inputs.CharacterContorls.Jump.canceled+=context =>
        {
            isJumpPressed=context.ReadValueAsButton();
        };
        Inputs.CharacterContorls.Roll.started+=context =>
        {
            isRollPressed=context.ReadValueAsButton();
        };
        Inputs.CharacterContorls.Roll.canceled+=context =>
        {
            isRollPressed=context.ReadValueAsButton();
        };
    }
    void Animation()
    {
        if (isMoving && !animator.GetBool("IsMoving"))
            animator.SetBool("IsMoving", true);
        else if (!isMoving && animator.GetBool("IsMoving"))
            animator.SetBool("IsMoving", false);
        if (isRunning && !animator.GetBool("IsRunning"))
            animator.SetBool("IsRunning", true);
        else if (!isRunning && animator.GetBool("IsRunning"))
            animator.SetBool("IsRunning", false);
    }
    void RotationHandler()
    {
        Vector3 RelativeMovement = RelativeRotation(currentMovement);
        Rotation.x=RelativeMovement.x;
        Rotation.y=0f;
        Rotation.z=RelativeMovement.z;
        Quaternion playerRotation = transform.rotation;
        if (isMoving)
        {
            Quaternion look = Quaternion.LookRotation(Rotation);
            transform.rotation=Quaternion.Slerp(playerRotation, look, 10f*Time.deltaTime);
        }
            
    }

    void Gravity()
    {
        isGrounded=Ybot.isGrounded;
        if (Ybot.isGrounded)
        { 
            currentMovement.y=+groundGravity;
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsFalling", false);
        }
        else
        {
            currentMovement.y+=gravity*Time.deltaTime;
            animator.SetBool("IsFalling", true);
        }
             
    }
    
    Vector3 RelativeRotation(Vector3 movement)
    {
        Vector3 cameraForward=Camera.main.transform.forward;
        Vector3 cameraRight=Camera.main.transform.right;

        cameraForward.y=0f;
        cameraRight.y=0f;

        cameraForward=cameraForward.normalized;
        cameraRight=cameraRight.normalized;

        Vector3 Relative = cameraForward*movement.z + cameraRight*movement.x + Vector3.up*movement.y;

        return Relative;
    }

    void jump()
    {
        if (!isJumping && isJumpPressed && Ybot.isGrounded)
        {
            animator.SetBool("IsJumping", true);
            isJumping=true;
            currentMovement.y+=4f;
            
        }
        if(isJumping && !isJumpPressed)
        {
            isJumping=false;
        }
    }
    void Roll()
    {
        if(!isRolling && isRollPressed && Ybot.isGrounded && isMoving)
        {
            isRolling=true;
            animator.SetBool("IsRolling", true);
            
        }
        else if((isRolling && !isRollPressed) || !Ybot.isGrounded)
        {
            isRolling=false;
            animator.SetBool("IsRolling", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        RotationHandler();
        
        Animation();
        
        if (!isMoving)
                isRunning= false;
        if (isRunning)
        {
            if (realTimeSpeed<runSpeed)
             realTimeSpeed+=0.05f;
        }
        else
        {
            if (realTimeSpeed>speed)
               realTimeSpeed-=0.05f;
        }
        RelativeMovement = RelativeRotation(currentMovement);
        
        Ybot.Move(RelativeMovement*realTimeSpeed*Time.deltaTime);
        Gravity();
        jump();
        Roll();
    }

    private void OnEnable()
    {
        Inputs.CharacterContorls.Enable();
    }
    private void OnDisable()
    {
        Inputs.CharacterContorls.Disable();
    }
}
