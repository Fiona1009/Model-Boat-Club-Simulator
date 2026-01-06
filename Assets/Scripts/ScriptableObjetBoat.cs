using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjetBoat", menuName = "Scriptable Objects/ScriptableObjetBoat")]
public class ScriptableObjetBoat : ScriptableObject
{
    [Range(0, 10)]
    public float maxSpeed = 6f;

    [Range(0.1f, 45f)]
    public float steeringSpeed = 4.5f;

    [Range(.01f, .5f)]
    public float maxForce = .03f;

    [Range(1, 10)]
    public float neighborhoodRadius = 4f;

    [Range(0.1f, 10f)]
    public float separationRadius = 2.4f;

    [Range(0, 3)]
    public float separationAmount = 1.1f;

    [Range(0, 3)]
    public float cohesionAmount = 0.3f;

    [Range(0, 3)]
    public float alignmentAmount = 0.5f;

    public float MaxSpeed
    {
        get { return maxSpeed; }
    }

    public float SteeringSpeed
    {
        get { return steeringSpeed; }
    }

    public float MaxForce
    {
        get { return maxForce; }
    }

    public float NeighborhoodRadius
    {
        get { return neighborhoodRadius; }
    }

    public float SeparationRadius
    {
        get { return separationRadius; }
    }

    public float SeparationAmount
    {
        get { return separationAmount; }
    }
    public float CohesionAmount
    {
        get { return cohesionAmount; }
    }
    public float AlignmentAmount
    {
        get { return alignmentAmount; }
    }
}