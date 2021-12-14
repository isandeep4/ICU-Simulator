using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VRMap
{
    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void Map()
    {
        rigTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);
    }
}


public class VRRig : MonoBehaviour
{
    public VRMap Head;
    public VRMap LeftHand;
    public VRMap RightHand;

    public Transform headConstraint;
    public Vector3 headBodyOffset;

    void Start()
    {
        headBodyOffset = transform.position - headConstraint.position;
    }

    void LateUpdate()
    {
        transform.position = headConstraint.position + headBodyOffset;
        //transform.up = Vector3.ProjectOnPlane(headConstraint.up, Vector3.up).normalized;

        Head.Map();
        LeftHand.Map();
        RightHand.Map();
    }

}
