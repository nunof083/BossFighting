using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttributes : MonoBehaviour
{
    public Player atm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Boss>().TakeDamage(atm.attack);
        }
    }
}