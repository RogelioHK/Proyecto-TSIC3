using UnityEngine;
using UnityEngine.UI;

public class ColorButtonController : MonoBehaviour
{
    [SerializeField] private Scrollbar scrollbar;
    private Button button;
    private Text text;
    private Color lastItemColor = new Color(0.2169f, 0.2169f, 0.2169f);
    private Color middleItemColor = new Color(1.0f, 1.0f, 1.0f);

    private void Start()
    {
        button = GetComponent<Button>();
        text = button.GetComponentInChildren<Text>();
        ChangeColor();
        button.onClick.AddListener(ChangeColor);
    }
    private void ChangeColor()
    {
        text.color = scrollbar.value == 1.0f || scrollbar.value == 0.0  ?  lastItemColor : middleItemColor;
    }
}