using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTriggerEnter : MonoBehaviour
{

    public AudioClip clip;
    private AudioSource source;
    public string targetTag;

    public bool useVelocity = true;
    public float minVelocity = 0;
    public float maxVelocity = 2;

    public bool randomizePitch = true;
    public float minPitch =  0.8f;
    public float maxPitch = 1.2f;


    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other){
        if(other.CompareTag(targetTag)){

            VelocityEstimator estimator = other.GetComponent<VelocityEstimator>();
            if(estimator && useVelocity){
                float v = estimator.GetVelocityEstimate().magnitude;
                float volume = Mathf.InverseLerp(minVelocity, maxVelocity, v);

                if(randomizePitch)
                    source.pitch = Random.Range(minPitch, maxPitch);

                source.PlayOneShot(clip, volume);
            }
            else{
                if(randomizePitch)
                    source.pitch = Random.Range(minPitch, maxPitch);    
                    
                source.PlayOneShot(clip);
            }
        }
    }

}
