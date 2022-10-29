using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get { return instance; } }

    public AudioClip[] levelClips;
    public AudioSource bgMusicAS;

    //
    private static SoundManager instance;
    private bool isSoundEnable;

    private void Awake()
    {
        if (SoundManager.Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        instance = this;

    }
}
