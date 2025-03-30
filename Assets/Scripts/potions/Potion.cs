using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class Potion : MonoBehaviour
{
    public abstract void Use(Hero hero);
    
}