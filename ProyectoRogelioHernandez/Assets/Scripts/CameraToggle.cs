using UnityEngine;
using Vuforia;

public class CameraToggle : MonoBehaviour
{
    private VuforiaBehaviour vuforiaBehaviour;
    private bool isVuforiaInitialized = false;

    private void Start()
    {
        Debug.Log("Click on food menu");
        vuforiaBehaviour = FindObjectOfType<VuforiaBehaviour>();
        vuforiaBehaviour.enabled = false;
    }

    private void InitializeVuforia()
    {
        if (!isVuforiaInitialized)
        {
            VuforiaRuntime.Instance.InitVuforia();
            isVuforiaInitialized = false;
        }
    }

    public void ActiveCamera()
    {
        if (vuforiaBehaviour != null)
        {
            // Limpiar recursos relacionados con la cámara y el rastreo
            //VuforiaRenderer.Instance.Pause(true);
            //VuforiaRenderer.Instance.ClearVideoBackgroundConfigurations();

            // Reiniciar la configuración de Vuforia
            //VuforiaRuntime.Instance.Deinit();
            //InitializeVuforia();

            // Reactivar Vuforia
            vuforiaBehaviour.enabled = true;
            VuforiaRenderer.Instance.Pause(false);
            
            Debug.Log("AR activated");
        }
    }

    public void DesactiveCamera()
    {
        if (vuforiaBehaviour != null)
        {
            // Pausar la representación de la cámara y el rastreo
            VuforiaRenderer.Instance.Pause(true);
            vuforiaBehaviour.enabled = false;
            //VuforiaRenderer.Instance.ClearVideoBackgroundConfigurations();

            
            Debug.Log("AR deactivated");
        }
    }
}
