using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPos;

    public float shootForce;

    public string soundToPlay;

    public bool canShoot;

    public void Shoot()
    {
        if (canShoot)
        {
            GameObject projectile = Instantiate(projectilePrefab, shootPos.position, Quaternion.identity);
            Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();
            projectileRB.velocity = shootPos.forward * shootForce;

            AudioManager.instance.Play(soundToPlay);
        }
    }

    public void ChangeCanShoot(bool canShoot)
    {
        this.canShoot = canShoot;
    }
}
