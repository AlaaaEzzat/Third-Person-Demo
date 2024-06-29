using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerLocomotion locomotion;
    public inputControlls controlls;
    public AnimationManager anim;
    public cameraHandling CM;
    public TargetLockOn lockOn;

    [Header("Target System")]
    public bool targetLock = false;
    public int targetCounter = 0;

    private void Awake()
    {
        locomotion = GetComponent<PlayerLocomotion>();
        controlls = GetComponent<inputControlls>();
        CM = GetComponent<cameraHandling>();
        anim = GetComponent<AnimationManager>();
        lockOn = GetComponent<TargetLockOn>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        controlls.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        locomotion.handleAllMovement();
    }


    public void changeTarget()
    {
        targetCounter += 1;
    }
}
