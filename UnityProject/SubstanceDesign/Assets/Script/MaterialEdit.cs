using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialEdit : MonoBehaviour {

    public GameObject CubeObj;

    public int ScreenWidth;
    public int ScreenHeight;

    // Use this for initialization
    void Start () {

        // Screen解像度設定
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.LinuxPlayer)
        {
            Screen.SetResolution(ScreenWidth, ScreenHeight, false);
        }


        GameObject Cube = Instantiate(CubeObj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        Cube.name = "Cube";
	}

}
