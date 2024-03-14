using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crickets : MonoBehaviour
{
    public AudioSource audioSource;

    public float stopDistance;

    private Transform player;
    private float defaultVolume;

    void Start()
    {
        defaultVolume = audioSource.volume;


    }

    // Update is called once per frame
    private void Update()
    {
        if (player == null)
            return;

        float dist = Vector3.Distance(transform.position, player.position);

        if (dist > stopDistance)
        {
            audioSource.volume = defaultVolume;
        }
        else
        {
            audioSource.volume = 0.0f;

        }
    }
}
