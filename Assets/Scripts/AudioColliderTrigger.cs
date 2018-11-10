using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioColliderTrigger : MonoBehaviour {

    public AudioSource ColliderSound;
    public float ColliderVolume;
    public bool PlayFromStart = false;
    public bool ChangeVolumeOnEnter = false;
    public bool ChangeVolumeOnExit = false;

	// Use this for initialization
	void Start () {
        if (PlayFromStart)
        {
            ColliderSound.Play();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("We entered the Collider");
        //ColliderSound.Play();
        //ColliderSound.volume = ColliderVolume;
        //ColliderSound.pitch = ColliderVolume;
        if (ChangeVolumeOnEnter)
        {
            ColliderSound.volume = ColliderVolume;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //ColliderSound.Stop();
        //ColliderSound.volume = 1;
        //ColliderSound.pitch = 1;
        if (ChangeVolumeOnExit)
        {
            ColliderSound.volume = 1;
        }

    }
}
