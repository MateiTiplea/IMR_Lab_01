using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusChangeState : MonoBehaviour
{
    public Transform otherCactus;
    private Animator cactusAnimator;
    // Start is called before the first frame update
    void Start()
    {
        cactusAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (transform.position, otherCactus.position);
        Debug.Log(distance);
        if (distance <= 0.7f)
        {
            cactusAnimator.SetBool("isFighting", true);
        }
        else
        {   
            cactusAnimator.SetBool("isFighting", false);
        }
    }
}
