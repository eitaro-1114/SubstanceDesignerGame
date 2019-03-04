using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class WakayamaAO : MonoBehaviour
{
    public Substance.Game.SubstanceGraph wakayama_AO;
    Slider AOvalue;

    private void Start()
    {
        AOvalue = GetComponent<Slider>();
    }
    public void Wakayama_AO()
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
        wakayama_AO.SetInputFloat("AO", AOvalue.value);
        wakayama_AO.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
