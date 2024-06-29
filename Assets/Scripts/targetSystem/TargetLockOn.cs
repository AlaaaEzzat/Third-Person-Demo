using System.Collections;
using System;
using UnityEngine;

public class TargetLockOn : MonoBehaviour
{
    PlayerManager manager;

    [SerializeField] Transform _TargetToLockOn;
    [SerializeField] GameObject lockOnCanves;
    [SerializeField] Collider[] overlapColiders;
    [SerializeField] float checkRadius;
    [SerializeField] LayerMask checkLayer;
  
    public Transform target
    {
        get => _TargetToLockOn;
        set => _TargetToLockOn = value;
    }


    private void Awake()
    {
        manager = GetComponent<PlayerManager>();
    }

    private void Start()
    {
        StartCoroutine(Sorting());
    }
    private void FixedUpdate()
    {
        getTarget();
        targetCanves();
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    } // draw phere gizmo on the player

    void getTarget()
    {
        manager.CM.CMtargetGroup.m_Targets[0].target = null;
        overlapColiders = Physics.OverlapSphere(transform.position, checkRadius, checkLayer);

        foreach (Collider col in overlapColiders)
        {

            if(manager.targetCounter >= overlapColiders.Length)
            {
                manager.targetCounter = 0;
            }

            target = overlapColiders[manager.targetCounter].transform;
            manager.CM.CMtargetGroup.m_Targets[0].target = target;
            lockOnCanves.transform.position = Camera.main.WorldToScreenPoint(target.position);
        }


    } //set shpere overlap colider to check the map and get the coliders there and then get the closest target and then lock it to Main target

    void targetCanves()
    {
        lockOnCanves.SetActive(false);

        if(manager.targetLock == true && manager.CM.CMtargetGroup.m_Targets[0].target != null)
        {
            lockOnCanves.SetActive(true);
        }
    }

    IEnumerator Sorting()
    {
        yield return new WaitForSeconds(10);
        Array.Sort(overlapColiders, new comparar(transform));

    }
}
