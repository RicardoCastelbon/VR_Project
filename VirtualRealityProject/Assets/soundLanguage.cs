using UnityEngine;
using System.Collections;

public class soundLanguage : MonoBehaviour {

    public AudioClip click;
    public AudioSource source;

    // Use this for initialization
    void Start () {

        source = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        }

    void OnTriggerEnter(Collider soundEnglish)
    {
        source.clip = click;
        source.Play();
    }
}
