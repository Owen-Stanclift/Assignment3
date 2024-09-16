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
        Vector2 force = (targetPos - particle.gameObject.transform.position)*power;
        particle.AddForce(force);
        // TODO: YOUR CODE HERE
    }
}
