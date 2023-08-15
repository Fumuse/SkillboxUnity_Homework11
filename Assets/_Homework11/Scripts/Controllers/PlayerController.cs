using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Animator _playerAnimator;
    private Rigidbody _playerRB;
    private int _activeScene = 0;
    private int _nextScene = 0;

    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
        _playerRB = GetComponent<Rigidbody>();
        _activeScene = SceneManager.GetActiveScene().buildIndex;
        _nextScene = _activeScene + 1;
    }

    private void Update()
    {
        _playerAnimator.SetFloat("Velocity", _playerRB.velocity.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            if (_nextScene < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(_nextScene);
            }
        }
    }
}
