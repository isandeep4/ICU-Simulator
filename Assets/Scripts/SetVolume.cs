using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;

    // Update is called once per frame
    public void SetLevel(float loudnessScrollValue)
    {
        mixer.SetFloat("LoudnessVol",Mathf.Log10(loudnessScrollValue) * 20);
    }
}
