using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bullet;
    public Transform firepoint;
    public float fireForce;

    public void Fire()
    {
        GameObject projectile = Instantiate(bullet, firepoint.position, firepoint.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firepoint.up * fireForce, ForceMode2D.Impulse);
    }
}
