/* 作者:#AUTHOR#
 * 邮箱:#EMAIL#
 * Unity版本:#UNITYVERSION#
 * 时间:#DATE#
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUIManager: MonoBehaviour {

    [SerializeField]
    Text BulletCountText;
    [SerializeField]
    Text MagazineCountText;



    private void Update()
    {
        BulletCountText.text = "子弹：" + GameManager.currentWeapon.CurrentBulletCount;
        MagazineCountText.text = "弹夹：" + GameManager.currentWeapon.MagazineNum;
    }

}