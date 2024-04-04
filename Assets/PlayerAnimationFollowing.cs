using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationFollowing : MonoBehaviour
{
    public GameObject player;
    public Animator anim;
    Vector3 offset;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        offset = player.transform.position - this.transform.position;
    }
    private void LateUpdate()
    {
        this.transform.position = player.transform.position-offset;
    }
}
