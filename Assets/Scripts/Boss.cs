using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public int health;
    public Slider healthBar;
    public int attack;
    public GameObject healthBarObject;
    public Animator animatorBoss;
    public GameObject boss;

    private Collider bossCollider;

    void Start()
    {
        bossCollider = boss.GetComponent<Collider>();
    }

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
            healthBarObject.SetActive(false);
            bossCollider.enabled = false;
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
