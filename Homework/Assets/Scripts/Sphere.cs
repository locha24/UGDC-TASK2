using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRandom : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem explosionEffect;
    [SerializeField]
    public float speed = 10f;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Random.onUnitSphere * 10;
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contactPoint = collision.contacts[0];
        Vector3 direction = (transform.position - contactPoint.point).normalized;
        rb.velocity = direction * speed;

        explosionEffect.Play();
    }
}
