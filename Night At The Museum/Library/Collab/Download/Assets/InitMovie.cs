using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitMovie : MonoBehaviour {

    public GameObject Quad;
    public GameObject UITEST;
    public AudioSource song;
    bool isPressed = false;
    
    void Start()
    {
        Quad.SetActive(false);
    }

    public void Activate()
    {
        //play video
        if (isPressed == false)
        {
            UITEST.SetActive(false);
            song.Pause();
            Quad.GetComponent<MoviePlayerSample>().startVideo(); //goes into MoviePlayerSample script, initiates method startVideo (i created)
            Quad.SetActive(true);
            isPressed = true;
        }
        //stop video
        else if (isPressed == true)
        {
            UITEST.SetActive(true);
            song.Play();
            Quad.GetComponent<MoviePlayerSample>().pauseVideo();
            Quad.SetActive(false);
            isPressed = false;
        }
     }
}
