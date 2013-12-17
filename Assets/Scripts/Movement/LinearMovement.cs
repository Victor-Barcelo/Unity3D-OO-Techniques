using UnityEngine;

public class LinearMovement : IMovement
{
    public void Move(GameObject go)
    {
        go.transform.Translate(Time.deltaTime * 10, 0f, 0f);
    }
}
