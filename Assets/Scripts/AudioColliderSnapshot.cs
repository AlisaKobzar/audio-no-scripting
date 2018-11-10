using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class AudioColliderSnapshot : MonoBehaviour {

    public AudioMixerSnapshot InsideColliderSnap;
    public AudioMixerSnapshot OutsideColliderSnap;
    public AudioMixerSnapshot StartColliderSnap;

    // Use this for initialization
    void Start () {
        StartColliderSnap.TransitionTo(1);

    }
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter(Collider other)
    {
        InsideColliderSnap.TransitionTo(.1f);
    }

    private void OnTriggerExit(Collider other)
    {
        OutsideColliderSnap.TransitionTo(1);
    }
}
