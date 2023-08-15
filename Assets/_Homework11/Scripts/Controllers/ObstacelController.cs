using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacelController : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        ChangeTriggerAnimation();
    }

    public void ChangeTriggerAnimation()
    {
        int randomInt = Random.Range(1, 3 + 1);
        Debug.Log("Change");
        Debug.Log(randomInt);
        _animator.SetInteger("AnimationType", randomInt);
    }
}
