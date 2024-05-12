using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHandManager : MonoBehaviour
{
    public GameObject hand;

    public void EnableHandCollider(int isEnable)
    {
        if (hand != null)
        {
            var col = hand.GetComponent<Collider>();

            if (col != null)
            {
                if (isEnable == 1)
                {
                    col.enabled = true;
                }
                else
                {
                    col.enabled = false;
                }
            }
        }
    }
}
