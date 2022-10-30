using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ExpressionManager: MonoBehaviour
{
    [SerializeField] private Renderer face;
    private Texture extraDefault;
    private Texture eyeDefault;
    private Texture eyeGlowDefault;

    private void Awake()
    {
        extraDefault = face.materials[9].GetTexture("_MainTex");
        eyeDefault = face.materials[5].GetTexture("_MainTex");
        eyeGlowDefault = face.materials[6].GetTexture("_MainTex");
    }

    public void SwapTextureExtra(Texture tex)
    {
        face.materials[9].SetTexture("_MainTex", tex);
        face.materials[9].SetTexture("_ShadeTexture", tex);
    }

    public void SwapTextureExtraReturn()
    {
        face.materials[9].SetTexture("_MainTex", extraDefault);
        face.materials[9].SetTexture("_ShadeTexture", extraDefault);
    }

    public void SwapTextureEye(Texture tex)
    {
        face.materials[5].SetTexture("_MainTex", tex);
        face.materials[5].SetTexture("_ShadeTexture", tex);
        face.materials[6].SetTexture("_MainTex", tex);
        face.materials[6].SetTexture("_ShadeTexture", tex);
    }

    public void SwapTextureEyeReturn()
    {
        face.materials[5].SetTexture("_MainTex", eyeDefault);
        face.materials[5].SetTexture("_ShadeTexture", eyeDefault);
        face.materials[6].SetTexture("_MainTex", eyeGlowDefault);
        face.materials[6].SetTexture("_ShadeTexture", eyeGlowDefault);
    }
}