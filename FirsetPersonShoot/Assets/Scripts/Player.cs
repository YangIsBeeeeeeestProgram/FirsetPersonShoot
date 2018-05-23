/* 作者:#AUTHOR#
 * 邮箱:#EMAIL#
 * Unity版本:#UNITYVERSION#
 * 时间:#DATE#
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Gun
{
    Null = 0,
    M4A1,
    AK47
}


public class Player: MonoBehaviour {


    #region 单例对象
    private static Player instance;
    public static Player Instance { get { return instance; } }
    private Player() { }
    #endregion

    [SerializeField]
    List<GameObject> Guns;


    public const int MaxHealth = 100;//最大血量
    public int CurrentHealth = MaxHealth;//目前的血量

    [HideInInspector]
    public Weapon currentWeapon;//当前使用的武器

    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        
    }

    /// <summary>
    /// 更换武器
    /// </summary>
	public void ChangeWeapon(Gun gun)
    {
        switch (gun)
        {
            case Gun.Null:
                break;
            case Gun.M4A1:
                ShowGun(Gun.M4A1.ToString());
                break;
            case Gun.AK47:
                ShowGun(Gun.AK47.ToString());
                break;
            default:
                break;
        }
    }

    void ShowGun(string gunName)
    {
        for (int i = 0; i < Guns.Count; i++)
        {
            Guns[i].SetActive(false);
        }
        for (int i = 0; i < Guns.Count; i++)
        {
            if (Guns[i].name == gunName)
            {
                Guns[i].SetActive(true);
            }
        }
    }


}