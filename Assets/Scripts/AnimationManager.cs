using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator _anim;
    private PlayerManager manager;
    [SerializeField] Material [] material;
    [SerializeField] Transform sword,sword2, swordPos ,swordPos2 , handPos,handPos2;
    int horizontal;
    int vertical;
    public bool swordState = false;
    private bool walk = false;
    private bool attack1 = false;
    private bool attack2 = false;
    private bool attack3 = false;
    private bool disolve = false;
    private float disolveCounter = 0;

    public Animator anim
    {
        get => _anim;
        private set => _anim = value;
    }


    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
        manager = GetComponent<PlayerManager>();
        heath();
        
    }


    public void setAnimation (float horizontalInput , float verticalInput)
    {
        float snappedHorizontal;
        float snappedVertical;

        #region horizontal
        if (horizontalInput > 0)
        {
            snappedHorizontal = 1;
        }
        else if (horizontalInput < 0)
        {
            snappedHorizontal = -1f;
        }
        else
        {
            snappedHorizontal = 0f;
        }
        #endregion

        #region vertical
        if (verticalInput > 0)
        {
            snappedVertical = 1f;
        }
        else if(verticalInput < 0)
        {
            snappedVertical = -1f;
        }
        else
        {
            snappedVertical = 0f;
        }
        #endregion

        anim.SetFloat(horizontal, snappedHorizontal, 0.1f, Time.deltaTime);
        anim.SetFloat(vertical, snappedVertical, 0.1f, Time.deltaTime);

    } //control character animation movement
    public void drawSword()
    {
        if(swordState == false)
        {
            swordState = true;
            anim.SetBool("SwordState", true);
        }
        else
        {
            swordState = false;
            anim.SetBool("SwordState", false);
        }
    } // control the draw and sheath animation of the sword

    public void walking()
    {
        if(walk == false)
        {
            walk = true;
            anim.SetBool("walk", true);
        }
        else
        {
            walk = false;
            anim.SetBool("walk", false);
        }
    } // control the slow walking animation 

    public void attack1anim()
    {
        if(attack1 == false && swordState == true)
        {
            attack1 = true;
            anim.SetBool("attack1", true);
        }
        else
        {
            attack1 = false;
            anim.SetBool("attack1", false);
        }
        
    } // activate the first attack combo animaiton

    public void attack2anim()
    {
        if (attack2 == false && swordState == true)
        {
            attack2 = true;
            anim.SetBool("attack2", true);
        }
        else
        {
            attack2 = false;
            anim.SetBool("attack2", false);
        }
    } // activate the second attack combo animation

    public void attack3anim()
    {
        if(attack3 == false && swordState == true)
        {
            attack3 = true;
            anim.SetBool("attack3", true);
        }
        else
        {
            attack3 = false;
            anim.SetBool("attack3", false);
        }
    } // activate the third attck combo animation

    private void OnAnimatorMove()
    {
        if (anim)
        {
            transform.parent.position = anim.rootPosition;
            transform.parent.rotation = anim.rootRotation;
        } 
    } // apply root parent to player game object when animation starts

    public void draw()
    {
        sword.transform.SetParent(handPos);
        sword.position = handPos.position;
        sword.rotation = handPos.rotation;


        sword2.transform.SetParent(handPos2);
        sword2.position = handPos2.position;
        sword2.rotation = handPos2.rotation;
    } // makes the hand parent of the sword when draw animation playes
    public void heath()
    {
        sword.transform.SetParent(swordPos);
        sword.position = swordPos.position;
        sword.rotation = swordPos.rotation;

        sword2.transform.SetParent(swordPos2);
        sword2.position = swordPos2.position;
        sword2.rotation = swordPos2.rotation;

    } // remove the hand parent of the sword when heath animation playes

    public void disolv()
    {
        if(disolve == false)
        {
            disolve = true;
            anim.SetBool("disolv", true);
        }
        else
        {
            disolve = false;
            anim.SetBool("disolv", false);
        }
    } // activate the disolv  animation 

    private void dis()
    {
        if (disolve == true && disolveCounter <= 1)
        {
            disolveCounter += 0.4f * Time.deltaTime;
        }
        if (disolve == false && disolveCounter >= 0)
        {
            disolveCounter -= 0.4f * Time.deltaTime;
        }
        for (int i = 0; i < material.Length; i++)
        {
            material[i].SetFloat("_disa", disolveCounter);
        }
    } // activate the disolv shader visual effect 

    public void targetLockk()
    {
        if (manager.targetLock == false && manager.CM.CMtargetGroup.m_Targets[0].target != null)
        {
            manager.targetLock = true;
            anim.SetBool("targetLock", true);
        }
        else
        {
            manager.targetLock = false;
            anim.SetBool("targetLock", false);
        }
    } // control whether the target locked or not

    private void Update()
    {
        dis();
    }
}
