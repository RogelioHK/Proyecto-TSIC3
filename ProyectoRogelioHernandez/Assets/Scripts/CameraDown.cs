using UnityEngine;
using Vuforia;

public class CameraDown : MonoBehaviour
{
    private VuforiaBehaviour vuforiaBehaviour;

    private void Start()
    {
        vuforiaBehaviour = FindObjectOfType<VuforiaBehaviour>();
        vuforiaBehaviour.enabled = false;
    }

    public void ToggleCamera()
    {
        if (vuforiaBehaviour != null)
        {
            vuforiaBehaviour.enabled = false;
        }
    }
}

