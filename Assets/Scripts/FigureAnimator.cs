using UnityEngine;

public class FigureAnimator : MonoBehaviour
{
    
    [SerializeField] private Figure[] figures;

    void Update()
    {
        foreach (Figure figure in figures)
        {
            figure.Animate(); // POLYMORPHISM
        }
    }
}
