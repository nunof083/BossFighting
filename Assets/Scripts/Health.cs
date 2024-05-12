using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float health = 100f;

    public void RemoveHealh(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
