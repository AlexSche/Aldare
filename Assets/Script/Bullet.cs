using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public GameObject impactEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        switch(other.gameObject.tag)
        {
            case "Wall":
            Destroy(gameObject);
            break;
            case "Enemy":
            //other.GameObject.GetComponent<MyEnemyScript>().TakeDamage;
            Impact();
            break;
        }
    }
    public void Impact()
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
