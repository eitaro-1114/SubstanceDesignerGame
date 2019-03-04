using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class WakayamaAmount : MonoBehaviour
{
    public Substance.Game.SubstanceGraph wakayama_amount;
    Slider amountValue;

    private void Start()
    {
        amountValue = GetComponent<Slider>();
    }
    public void WakayamaFloorAmount()
    {
        
        // MaterialSelectの画面が開いていたら，消しておく
        if(GameObject.Find("SelectMaterial") == true)
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
        wakayama_amount.SetInputInt("Floor_amount", (int)amountValue.value);
        wakayama_amount.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
