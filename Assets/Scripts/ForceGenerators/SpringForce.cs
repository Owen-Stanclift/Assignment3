using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringForce : ForceGenerator
{
    public Transform other = null;

    public float springConstant;

    public float restLength;

    public override void UpdateForce(Particle2D particle)
    {
        // TODO: YOUR CODE HERE
        Vector2 length = (particle.transform.position - other.position);
        float springDistance = length.magnitude - restLength;
        float springForce = (-springConstant) * springDistance;
        Vector2 force = length.normalized * springForce;
        particle.AddForce(force);
    }
}
