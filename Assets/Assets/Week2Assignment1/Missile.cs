using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 8);
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody2D>().position + direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Missile collision");
        Destroy(gameObject);
    }
}

