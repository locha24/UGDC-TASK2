using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBody : MonoBehaviour
{
    [SerializeField]
    private float hp = 100;

    [SerializeField]
    private Collider collider;

    public void Damage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
        if (hp < 100)
        {
            Debug.Log(hp);
        }
    }

    private void Die()
    {
        GetComponent<Renderer>().enabled = false;
        collider.enabled = false;
    }
}
