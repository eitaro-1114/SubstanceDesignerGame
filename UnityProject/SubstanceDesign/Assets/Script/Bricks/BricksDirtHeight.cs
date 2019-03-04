using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class BricksDirtHeight : MonoBehaviour
{
    public Substance.Game.SubstanceGraph bricks_dirt;
    Slider dirtValue;

    // Start is called before the first frame update
    void Start()
    {
        dirtValue = GetComponent<Slider>();
    }

    public void BrickDirtHeight()
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
        bricks_dirt.SetInputFloat("Dirt_Height", dirtValue.value);
        bricks_dirt.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
