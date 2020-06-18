using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActorSystem2D
{
    public abstract class Controller : MonoBehaviour
    {
        private Dictionary<string, State> states;
        private StateMachine stateMachine;

        public bool ContainState(string stateId) => states.ContainsKey(stateId);

        internal void TransitionTo(string nextStateType)
        {
            if (ContainState(nextStateType))
            {
                stateMachine.TransitionTo(states[nextStateType]);
            }
            else
            {
                Debug.LogError($"This controller doesn't contain a state of type {nextStateType}");
            }
        }

        protected virtual void Awake()
        {
            stateMachine = new StateMachine();
        }

        protected virtual void Start()
        {
        }

        protected virtual void Update()
        {
            stateMachine.UpdateState();
        }
    }
}