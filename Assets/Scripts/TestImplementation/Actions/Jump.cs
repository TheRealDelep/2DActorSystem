using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ActorSystem2D;

public class Jump : Action
{
    private Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    protected internal void Execute()
    {
        rbody.AddForce(new Vector2(0, 100));
    }

    protected internal void Cancel()
    {
    }
}