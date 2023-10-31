using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float damage;

    [SerializeField]
    private Collider collider;

    private void OnCollisionEnter(Collision collision)
    {
        Detect(collision.collider);
    }

    public void Detect(Collider collider)
    {
        if (collider.TryGetComponent(out HitBody hitBody))
        {
            hitBody.Damage(damage);
        }
    }
}