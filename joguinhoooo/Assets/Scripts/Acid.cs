using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidFloor : MonoBehaviour
{
    private Vector3 respawnPoint = new Vector3(-3.31f, -2.09f, 0f);

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.transform.position = respawnPoint;
        }
    }
}
