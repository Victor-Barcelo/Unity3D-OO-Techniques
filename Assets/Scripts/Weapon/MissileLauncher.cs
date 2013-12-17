using UnityEngine;

public class MissileLauncher : IWeapon
{
    private float fireDelay;
    private float timeSinceLastShoot;
    private GameObject owner;

    public MissileLauncher(float _fireDelay, GameObject _owner)
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
                    GameObject.Instantiate(GM.Projectile2, owner.transform.position, Quaternion.identity);
            projectile.GetComponent<BaseMissileBehaviour>().SetMovement(new SenoidalMovement());
            timeSinceLastShoot = Time.time;
        }
    }
}
