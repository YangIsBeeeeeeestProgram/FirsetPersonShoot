/* 作者:#AUTHOR#
 * 邮箱:#EMAIL#
 * Unity版本:#UNITYVERSION#
 * 时间:#DATE#
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager: MonoBehaviour {

    public const string SoundPath = "Sounds/";

    private static AudioManager instance;
    public static AudioManager Instance { get { return instance; } }

    private void Awake()
    {
        instance = this;
    }



    public void PlaySound(string clipName)
    {
        AudioClip soundClip = GetSound(clipName);
        GameObject newObj = new GameObject(clipName);
        newObj.transform.SetParent(this.transform);
        AudioSource audioSource = newObj.AddComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.Play();
        Destroy(newObj, soundClip.length);
    }



    AudioClip GetSound(string clipName)
    {
        return Resources.Load<AudioClip>(SoundPath + clipName);
    }
}