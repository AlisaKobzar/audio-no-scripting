﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] shoot;
    private AudioClip shootClip;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
    }
        private void OnTriggerEnter(Collider other)
        {
            int index = Random.Range(0, shoot.Length);
            shootClip = shoot[index];
            audioSource.clip = shootClip;
            audioSource.Play();
        }
    }