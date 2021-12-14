using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaodPreviousScript : MonoBehaviour
{
    public bool ActionCompleted = false;
    public Animator transition;
    void Update()
    {
        if (ActionCompleted)
        {
            FadeOut();
        }
    }
    void FadeOut()
    {
        transition.SetTrigger("FadeOut");
    }
}
