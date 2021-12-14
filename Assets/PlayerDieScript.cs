using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDieScript : MonoBehaviour
{
    GameObject ChildGameObject1;
    Animator ChildAnimator;
    CapsuleCollider capCol;
    public GameManagerScript gameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        ChildGameObject1 = this.gameObject.transform.GetChild(0).gameObject;
        ChildAnimator = ChildGameObject1.GetComponent<Animator>();
        capCol = gameObject.GetComponent<CapsuleCollider>();
        Invoke("SetTrigger", 15.0f);
        Invoke("ActivateGameObjects", 50.0f);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            ChildAnimator.SetTrigger("Death");
            
        }
    }
    void SetTrigger()
    {
        capCol.isTrigger = true;
    }
    void ActivateGameObjects()
    {
        gameManagerScript.ActivateObjects();
    }

}
