using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laugh : MonoBehaviour {
    AudioSource Audio;

	// Use this for initialization
	void Start () {
        Audio = FindObjectOfType<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Joueur")
        {
            Audio.Play();
        }
    }
}
