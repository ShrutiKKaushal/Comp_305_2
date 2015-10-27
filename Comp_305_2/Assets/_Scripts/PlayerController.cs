using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _coinSound;
	// Use this for initialization
	void Start () {
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._coinSound = this._audioSources[0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("coin"))
        {
            this._coinSound.Play();
        }
    }
}
