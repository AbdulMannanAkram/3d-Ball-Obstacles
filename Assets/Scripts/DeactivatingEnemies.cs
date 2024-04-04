using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatingEnemies : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Game Object : "+collision.gameObject);
//        collision.gameObject.SetActive(false);
           Destroy(collision.gameObject);
    }
}
