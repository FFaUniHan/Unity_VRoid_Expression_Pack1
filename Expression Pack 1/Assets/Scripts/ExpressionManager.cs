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
    private Texture faceDefault;
    private Texture browsDefault;
    private Texture eyeWhiteDefault;
    private Texture matCapDefault;

    private void Awake()
    {
        extraDefault = face.materials[9].GetTexture("_MainTex");
        eyeDefault = face.materials[5].GetTexture("_MainTex");
        eyeGlowDefault = face.materials[6].GetTexture("_MainTex");
        faceDefault = face.materials[7].GetTexture("_MainTex");
        browsDefault = face.materials[4].GetTexture("_MainTex");
        eyeWhiteDefault = face.materials[1].GetTexture("_MainTex");
        matCapDefault = face.materials[7].GetTexture("_SphereAdd");
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

    public void SwapTextureFace(Texture tex, bool noEmission)
    {
        face.materials[7].SetTexture("_MainTex", tex);
        face.materials[7].SetTexture("_ShadeTexture", tex);
        face.materials[8].SetTexture("_MainTex", tex);
        face.materials[8].SetTexture("_ShadeTexture", tex);

        if(noEmission == true)
        {
            face.materials[7].SetTexture("_SphereAdd", null);
            face.materials[8].SetTexture("_SphereAdd", null);
        }
    }

    public void SwapTextureFaceReturn()
    {
        face.materials[7].SetTexture("_MainTex", faceDefault);
        face.materials[7].SetTexture("_ShadeTexture", faceDefault);
        face.materials[8].SetTexture("_MainTex", faceDefault);
        face.materials[8].SetTexture("_ShadeTexture", faceDefault);

        face.materials[7].SetTexture("_SphereAdd", matCapDefault);
        face.materials[8].SetTexture("_SphereAdd", matCapDefault);
    }

    public void SwapTextureBrows(Texture tex)
    {
        face.materials[4].SetTexture("_MainTex", tex);
        face.materials[4].SetTexture("_ShadeTexture", tex);
    }

    public void SwapTextureBrowsReturn()
    {
        face.materials[4].SetTexture("_MainTex", browsDefault);
        face.materials[4].SetTexture("_ShadeTexture", browsDefault);
    }

    public void SwapTextureEyeWhite(Texture tex)
    {
        face.materials[1].SetTexture("_MainTex", tex);
        face.materials[1].SetTexture("_ShadeTexture", tex);
    }

    public void SwapTextureEyeWhiteReturn()
    {
        face.materials[1].SetTexture("_MainTex", eyeWhiteDefault);
        face.materials[1].SetTexture("_ShadeTexture", eyeWhiteDefault);
    }
}