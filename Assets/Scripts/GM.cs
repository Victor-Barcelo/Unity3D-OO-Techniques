using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour
{
    //Inspector variables
    public GameObject ts_PlayerShip;
    public GameObject ts_Projectile1;
    public GameObject ts_Projectile2;

    //Statics: References
    static public PlayerShip PlayerShip;
    static public GameObject Projectile1;
    static public GameObject Projectile2;

    void Start()
    {
        PlayerShip = ts_PlayerShip.GetComponent<PlayerShip>();
        Projectile1 = ts_Projectile1;
        Projectile2 = ts_Projectile2;
    }
}