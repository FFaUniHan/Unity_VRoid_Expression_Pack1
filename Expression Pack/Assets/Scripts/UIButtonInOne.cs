using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIButtonInOne : MonoBehaviour
{
    [SerializeField] private string text;
    [SerializeField] private Sprite emoticon;
    public AnimationClip anim;

    [Header("References")]
    [SerializeField] private UIExpressionControl exc;
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI tmp;
    [SerializeField] private Button button;

    private void OnValidate()
    {
        if(button != null)
            button.onClick.RemoveAllListeners();

        if(image != null)
            image.sprite = emoticon;

        if (tmp != null)
        {
            tmp.text = text;
            gameObject.name = "Button " + text;
        }

        if(button != null)
            button.onClick.AddListener(() => exc.SetExpression(text));
    }
}
