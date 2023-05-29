using UnityEngine;
using Vuforia;

public class CameraToggle : MonoBehaviour
{
    private VuforiaBehaviour vuforiaBehaviour;
    private GameObject backgroundObject;
    private GameObject foodModel;

    private void Start()
    {
        vuforiaBehaviour = FindObjectOfType<VuforiaBehaviour>();
        backgroundObject = GameObject.Find("BlackBackground"); // Reemplaza "BlackBackground" con el nombre del objeto de fondo negro en tu escena
        backgroundObject.SetActive(true);
    }

    public void ActivateCamera(GameObject foodModel)
    {
        if (vuforiaBehaviour != null)
        {
            VuforiaRenderer.Instance.Pause(false);
            backgroundObject.SetActive(false);
        }
        this.foodModel = foodModel;
    }

    public void DeactivateCamera()
    {
        if (vuforiaBehaviour != null)
        {
            VuforiaRenderer.Instance.Pause(true);
            backgroundObject.SetActive(true);
            foodModel = GameObject.Find(foodModel.name);
            foodModel.SetActive(false);
        }
    }
}
