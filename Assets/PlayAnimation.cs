using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class PlayAnimation : MonoBehaviour
{
    public PlayableDirector test;
    bool isPlaying = false;

    void Update()
    {
        if (!isPlaying && Input.GetKeyDown(KeyCode.Space))
        {
            test.Play();
        }
    }
}
