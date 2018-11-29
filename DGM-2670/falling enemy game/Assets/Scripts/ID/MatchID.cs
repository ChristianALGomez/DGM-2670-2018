using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{

    public NameID ID;
    public UnityEvent OnMatch, NoMatch;
    public bool MatchMade { private get; set; }

    private void OnTriggerEnter(Collider other)
    {
        var otherId = other.GetComponent<MatchID>();

        if (otherId.ID == ID || otherId.MatchMade)
        {
            OnMatch.Invoke();
        }

        else
        {
            NoMatch.Invoke();
        }
    }

    /*public void Call(NameID id)
    {
        if (id == ID)
        {
            OnMatch.Invoke();
        }
    }


    private void Invoke(NameID id)
    {
        if (id == ID)
        {
            OnMatch.Invoke();
        }
    }*/
}
