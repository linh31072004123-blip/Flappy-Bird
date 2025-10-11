using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCobtroller : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float forceJump;
    public pipeController pipeController;
    public CircleCollider2D circleCollider2D;
    public void Init()
    {
        rigidbody2D.bodyType = RigidbodyType2D.Dynamic; 
    }
    // Update is called once per frame
    void Update() // chay lien tuc
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            rigidbody2D.AddForce(new Vector2(0, forceJump));

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
        rigidbody2D.gravityScale = 0;
        pipeController.Stop();
        circleCollider2D.isTrigger = true;
        rigidbody2D.velocity = Vector2.zero;
        GamePlayController.Instance.endGamePopUp.gameObject.SetActive(true);
        GamePlayController.Instance.endGamePopUp.ShowScore();
    }
}
