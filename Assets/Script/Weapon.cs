using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bullet;
    public Transform firepoint;

    public void Fire()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
