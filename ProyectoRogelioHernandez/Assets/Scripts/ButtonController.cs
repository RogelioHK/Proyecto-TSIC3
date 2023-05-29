using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private Button pauseButton;
    [SerializeField] private Sprite spirtePause;
    [SerializeField] private Sprite spirteStart;
    private bool isRotate = false;
    //public string SceneName;

    void Start()
    {
        pauseButton = GetComponent<Button>();
        pauseButton.onClick.AddListener(PauseResume);
    }

    void PauseResume()
    {
        isRotate = !isRotate;
        if (isRotate)
            pauseButton.image.sprite = spirtePause;
        else
            pauseButton.image.sprite = spirteStart;
    }
}
