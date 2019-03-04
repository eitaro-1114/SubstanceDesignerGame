using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Substance.Game;

public class MandaraDepth : MonoBehaviour
{
    public Substance.Game.SubstanceGraph Mandara_Normal;
    Slider NormalValue;

    private void Start()
    {
        NormalValue = GetComponent<Slider>();
    }
    public void Mandara_Depth_Slide()
    {
        Mandara_Normal.SetInputFloat("Height_Depth", NormalValue.value);
        Mandara_Normal.QueueForRender();
        Substance.Game.Substance.RenderSubstancesAsync();
    }
}
