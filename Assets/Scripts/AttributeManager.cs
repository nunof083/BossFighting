using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributeManager : MonoBehaviour
{
    public int health;
    public Slider healthBar;
    public int attack;

    public Animator animatorBoss;


    void Update()
    {
        healthBar.value = health;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        DamagePopUpGenerator.current.CreatePopUp(transform.position, amount.ToString());

        if (health <= 0)
        {
            animatorBoss.SetTrigger("isDead");
        }
        else
        {
            animatorBoss.SetTrigger("isHit");
        }
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributeManager>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
        }
    }
}
