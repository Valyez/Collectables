using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class Potion : MonoBehaviour
{
    public virtual void Use(Hero hero)
    {
        Destroy(gameObject);
        ParticleSystem particleSystem = (ParticleSystem) hero.gameObject.GetComponentInChildren(typeof(ParticleSystem));
        particleSystem.Play();
    }
}