using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIExpressionControl : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void SetExpression(string trigger)
    {
        anim.SetTrigger(trigger);
    }
}
