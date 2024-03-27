using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Audio 
    public AudioSource audioSource;

    //Charactar Anim
    public Animator charAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource.isPlaying)
        {
            charAnimator.SetBool("isPlaying", true);
        }
        else
        {
            charAnimator.SetBool("isPlaying", false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
