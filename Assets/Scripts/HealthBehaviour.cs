using System;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    [SerializeField]private int _startHealth;

    private int _health;
    public int Health => _health;

    private void Awake()
    {
        _health = _startHealth;
    }

    public void AddHealth(int addedHealth)
    {
        if (addedHealth > 0)
        {
            _health += addedHealth;
        }
        Debug.Log(_health);
    }
}