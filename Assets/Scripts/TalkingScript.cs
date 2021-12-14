using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingScript : MonoBehaviour
{
    Animator animator;
    AudioSource audio_source;
    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        Invoke("TalkAnimation", 60.0f);
    }

    // Update is called once per frame
    void TalkAnimation()
    {
        animator.SetBool("talk", true);
        //audio_source.Play();
    }
}
