using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookOpener : MonoBehaviour
{
    private HingeJoint joint;
    private JointLimits jointLimits;
    public Vector2 selectedLimits;
    public Vector2 unselectedLimits;
    void Start()
    {
        joint = transform.GetComponent<HingeJoint>();
        UnselectedLimits();
    }

    
    public void SelectedLimits()
    {
        jointLimits.min = selectedLimits.x;
        jointLimits.max = selectedLimits.y;
        joint.limits = jointLimits;
    }
    public void UnselectedLimits()
    {
        jointLimits.min = unselectedLimits.x;
        jointLimits.max = unselectedLimits.y;
        joint.limits = jointLimits;
    }
}
