using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputControlls : MonoBehaviour
{
    PlayerContolls inputManager;
    PlayerLocomotion p;
    AnimationManager anim;
    PlayerManager manager;
    public float horizontalInput;
    public float verticalInput;
    public float moveAmount;
    Vector2 moveInput;


    private void Awake()
    {
        anim = GetComponent<AnimationManager>();
        p = GetComponent<PlayerLocomotion>();
        manager = GetComponent<PlayerManager>();
    }

    private void OnEnable()
    {
        if(inputManager == null)
        {
            inputManager = new PlayerContolls();

            inputManager.Player.Movement.performed += i => moveInput = i.ReadValue<Vector2>();
            inputManager.Player.Draw.performed += i => anim.drawSword();
            inputManager.Player.slowMoation.performed += i => anim.walking();
            inputManager.Player.attack1.performed += i => anim.attack1anim();
            inputManager.Player.attack2.performed += i => anim.attack2anim();
            inputManager.Player.attack3.performed += i => anim.attack3anim();
            inputManager.Player.dica.performed += i => anim.disolv();
            inputManager.Player.dash.performed += i => p.dash();
            inputManager.Player.targetLock.performed += i => anim.targetLockk();
            inputManager.Player.changeTarget.performed += i => manager.changeTarget();
        }
        inputManager.Enable();
    }
    private void OnDisable()
    {
        inputManager.Disable();
    }

    void handleMovementInput()
    {
        verticalInput = moveInput.y;
        horizontalInput = moveInput.x;

        anim.setAnimation(horizontalInput, verticalInput);
    }

    public void HandleAllInputs()
    {
        handleMovementInput();
    }
}
