using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform rootObject, followObject;
    [SerializeField] private Vector3 positionOffset, rotationOffset, headBodyOffset;


    // Start is called before the first frame update
    //void Start()
    //{
    //    headBodyOffset = transform.position - IK_Head.position;
    //}

    // Update is called once per frame
    void Update()
    {
        rootObject.position = headBodyOffset + transform.position;
        rootObject.up = Vector3.ProjectOnPlane(followObject.forward, Vector3.forward).normalized;
        //rootObject.right = Vector3.ProjectOnPlane(followObject.forward, Vector3.forward).normalized;
        //rootObject.forward = Vector3.ProjectOnPlane(followObject.up, Vector3.up).normalized;
        //rootObject.forward = followObject.up;
        transform.position = followObject.TransformPoint(positionOffset);
        transform.rotation = followObject.rotation * Quaternion.Euler(rotationOffset);
    }
}
