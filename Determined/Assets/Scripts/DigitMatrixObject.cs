using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DigitMatrixObject : MatrixObject
{
    private TMP_Text textWindow;
    [SerializeField] Sprite chosenMatrixObject = null;
    [SerializeField] Sprite activeMatrixObject = null;
    [SerializeField] Sprite blockedMatrixObject = null;

    public List<TMP_Text> matrixText;

    protected override void  Awake()
    {
        base.Awake();
        textWindow = GetComponentInChildren<TMP_Text>();
        textWindow.text = value.ToString();
    }

    public override void ChooseMatrixObject()
    {
        base.ChooseMatrixObject();
        gameObject.GetComponent<SpriteRenderer>().sprite = chosenMatrixObject;
        textWindow.gameObject.SetActive(false);
        //gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }

    public override void MakeMatrixObjectActive()
    {
        base.MakeMatrixObjectActive();
        gameObject.GetComponent<SpriteRenderer>().sprite = activeMatrixObject;
        textWindow.gameObject.SetActive(true);
        //gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }

    public override void BlockMatrixObject()
    {
        base.BlockMatrixObject();
        gameObject.GetComponent<SpriteRenderer>().sprite = blockedMatrixObject;
        textWindow.gameObject.SetActive(false);
        //gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
    }
}
