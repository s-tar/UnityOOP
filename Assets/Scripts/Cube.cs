using Unity.VisualScripting;
using UnityEngine;

public class Cube : Figure // INHERITANCE
{
    void Start()
    {
        Axis = Vector3.up;
        Speed = 10f;
    }
    public override void Animate() // ABSTRACTION
    {
        transform.Rotate(Axis, Speed * Time.deltaTime);
    }
}
