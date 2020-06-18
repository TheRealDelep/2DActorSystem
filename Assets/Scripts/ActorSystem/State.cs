using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ActorSystem2D
{
    public abstract class State
    {
        public static string Type { get; private set; }

        protected Controller controller;
        protected Action[] actions;

        public State(Controller controller)
        {
            Type = ToString();
            this.controller = controller;
        }

        protected virtual void OnStateInit()
        {
        }

        protected internal virtual void OnStateEnter()
        {
        }

        protected internal virtual void OnStateExit()
        {
        }

        protected internal virtual void Update()
        {
            if (!MustTransition())
            {
                foreach (Action action in actions)
                {
                    action.Perform();
                }
            }
        }

        protected abstract bool MustTransition();
    }
}