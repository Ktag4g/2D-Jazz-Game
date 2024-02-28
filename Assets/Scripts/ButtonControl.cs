using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public KeyCode keybind = KeyCode.None;
    public SpriteRenderer sprite;

    public Color notPressedColor;
    public Color pressedColor;

    private bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(keybind))
        {
            isPressed = true;
        }
        else
        {
            isPressed = false;
        }

        if (isPressed)
        {
            sprite.color = pressedColor;
        }
        else
        {
            sprite.color = notPressedColor;
        }
    }
}
