using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class KillZoneLevel2 : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private GameObject deathScreenAnimation, sleigh1, resetSleigh1;
    private Animator animator;
    
    private RunAlongGround RunAlongGround;

    private void Start()
    {
        RunAlongGround = sleigh1.GetComponent<RunAlongGround>();
        animator = deathScreenAnimation.GetComponent<Animator>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = PlayerMovement.spawnPosition.transform.position;
            other.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            player = other.gameObject;
            player.SetActive(false);
            animator.SetTrigger("PlayDeath");
            CameraFollow.cameraLock = true;
            RunAlongGround.activatePlatform = false;
            sleigh1.transform.position = resetSleigh1.transform.position;
            Invoke("DeathWaitTime", 2);
        }
    }

    private void DeathWaitTime()
    {
        player.SetActive(true);
        CameraFollow.cameraLock = false;
    }
}

