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
        Vector2 force = power * displacement.normalized;
        particle.AddForce(force);
        // TODO: YOUR CODE HERE
    }
}
