using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    AudioSource siren_audio;
    public DocMovement doctorScript;
    public NurseMovementController nurseMovementController;
    public DocAnimatorController docAnimatorController;
    public GameObject Player;
    public GameObject levelLoader;
    public GameObject sirenLight;
    GameObject[] DisappearableObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        siren_audio = GetComponent<AudioSource>();
        Invoke("PlayEmergencyAudio", 55.0f);
        DisappearableObjects = GameObject.FindGameObjectsWithTag("Disappearable");
        
    }

    void PlayEmergencyAudio()
    {
        siren_audio.Play();
        sirenLight.SetActive(true);
        StartCoroutine(doctorScript.WalkAnimation());
        StartCoroutine(nurseMovementController.RunAnimation());
        StartCoroutine(docAnimatorController.RunAnimation());

    }
    public void DeactivateObjects()
    {
        foreach (GameObject gameObject in DisappearableObjects)
        {
            gameObject.SetActive(false);
        }
        levelLoader.SetActive(true);
        Player.SetActive(true);
        
    }
    public void ActivateObjects()
    {
        Player.SetActive(false);
        foreach (GameObject gameObject in DisappearableObjects)
        {
            gameObject.SetActive(true);
        }
        sirenLight.SetActive(false);

    }
    
}
