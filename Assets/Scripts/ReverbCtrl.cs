﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ReverbCtrl : MonoBehaviour {

    public AudioMixer mixer;
    public AudioMixerSnapshot[] snapshots;
    public float[] weights;

    public void BlendSnapshot(int triggerNr)
    {
        switch (triggerNr)
        {
            case 1:
                weights[0] = 1.0f;
                weights[1] = 0.0f;
                mixer.TransitionToSnapshots(snapshots, weights, 2.0f);
                break;
            case 2:
                weights[0] = .25f;
                weights[1] = .75f;
                mixer.TransitionToSnapshots(snapshots, weights, 1.0f);
                break;
            case 3:
                weights[0] = 0.0f;
                weights[1] = 1.0f;
                mixer.TransitionToSnapshots(snapshots, weights, 2.0f);
                break;


        }
    }

	
}
