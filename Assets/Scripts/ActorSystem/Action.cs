using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActorSystem2D
{
    public abstract class Action : MonoBehaviour
    {
        public event System.Action ActionStart;
        public event System.Action ActionEnd;

        internal virtual void Perform()
        {
        }

        internal virtual void Cancel()
        {
        }
    }
}