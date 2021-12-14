using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{
    public Material dissolve;
    public float health;
    public AudioSource demon_Sound;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        dissolve.SetFloat("_Dissolve", 1f);
        Invoke("PlayAudio", 7.0f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        health -= 0.005f;
        Invoke("Dissolve", 6.0f);
    }
    void Dissolve()
    {
        dissolve.SetFloat("_Dissolve", health);
        animator.SetBool("Yelling", true);
        
    }
    void PlayAudio()
    {
        demon_Sound.Play();
    }
    
}
