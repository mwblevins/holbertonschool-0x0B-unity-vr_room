using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public ParticleSystem projectorParticles;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Button"))
        {
            projectorParticles.gameObject.SetActive(true);
        }
    }
}