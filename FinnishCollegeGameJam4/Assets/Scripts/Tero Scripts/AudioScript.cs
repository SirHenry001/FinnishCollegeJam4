using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource m_MyAudioSource;
    public AudioClip[] sounds;
    //bool m_Play;
    //bool m_ToggleChange;



    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PlayAudio(int trackNumber)
    {
        m_MyAudioSource.clip = sounds[trackNumber];
        m_MyAudioSource.Play();
    }
}
