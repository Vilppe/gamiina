using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RandomEvents : MonoBehaviour
{
    public GameObject target;


    void Start()
    {
        Invoke("playOuch", 1);
    }

    void playOuch()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        float randomTime = Random.Range(1, 5);
        Invoke("playOuch", randomTime);
    }

}