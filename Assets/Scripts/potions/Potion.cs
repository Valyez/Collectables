using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class Potion : MonoBehaviour
{
    public virtual void Use(GameObject gameObject)
    {
        Destroy(this.gameObject);
    }

    public void Collect()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.Play("Stop");
        Collider potionCollider = gameObject.GetComponent<Collider>();
        potionCollider.enabled = false;
        transform.SetParent(transform);
    }
}