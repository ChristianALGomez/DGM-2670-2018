using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour {

    public int value;
    public Color colorTint;
    private GameObject Holder;
    public Holder myHolder;

    private void Start()
    {
        myHolder = FindObjectOfType<Holder>().GetComponent<Holder>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        myHolder.IncrementScore(value);
        Destroy(gameObject);
    }
}
