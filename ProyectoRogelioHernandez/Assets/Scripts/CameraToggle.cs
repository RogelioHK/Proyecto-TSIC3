using UnityEngine;
using Vuforia;

public class CameraToggle : MonoBehaviour
{
    private VuforiaBehaviour vuforiaBehaviour;

    private void Start()
    {
        Debug.Log("Clic on food menu");
        vuforiaBehaviour = FindObjectOfType<VuforiaBehaviour>();
        vuforiaBehaviour.enabled = false;
    }

    public void ToggleCamera()
    {
        if (vuforiaBehaviour != null)
        {
            vuforiaBehaviour.enabled = true;
            Debug.Log("Active AR");
        }
    }
}

