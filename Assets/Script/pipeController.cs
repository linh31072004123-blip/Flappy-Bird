using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public Transform pipeSpawnPoint;
    public List<GameObject> lsPipe;

    void Start()
    {
        //Instantiate(pipe, transform.position, Quaternion.identity);
        // SimplePool2.Preload(pipe, 10);

        
    }
    public void Init()
    {
        Invoke(nameof(HandleSpawnPipe), 1.5f);

    }
    

    // Update is called once per frame

    public void HandleSpawnPipe()
    {
        var temp = SimplePool2.Spawn(pipe, new Vector3(pipeSpawnPoint.position.x, pipeSpawnPoint.position.y + Random.Range(-1.5f, 1.5f), 0), Quaternion.identity);
        lsPipe.Add(temp);
        Invoke(nameof(HandleSpawnPipe), 1.0f);


    }
    public void Stop()
    {
        CancelInvoke();
        foreach (var item in lsPipe)
        {
            if (item != null)
            {
                SimplePool2.Despawn(item);
            }
        }
    }
}
