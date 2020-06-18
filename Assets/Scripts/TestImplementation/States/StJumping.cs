using System.Collections;
using System.Collections.Generic;
using ActorSystem2D;
using UnityEngine;

public class JumpState : State
{
    private Jump jumpAction;

    public JumpState(Controller controller) : base(controller)
    {
        jumpAction = controller.GetComponent<Jump>();
    }

    protected override bool MustTransition()
    {
        throw new System.NotImplementedException();
    }
}