/* 作者:#AUTHOR#
 * 邮箱:#EMAIL#
 * Unity版本:#UNITYVERSION#
 * 时间:#DATE#
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController: MonoBehaviour {

    Ray ray;
    public RaycastHit raycastHit;
    public bool IsCast = false;


    public static RayController Instance;

    private void Awake()
    {
        Instance = this;
    }


    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        IsCast = Physics.Raycast(ray, out raycastHit, 100, ~(1 << 8));

        if (IsCast)
        {
            Debug.DrawLine(ray.origin, raycastHit.point);
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.GetPoint(100));
        }


    }
}