using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemThing : MonoBehaviour
{

    public List<ParticleSystem> particlesToPlay;

    public void Play()
    {
        foreach (ParticleSystem particle in particlesToPlay)
        {
            particle.Play();
        }
    }
}
