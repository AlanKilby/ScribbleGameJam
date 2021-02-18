using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject notebook;
    bool alreadyOpen = false;

    public AudioSource music;
    bool musicOff = false;

    public AudioSource sfx;
    bool sfxOff = false;


    public void OpenNotebook()
    {
        if (alreadyOpen == false)
        {
            notebook.SetActive(true);
            alreadyOpen = true;
        }
        else
        {
            notebook.SetActive(false);
            alreadyOpen = false;
        }
    }

    public void TurnOffMusic()
    {
        if(musicOff == true)
        {
            music.Play();
            musicOff = false;
        }
        else
        {
            music.Pause();
            musicOff = true;
        }
    }

    public void TurnOffSfx()
    {
        if(sfxOff == true)
        {
            sfx.Play();
            sfxOff = false;
        }
        else
        {
            sfx.Pause();
            sfxOff = true;
        }
    }
}
