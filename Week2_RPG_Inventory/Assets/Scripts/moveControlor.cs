using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveControlor : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector3 GoSun(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        return new Vector3(x, y);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = GoSun(- 2f, 2f);
        
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        int x = Random.Range(-2, 2);
        int y = Random.Range(-2, 2);
        if (hitInfo.name == "topWall" || hitInfo.name == "bottonWall" || hitInfo.name == "rightWall" || hitInfo.name == "leftWall" || hitInfo.name == "Player")
        {
            Vector2 vel;
            vel.x = x;
            vel.y = y;
            rb2d.velocity = vel;

        }
    }
}
