using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class TuteSoundScript : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioSource musicSource;

    public Animator anim;

    public void OnPlay1(CallbackContext context)
    {
        if(context.ReadValueAsButton())
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            anim.Play("Walk");
        }
        else
        {
            musicSource.Stop();
            anim.Play("Idle");
        }
    }

    public void OnPlay2(CallbackContext context)
    {
        if(context.ReadValueAsButton())
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            anim.Play("Run");
        }
        else
        {
            musicSource.Stop();
            anim.Play("Idle");
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
