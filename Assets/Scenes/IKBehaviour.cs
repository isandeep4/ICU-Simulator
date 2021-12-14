using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class IKBehaviour : MonoBehaviour
{
    private TwoBoneIKConstraint TwoBoneIKConstraint1;
    private TwoBoneIKConstraint TwoBoneIKConstraint2;
    [SerializeField]
    public GameObject RightHandIK;
    [SerializeField]
    public GameObject LeftHandIK;
    // Start is called before the first frame update
    void Start()
    {
        TwoBoneIKConstraint1 = RightHandIK.GetComponent<TwoBoneIKConstraint>();
        TwoBoneIKConstraint2 = LeftHandIK.GetComponent<TwoBoneIKConstraint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        TwoBoneIKConstraint1.weight = 1.0f;
        TwoBoneIKConstraint2.weight = 1.0f;
    }
}
