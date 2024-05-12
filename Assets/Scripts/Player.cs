using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health;
    public GameObject healthBarObject;
    public Slider healthBar;

    internal int attack;

    private bool isHit = false;
    private float hitAnimationDuration = 0.3f;

    public Animator animatorPlayer;

    void Start()
    {
        
    }

    void Update()
    {
        attack = UnityEngine.Random.Range(9, 20);
        healthBar.value = health;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        DamagePopUpGenerator.current.CreatePopUp(transform.position, amount.ToString());

        if (health <= 0)
        {
            animatorPlayer.SetBool("isDead", true);
            healthBarObject.SetActive(false);
            Debug.Log("dead");
        }
        else
        {
            animatorPlayer.SetBool("isHit", true);
            StartCoroutine(ResetHitAnimation());
        }
    }

    IEnumerator ResetHitAnimation()
    {
        isHit = true;
        yield return new WaitForSeconds(hitAnimationDuration);
        animatorPlayer.SetBool("isHit", false);
        isHit = false;
    }


    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<Boss>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
        }
    }
}
