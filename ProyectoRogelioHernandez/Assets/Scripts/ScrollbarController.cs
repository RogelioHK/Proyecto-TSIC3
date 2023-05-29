using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;
//using UnityEngine.UIElements;

public class ScrollbarController : MonoBehaviour
{
    [SerializeField] private Scrollbar scrollbar;
    private Button leftButton;
    private Button rightButton;
    private Text leftText;
    private Text rightText;
    private Color lastItemColor = new Color(0.2169f, 0.2169f, 0.2169f);
    private Color middleItemColor = new Color(1.0f, 1.0f, 1.0f);
    private const float scrollAmount = 0.1f;

    private void Start()
    {
        leftButton = GameObject.Find("Left").GetComponent<Button>();
        rightButton = GameObject.Find("Right").GetComponent<Button>();
        leftText = leftButton.GetComponentInChildren<Text>();
        rightText = rightButton.GetComponentInChildren<Text>();
        ScrollLeft();
        leftButton.onClick.AddListener(ScrollLeft);
        rightButton.onClick.AddListener(ScrollRight);
    }
    public void ScrollLeft()
    {
        scrollbar.value = scrollbar.value <= 0.0f ? 0.0f : scrollbar.value -= scrollAmount;
        leftText.color = scrollbar.value == 0.0 ? lastItemColor : middleItemColor;
        rightText.color = scrollbar.value == 1.0f ? lastItemColor : middleItemColor;
    }

    public void ScrollRight()
    {
        scrollbar.value = scrollbar.value >= 1.0f ? 1.0f : scrollbar.value += scrollAmount;
        leftText.color = scrollbar.value == 0.0 ? lastItemColor : middleItemColor;
        rightText.color = scrollbar.value == 1.0f ? lastItemColor : middleItemColor;
    }
}
