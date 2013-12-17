using System;
using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
    enum State
    {
        Configuring,
        ControllingShip
    }
    private State state;
    private PlayerShip ship;

    Void Update()
    {
        switch (state)
        {
            case State.Configuring: Configure(); break;
            case State.ControllingShip: ControlShip(); break;
        }
    }

    private void Configure()
    {
        ship = GM.PlayerShip;
        ship.SetSpeed(5f);
        state = State.ControllingShip;
    }

    private void ControlShip()
    {
        ship.Control();
    }
}