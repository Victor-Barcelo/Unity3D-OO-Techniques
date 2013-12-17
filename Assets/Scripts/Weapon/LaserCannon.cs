using UnityEngine;

public class LaserCannon : IWeapon
{
    private float fireDelay;
    private float timeSinceLastShoot;
    private GameObject owner;

    public LaserCannon(float _fireDelay, GameObject _owner)
    {
        owner = _owner;
        fireDelay = _fireDelay;
    }

    public void Shoot()
    {
        if (Time.time > fireDelay + timeSinceLastShoot)
        {
            GameObject projectile =
                (GameObject)
                    GameObject.Instantiate(GM.Projectile1, owner.transform.position, Quaternion.identity);
            projectile.GetComponent<BaseMissileBehaviour>().SetMovement(new LinearMovement());
            timeSinceLastShoot = Time.time;
        }
    }
}

