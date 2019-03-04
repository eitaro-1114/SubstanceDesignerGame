using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{
    public GameObject SelectMaterial;       // マテリアル一覧のGUI
    public GameObject SelectObject;         // オブジェクト一覧のGUI

    public GameObject BricksParameter;      // 各マテリアルのSlider
    public GameObject MandaraParameter;
    public GameObject WakayamaUnivParameter;

    public Material Bricks;
    public Material Mandara;
    public Material WakayamaUniv;

    public GameObject Cube;
    public GameObject Cylinder;
    public GameObject Plane;
    public GameObject Sphere;

    public Sprite BricksImage;              // マテリアルのサムネ
    public Sprite MandaraImage;
    public Sprite WakayamaUnivImage;

    public Sprite CubeImage;                // オブジェクトのサムネ
    public Sprite CylinderImage;
    public Sprite PlaneImage;
    public Sprite SphereImage;

    private GameObject Obj;                 // 表示されているオブジェクト
    private GameObject newObj;              // 新しく更新されたオブジェクト
    private Material newMaterial;           // 新しく更新されたマテリアル

    public GameObject nowMaterial;          // nowMaterialボタン
    public GameObject nowObject;            // nowObjectボタン

    private void Start()
    {
        newMaterial = Bricks;               // 初期のマテリアルを設定
    }

    public void ViewMaterial()
    {
        // Object一覧を非表示にする
        if(SelectObject.activeSelf == true)
        {
            SelectObject.SetActive(false);
        }

        if(SelectMaterial.activeSelf == false)
        {
            SelectMaterial.SetActive(true);
        }
        else
        {
            SelectMaterial.SetActive(false);
        }

        // GameObject Parameter = GameObject.FindGameObjectWithTag("Parameter");
        // Parameter.SetActive(false);                                 // 一旦Sliderを非表示にする

    }

    public void ViewObject()
    {
        if (SelectMaterial.activeSelf == true)
        {
            SelectMaterial.SetActive(false);
        }

        if (SelectObject.activeSelf == false)
        {
            SelectObject.SetActive(true);
        }
        else
        {
            SelectObject.SetActive(false);
        }
    }

    public void BricksSelected()
    {
        Obj = GameObject.FindGameObjectWithTag("Object");
        Obj.GetComponent<Renderer>().material = Bricks;             // オブジェクトのマテリアルをBricksに変更
        newMaterial = Bricks;                                       // MaterialをBricksに更新

        nowMaterial.GetComponent<Image>().sprite = BricksImage;     // nowMaterialのサムネを変更

        // 今までのSliderを非表示
        GameObject Parameter = GameObject.FindGameObjectWithTag("Parameter");
        Parameter.SetActive(false);

        BricksParameter.SetActive(true);                            // Slider表示

        SelectMaterial.SetActive(false);                            // マテリアル一覧のGUIを非表示にする
    }

    public void MandaraSelected()
    {
        Obj = GameObject.FindGameObjectWithTag("Object");
        Obj.GetComponent<Renderer>().material = Mandara;
        newMaterial = Mandara;

        nowMaterial.GetComponent<Image>().sprite = MandaraImage;

        // 今までのSliderを非表示
        GameObject Parameter = GameObject.FindGameObjectWithTag("Parameter");
        Parameter.SetActive(false);

        MandaraParameter.SetActive(true);

        SelectMaterial.SetActive(false);
    }

    public void WakayamaUnivSelected()
    {
        Obj = GameObject.FindGameObjectWithTag("Object");
        Obj.GetComponent<Renderer>().material = WakayamaUniv;
        newMaterial = WakayamaUniv;

        nowMaterial.GetComponent<Image>().sprite = WakayamaUnivImage;

        // 今までのSliderを非表示
        GameObject Parameter = GameObject.FindGameObjectWithTag("Parameter");
        Parameter.SetActive(false);

        WakayamaUnivParameter.SetActive(true);

        SelectMaterial.SetActive(false);
    }

    public void CubeSelected()
    {
        // 今のオブジェクトを消去
        Obj = GameObject.FindGameObjectWithTag("Object");
        Destroy(Obj);

        // 新しいオブジェクトを生成
        GameObject newObj = Instantiate(Cube, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        newObj.GetComponent<Renderer>().material = newMaterial;

        // サムネ変更   
        nowObject.GetComponent<Image>().sprite = CubeImage;
        // GUI非表示
        SelectObject.SetActive(false);
    }

    public void CylinderSelected()
    {
        // 今のオブジェクトを消去
        Obj = GameObject.FindGameObjectWithTag("Object");
        Destroy(Obj);

        // 新しいオブジェクトを生成
        GameObject newObj = Instantiate(Cylinder, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        newObj.GetComponent<Renderer>().material = newMaterial;

        nowObject.GetComponent<Image>().sprite = CylinderImage;

        SelectObject.SetActive(false);
    }

    public void PlaneSelected()
    {
        // 今のオブジェクトを消去
        Obj = GameObject.FindGameObjectWithTag("Object");
        Destroy(Obj);

        // 新しいオブジェクトを生成
        GameObject newObj = Instantiate(Plane, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        newObj.GetComponent<Renderer>().material = newMaterial;

        nowObject.GetComponent<Image>().sprite = PlaneImage;

        SelectObject.SetActive(false);
    }

    public void SphereSelected()
    {
        // 今のオブジェクトを消去
        Obj = GameObject.FindGameObjectWithTag("Object");
        Destroy(Obj);

        // 新しいオブジェクトを生成
        GameObject newObj = Instantiate(Sphere, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        newObj.GetComponent<Renderer>().material = newMaterial;

        nowObject.GetComponent<Image>().sprite = SphereImage;

        SelectObject.SetActive(false);
    }
}
