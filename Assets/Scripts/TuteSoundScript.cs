using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class TuteSoundScript : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioSource musicSource;

    public void OnPlay1(CallbackContext context)
    {
        if(context.ReadValueAsButton())
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
        }
        else
        {
            musicSource.Stop();
        }
    }

    public void OnPlay2(CallbackContext context)
    {
        if(context.ReadValueAsButton())
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
        }
        else
        {
            musicSource.Stop();
        }
    }

    public void OnLoop(CallbackContext context)
    {
        musicSource.loop = context.ReadValueAsButton();
    }

    public void OnAbscond(CallbackContext context)
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
