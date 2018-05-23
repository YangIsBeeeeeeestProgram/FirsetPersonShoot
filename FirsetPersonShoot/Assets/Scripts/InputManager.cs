/* 作者:#AUTHOR#
 * 邮箱:#EMAIL#
 * Unity版本:#UNITYVERSION#
 * 时间:#DATE#
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager: MonoBehaviour {

    private void Update()
    {
        OnKeyboardControl();
    }

    //键盘控制
    void OnKeyboardControl()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Player.Instance.ChangeWeapon(Gun.M4A1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Player.Instance.ChangeWeapon(Gun.AK47);
        }

        if (Input.GetMouseButton(0))
        {
            Player.Instance.currentWeapon.Fire();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Player.Instance.currentWeapon.Reload();
        }
    }
}