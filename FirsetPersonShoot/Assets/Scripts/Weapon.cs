/* 作者:#AUTHOR#
 * 邮箱:#EMAIL#
 * Unity版本:#UNITYVERSION#
 * 时间:#DATE#
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon: MonoBehaviour {

    public int ShootSpeed = 1;//发射速度
    public float ShootInterval = 0.5f;//每发子弹的间隔时间（/s)
    public const int MaxBulletCount = 90;//单个弹夹的子弹容量
    public int CurrentBulletCount = MaxBulletCount;//当前弹夹的子弹数量
    public int MagazineNum = 10;//总共的弹夹数量
    protected GameObject FireEffect;//枪火特效
    [SerializeField]
    protected GameObject hitEffect;//弹痕特效

    protected Animation fireAnimation;
    protected void Awake()
    {
        FireEffect = this.transform.Find("FireEffect").gameObject;
        fireAnimation = this.GetComponent<Animation>();
    }




    private float lastTime = 0;
    private float tempTime = 0;

    public void Fire()
    {
        tempTime = Time.time - lastTime; //获取上一发之后经过的时间

        if (CurrentBulletCount == 0)
            return;
        if (tempTime > ShootInterval)  //如果间隔时间大于预定的每发子弹间隔时间
        {
            lastTime = Time.time;//重新赋予时间
            CurrentBulletCount--;
            //播放动画.
            fireAnimation.Play();
            //播放特效
            FireEffect.SetActive(false);
            FireEffect.SetActive(true);
            //播放音效
            AudioManager.Instance.PlaySound("shootonce");
            if (RayController.Instance.IsCast)
            {
                RaycastHit hit = RayController.Instance.raycastHit;
                GameObject newHitEffect = Instantiate(hitEffect, hit.point,Quaternion.identity);
                newHitEffect.transform.LookAt(hit.point + hit.normal);
                Destroy(newHitEffect, 5);
            }
        }
    }

    //换弹夹
    public void Reload()
    {
        if (MagazineNum > 0)
        {
            MagazineNum--;
            CurrentBulletCount = MaxBulletCount;
        }
    }
}