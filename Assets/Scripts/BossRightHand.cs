using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRightHand : MonoBehaviour
{
    public Boss atm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().TakeDamage(atm.attack);
        }
    }
}
