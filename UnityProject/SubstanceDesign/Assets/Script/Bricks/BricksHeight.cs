using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class BricksHeight : MonoBehaviour
{
    
    public Substance.Game.SubstanceGraph bricks_height;
    Slider heightValue;
    // Start is called before the first frame update
    void Start()
    {
        heightValue = GetComponent<Slider>();
    }

    public void BrickHeight()
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
        bricks_height.SetInputFloat("Bricks_Height", heightValue.value);
        bricks_height.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
