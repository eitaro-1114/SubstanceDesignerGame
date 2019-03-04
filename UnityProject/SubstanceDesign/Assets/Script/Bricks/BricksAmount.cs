using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class BricksAmount : MonoBehaviour
{
    public Substance.Game.SubstanceGraph brick_amount;
    Slider amountValue;

    private void Start()
    {
        amountValue = GetComponent<Slider>();
    }
    public void BrickAmount()
    {
        // MaterialSelectの画面が開いていたら，消しておく
        if (GameObject.Find("SelectMaterial") == true)
        {
            GameObject Select = GameObject.Find("SelectMaterial");
            Select.SetActive(false);
        }

        // ObjectSelectの画面が開いていたら，消しておく
        if (GameObject.Find("SelectObject") == true)
        {
            GameObject Select = GameObject.Find("SelectObject");
            Select.SetActive(false);
        }
        brick_amount.SetInputInt("Brick_amount", (int)amountValue.value * 2);
        brick_amount.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
