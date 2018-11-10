using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTrigger : MonoBehaviour {

    public ReverbCtrl reverbCtrl;
    //public AudioEchoFilter audioEchoFilter;
    public int triggerNr;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        reverbCtrl.BlendSnapshot(triggerNr);
        //audioEchoFilter.BlendSnapshot(triggerNr);
    }

}
