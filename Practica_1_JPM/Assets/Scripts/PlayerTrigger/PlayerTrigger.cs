using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            OnPlayerEnter(other.gameObject);
        }
    }

    public virtual void OnPlayerEnter(GameObject playerObject)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            OnPlayerExit(other.gameObject);
        }
    }

    public virtual void OnPlayerExit(GameObject playerObject)
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            OnplayerStay(other.gameObject);
        }
    }

    public virtual void OnplayerStay(GameObject playerObject)
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            OnPlayerEnter(collision.gameObject);
        }
    }
}