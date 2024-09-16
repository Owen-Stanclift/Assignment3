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
        Vector2 length = (other.position - particle.transform.position) - restLength;
        float springForce = -springConstant * length;
        Vector2 force = -particle.velocity * springForce;
        particle.AddForce(force);
    }
}
