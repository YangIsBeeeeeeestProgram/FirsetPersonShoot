/* 作者:#AUTHOR#
 * 邮箱:#EMAIL#
 * Unity版本:#UNITYVERSION#
 * 时间:#DATE#
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4A1: Weapon {

    private new void Awake()
    {
        base.Awake();
        GameManager.currentWeapon = this;
        Player.Instance.currentWeapon = this;
        Init();
    }


    void Init()
    {
        this.ShootInterval = 0.1f;
    }
}