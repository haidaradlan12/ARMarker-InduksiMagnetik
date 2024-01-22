using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManagerMain : MonoBehaviour
{
    public RectTransform Popup;
    // Start is called before the first frame update
    void Start()
    {
        Popup.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void Hidebutton()
    {
        Popup.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void Unhidebutton()
    {
        Popup.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
