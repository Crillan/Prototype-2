using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 2.0f;
    private float counter = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && counter <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            counter = cooldown;
        } else {
            counter -= Time.deltaTime;
        }
    }
}