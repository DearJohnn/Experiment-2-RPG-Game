using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunAttack : MonoBehaviour
{
    private PlayerController player;
    public int healthloss;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Player")
        {
            player.health -= healthloss;
        }
        
    }
}
