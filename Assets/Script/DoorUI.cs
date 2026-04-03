using UnityEngine;
using TMPro;

public class DoorUI : MonoBehaviour
{
    public static DoorUI instance;

    public GameObject panel;
    public TextMeshProUGUI text;

    void Awake()
    {
        instance = this;
        panel.SetActive(false);
    }

    public void Show(string message)
    {
        panel.SetActive(true);
        text.text = message;
    }

    public void Hide()
    {
        panel.SetActive(false);
    }
}