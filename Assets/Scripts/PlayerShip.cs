using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private float speed;
    private IWeapon activeWeapon;
    private List<IWeapon> weapons;

    void Start()
    {
        weapons = new List<IWeapon> { new MissileLauncher(0.5f, gameObject), new LaserCannon(0.5f, gameObject) };
    }

    public void SetSpeed(float _speed)
    {
        speed = _speed;
    }

    private float GetSpeed()
    {
        return speed;
    }

    public void Control()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * GetSpeed(), 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * GetSpeed(), 0f, 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, Time.deltaTime * GetSpeed(), 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -Time.deltaTime * GetSpeed(), 0f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            SetWeapon(weapons[0]);
            activeWeapon.Shoot();
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            SetWeapon(weapons[1]);
            activeWeapon.Shoot();
        }
    }

    private void SetWeapon(IWeapon _weapon)
    {
        activeWeapon = _weapon;
    }
}