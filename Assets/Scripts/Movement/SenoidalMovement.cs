using UnityEngine;

public class SenoidalMovement : IMovement
{
    private const float amplitude = 1f;
    private const float frequency = 2f;

    public void Move(GameObject go)
    {
        float yMovement = amplitude * (Mathf.Sin(2 * Mathf.PI * frequency * Time.time) - Mathf.Sin(2 * Mathf.PI * frequency * (Time.time - Time.deltaTime)));
        go.transform.Translate(Time.deltaTime * 10f, yMovement, 0f);
    }
}
