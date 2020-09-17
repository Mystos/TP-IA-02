using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SphereCollider))]
public class FlockAgent : MonoBehaviour
{

    SphereCollider agentCollider;
    Flock agentFlock;
    public Flock AgentFlock { get { return agentFlock; } }
    public SphereCollider AgentCollider { get { return agentCollider;  } }
    // Start is called before the first frame update
    void Start()
    {
        agentCollider = GetComponent<SphereCollider>();

    }

    public void Initialize(Flock flock)
    {
        agentFlock = flock;
    }

    public void Move(Vector3 velocity)
    {
        transform.forward = velocity;
        transform.position += velocity * Time.deltaTime;
    }
}
