using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsTrigger : MonoBehaviour
{

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player hit: " + collision.name);

        Destroy(collision.gameObject);
        score += 1;

    }



}
