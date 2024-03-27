using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatsScript : MonoBehaviour
{
    //Audio Variables
    public AudioSource audioSource;
    public AudioClip drumBeat;
    
    //Sprite Variables
    public SpriteRenderer sprite;
    public SpriteRenderer OS2;
    public SpriteRenderer OS3;
    public Color notPressedColor;
    public Color pressedColor;

    // Start is called before the first frame update
    void Start()
    {
        sprite.color = notPressedColor;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "DrumButton")
        {
            audioSource.clip = drumBeat;
            audioSource.Play();
            sprite.color = pressedColor;

            OS2.color = notPressedColor;
            OS3.color = notPressedColor;
        }
    }
}
