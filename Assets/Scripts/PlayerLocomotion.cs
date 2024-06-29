using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    PlayerManager manager;

    private Rigidbody rb;
    private Vector3 moveDirection;
    private Vector3 targerDirection = Vector3.zero;
    private Transform cameraTransform;
    [SerializeField] float moveSpeed = 6f;
    [SerializeField] float rotationSpeed = 15f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;
        manager = GetComponent<PlayerManager>();

    }


    public void handleAllMovement()
    {
        handleMovement();

        if (manager.anim.swordState == true && manager.targetLock == true)
        {
            handlLockTargetRotation();
        }
        else
        {
            handleRotation();
        }
        changeSpeed();
        
    }

    void handleMovement()
    {
        moveDirection = cameraTransform.forward * manager.controlls.verticalInput;
        moveDirection += cameraTransform.right * manager.controlls.horizontalInput;
        moveDirection.y = 0;
        moveDirection.Normalize();
        moveDirection = moveDirection * moveSpeed;
        Vector3 movementVelocity = moveDirection;
        rb.velocity = movementVelocity;
    } // normal movment handiling

    void handleRotation()
    {
        targerDirection = cameraTransform.forward * manager.controlls.verticalInput;
        targerDirection += cameraTransform.right * manager.controlls.horizontalInput;
        targerDirection.y = 0f;
        targerDirection.Normalize();
        if (targerDirection == Vector3.zero)
        {
            targerDirection = transform.forward;
        }
        Quaternion targetRotation = Quaternion.LookRotation(targerDirection);
        Quaternion rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        transform.rotation = rotation;
    } // normal rotation handiling


    public void dash()
    {

        rb.AddForce(transform.forward * 200f, ForceMode.VelocityChange);
    }  // control dash 

    private void handlLockTargetRotation()
    {
        Vector3 rotationOffset = manager.lockOn.target.transform.position - transform.position;
        rotationOffset.y = 0;
        transform.forward += Vector3.Lerp(transform.forward, rotationOffset, Time.deltaTime * rotationSpeed);
    } // locktarget rotation movement


    public void changeSpeed()
    {
        bool walkState = manager.anim.anim.GetBool("walk");

        if(walkState == true)
        {
            moveSpeed = 6f;
        }
        else
        {
            moveSpeed = 1f;
        }
    }
}