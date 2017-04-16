using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{


    public AudioSource[] auts = new AudioSource[4];

    // Use this for initialization
    void Start ()
    {
        auts[0] = GameObject.Find("Huuto").GetComponent<AudioSource>();
        auts[1] = GameObject.Find("Huuto2").GetComponent<AudioSource>();
        auts[2] = GameObject.Find("Huuto3").GetComponent<AudioSource>();
        auts[3] = GameObject.Find("Huuto4").GetComponent<AudioSource>();
    }
    void playOuch()
    {
        if (!auts[0].isPlaying && !auts[1].isPlaying && !auts[2].isPlaying && !auts[3].isPlaying)
        {
            auts[Random.Range(0, 3)].Play();
        }
    }
    // Update is called once per frame
    void Update () {
        
	}

    void OnControllerColliderHit(ControllerColliderHit col)
    {
        if (col.gameObject.name == "Pontto" )
        {
            playOuch();
        }
    }
}
