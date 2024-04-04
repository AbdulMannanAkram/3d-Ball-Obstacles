using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rb_enemy;
    public float speed=100f;
    private void Awake()
    {
        rb_enemy = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (this.tag == "Sphere")
//            if (this.CompareTag = "Sphere")
        {
            this.transform.Rotate(new Vector3(30, 45, 60)*Time.deltaTime);
        }
        if (this.tag == "PrismRotate")
        {
            this.transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On Collision Enter");
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Plyer Contact on collision " + collision.transform.forward);
            rb_enemy.AddForce(Vector3.forward * speed);
        }
        if (collision.gameObject.name == "Player"&& this.gameObject.tag=="Win")
        {
            Debug.Log("Plyer Contact on collision " + collision.transform.forward);
            rb_enemy.AddForce(Vector3.forward * speed);
        }
    }

}
