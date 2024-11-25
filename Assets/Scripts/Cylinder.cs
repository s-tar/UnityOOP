using UnityEngine;

public class Cylinder : Figure // INHERITANCE
{
    void Start()
    {
        Axis = Vector3.forward;
        Speed = 3f;
    }
    public override void Animate()  // ABSTRACTION
    {
        transform.Translate(Axis * (Mathf.PingPong(Time.time, Speed * 2) - Speed) * Time.deltaTime);
    }
}
