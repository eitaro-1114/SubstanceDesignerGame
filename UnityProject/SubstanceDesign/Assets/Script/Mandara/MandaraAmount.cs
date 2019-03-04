using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class MandaraAmount : MonoBehaviour
{
    public Substance.Game.SubstanceGraph Mandara_amount;
    Slider amountValue;

    private void Start()
    {
        amountValue = GetComponent<Slider>();
    }
    public void Mandara_Amount_Slide()
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
        Mandara_amount.SetInputInt("Mandala_amount", (int)amountValue.value);
        Mandara_amount.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}