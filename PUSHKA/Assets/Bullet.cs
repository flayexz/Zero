using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public float LifeTime;
    public float Distance;
    public double Damage;
    public LayerMask Target;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, Distance, Target);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Zombie"))
            {
                hitInfo.collider.GetComponent<Zombie>().TakeDamage(Damage);
            }
            Destroy(gameObject);
        }
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }
}