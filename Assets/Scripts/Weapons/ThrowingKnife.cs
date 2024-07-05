using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingKnife : WeaponBase
{
    //[SerializeField] private float timeToAttack = 5f;
    
    [SerializeField] private GameObject knifePrefab;
    private PlayerMove PlayerMove;

    private void Awake()
    {
        PlayerMove = GetComponentInParent<PlayerMove>();
    }

    public override void Attack()
    {
        GameObject thrownKnife = Instantiate(knifePrefab);
        thrownKnife.transform.position = transform.position;

        ThrowingKnifeProjectable throwingKnifeProjectable = thrownKnife.GetComponent<ThrowingKnifeProjectable>();
        throwingKnifeProjectable.SetDirection(PlayerMove.LastHorizontalVector, 0f);
        
        //will be useful after upgrading
        throwingKnifeProjectable.damage = weaponStats.damage;
    }
}