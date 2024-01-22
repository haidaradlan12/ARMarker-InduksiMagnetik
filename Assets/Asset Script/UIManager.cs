using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform Menu1, Menu2, Button, Informasi, Petunjuk;
    // Start is called before the first frame update
    void Start()
    {
        Menu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
    }
    public void Kembalibutton()
    {
        Menu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
    }
    public void Informasibutton()
    {
        Menu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
    }
    public void Petunjukbutton()
    {
        Menu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Menu2.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}