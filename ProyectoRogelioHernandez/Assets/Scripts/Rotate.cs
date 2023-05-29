using UnityEngine;
using Vuforia;
using UnityEngine.UI;


public class Rotate : MonoBehaviour
{
    public Camera cameraAR;
    private bool isRotate = false;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        cameraAR = VuforiaBehaviour.Instance.GetComponent<Camera>();
        button = GameObject.Find("PauseButton").GetComponent<Button>();
        button.onClick.AddListener(ActivateRotation);
    }

    private void ActivateRotation()
    {
        isRotate = !isRotate;;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotate)
            transform.Rotate(Vector3.up * Time.deltaTime * 50);
    }
}
