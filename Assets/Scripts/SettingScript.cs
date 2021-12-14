using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingScript : MonoBehaviour
{
    public AudioMixer mixer1;
    public AudioMixer mixer2;

    public void SetLevel1(float loudnessScrollValue)
    {
        mixer1.SetFloat("LoudnessVol", Mathf.Log10(loudnessScrollValue) * 20);
    }
    public void SetLevel2(float AlarmScrollValue)
    {
        mixer2.SetFloat("AlarmSound", Mathf.Log10(AlarmScrollValue) * 20);
    }
    //public GameObject AudioObject;
    //public AudioSource audioSource;
    //void Start()
    //{
    //    audioSource = AudioObject.GetComponent<AudioSource>();
    //}
    //public void SetAlarm(bool isAlarmed)
    //{
    //    Debug.Log("alarm status:" + isAlarmed);
    //    if (isAlarmed)
    //    {
    //        audioSource.Play();
    //    }
    //}
}
