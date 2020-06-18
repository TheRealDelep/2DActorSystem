using ActorSystem2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class StateMachine
{
    private State currentState;

    internal void UpdateState()
    {
        currentState.Update();
    }

    internal void TransitionTo(State nextState)
    {
        currentState.OnStateExit();
        currentState = nextState;
        currentState.OnStateEnter();
    }
}