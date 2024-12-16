using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public Action death;
    public int health = 1;
    [SerializeField] private Rigidbody2D rigidbody2DReference; 
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Vector2 boxSize = new Vector2(1, 0.25f);

    private Vector3 jumpVector;
    private bool alive = true;

    private bool IsGrounded(){
        if(Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, 0, groundLayer))
        {
            return true;
        }
        return false;
    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireCube(transform.position - transform.up * 0, boxSize);    
    }


    private void OnJump() {
        Debug.Log("jumpo");
        if(IsGrounded()){
            jumpVector = Vector3.up;
        }
    }

    private void FixedUpdate() {
        if(Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        rigidbody2DReference.AddForce(jumpVector * jumpForce);

        jumpVector = Vector3.zero;
        if(health <= 0){
            Debug.Log("dead");
        }

        if(health <= 0 && alive){
            alive = false;
            death?.Invoke();
        }
    }
}