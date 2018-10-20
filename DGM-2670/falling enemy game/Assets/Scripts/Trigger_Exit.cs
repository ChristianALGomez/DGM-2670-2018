using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Exit : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
