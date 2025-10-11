using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheckScore : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        GamePlayController.Instance.scoreController.AddScore();
    }
}
