using UnityEngine;

public class BaseMissileBehaviour : MonoBehaviour
{
    private IMovement movementType;

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        movementType.Move(gameObject);
    }

    public void SetMovement(IMovement _movementType)
    {
        movementType = _movementType;
    }
}