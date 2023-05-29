using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class FoodButtonManager : MonoBehaviour
{
    private string foodName;
    private Texture foodImage;
    private string foodDescription;
    private string foodPrice;
    private GameObject foodModel;
    public GameObject modelContainer; // Referencia al objeto contenedor del modelo 3D
    private List<GameObject> models = new List<GameObject>();


    public string FoodName { set => foodName = value; }
    public Texture FoodImage { set => foodImage = value; }
    public string FoodDescription { set =>  foodDescription = value; }
    public string FoodPrice { set => foodPrice = value; }
    public GameObject FoodModel { set => foodModel = value; }
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] foundModels = GameObject.FindGameObjectsWithTag("Model");
        models.AddRange(foundModels);
        GameObject cameraUp = GameObject.FindGameObjectWithTag("CameraUp");

        transform.GetChild(0).GetComponent<Text>().text = foodName;
        Debug.Log(foodName);
        transform.GetChild(1).GetComponent<RawImage>().texture = foodImage;
        transform.GetChild(2).GetComponent<Text>().text = foodDescription;
        transform.GetChild(3).GetComponent<Text>().text = foodPrice;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.Instance.ARPositionMenu);
        button.onClick.AddListener(Activate3DModel);
        button.onClick.AddListener(() => { cameraUp.GetComponent<CameraToggle>().ActivateCamera(foodModel); });
    }

    private void Activate3DModel()
    {
        // Desactivar todos los modelos existentes
        foreach (GameObject model in models)
        {
            if (model.name == foodModel.name)
                model.SetActive(true);
            else
                model.SetActive(false);

            Debug.Log(model.name);
        }
    }
}
