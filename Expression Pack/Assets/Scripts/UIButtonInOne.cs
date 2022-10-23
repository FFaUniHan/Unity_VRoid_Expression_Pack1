using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIButtonInOne : MonoBehaviour
{
    [SerializeField] private Sprite emoticon;
    [SerializeField] private string text;

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

        if(tmp != null)
            tmp.text = text;

        if(button != null)
            button.onClick.AddListener(() => exc.SetExpression(text));
    }
}
