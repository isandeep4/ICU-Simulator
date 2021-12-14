using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public Animator transition;
    private int levelToLoad;
    public bool triggerNextLevel = false;
    // Update is called once per frame
    void Update()
    {
        if (triggerNextLevel)
        {
            LoadNextLevel(2);
        }
    }
    public void LoadNextLevel(int levelindex)
    {
        levelToLoad = levelindex;
        transition.SetTrigger("FadeOut");
        //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void OnFadeOutComplete()
    {
        //SceneManager.LoadScene(levelToLoad);
    }

}
