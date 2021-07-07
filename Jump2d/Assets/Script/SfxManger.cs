using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManger : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }
    //private void Start()
    //{
    //    if (_audioSource.isPlaying) return;
    //    _audioSource.Play();
    //}
    //public void PlayMusic()
    //{
    //    if (_audioSource.isPlaying) return;
    //    _audioSource.Play();
    //}
    //public void StopMusic()
    //{
    //    _audioSource.Stop();
    //}
}
