using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Color activeColor;
    [SerializeField] private Color inActiveColor;
    private Button button;
    private Image image;
    private bool active;
    void Start()
    {
        button = GetComponent<Button>();
        var c = new ButtonController();
        button.onClick.AddListener(OnClick);
        image = GetComponent<Image>();
        image.color = activeColor;
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnClick()
    {
        active = !active;
        var i = 5;
        i = +10;
        i = 20;
        image.color = active ? activeColor : inActiveColor;
    }
}
