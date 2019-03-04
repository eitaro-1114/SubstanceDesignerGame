using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class MandaraNormal : MonoBehaviour
{
    public Substance.Game.SubstanceGraph Mandara_Normal;
    Slider NormalValue;

    private void Start()
    {
        NormalValue = GetComponent<Slider>();
    }
    public void Mandara_Normal_Slide()
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

        Mandara_Normal.SetInputFloat("Normal", NormalValue.value);
        Mandara_Normal.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
