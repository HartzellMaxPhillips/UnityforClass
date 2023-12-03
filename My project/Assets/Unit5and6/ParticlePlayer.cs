using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem.Stop(); // Make sure the particle system is initially stopped
    }

    public void PlayParticles()
    {
        particleSystem.Play();
    }
}
