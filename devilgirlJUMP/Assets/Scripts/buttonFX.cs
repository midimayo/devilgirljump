using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonFX : MonoBehaviour
{
    public AudioSource myFx;
    [SerializeField]
    public AudioClip hoverFx, clickFx;

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }

}
