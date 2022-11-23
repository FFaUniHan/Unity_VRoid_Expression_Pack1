using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIExpressionControl : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Transform vfxHead;

    public void SetExpression(string trigger)
    {
        anim.SetTrigger(trigger);
    }

    public void InstantiateVFXHead(GameObject prefab)
    {
        GameObject temp = Instantiate(prefab, vfxHead);
        Destroy(temp, 3f);
    }
}
