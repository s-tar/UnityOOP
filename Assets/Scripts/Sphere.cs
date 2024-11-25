using UnityEngine;

public class Sphere : Figure  // INHERITANCE
{
    private Vector3 _initialScale;
    void Start()
    {
        Axis = Vector3.forward;
        Speed = 3f;
        _initialScale = transform.localScale;
    }
    
    public override void Animate()  // ABSTRACTION
    {
        var scaleFactor = Mathf.Sin(Time.time * Speed) + 1.0f;
        transform.localScale = _initialScale * scaleFactor;
    }
}
