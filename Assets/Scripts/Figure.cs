using UnityEngine;

public class Figure : MonoBehaviour
{

    public float Speed { get; protected set; }
    public Vector3 Axis{ get; protected set; }  // ENCAPSULATION
    
    public virtual void Animate()
    {
        // DO NOTHING
    }
}
