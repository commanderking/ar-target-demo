using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFireBallSound : MonoBehaviour {
    private AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = this.GetComponent<AudioSource>();
        audio.Play();
           // Debug.Log("Hey");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
