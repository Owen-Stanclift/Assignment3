using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttractorForce : ForceGenerator
{
    public Vector3 targetPos;
    public float power;

    public override void UpdateForce(Particle2D particle)
    {
        Vector2 displacement = (targetPos - particle.gameObject.transform.position);
        float squareDistance = Mathf.Pow(displacement.magnitude, 2);
        float scale = power / squareDistance;
        Vector2 force = displacement.normalized * scale;
        particle.AddForce(force);
        // TODO: YOUR CODE HERE
    }
}
