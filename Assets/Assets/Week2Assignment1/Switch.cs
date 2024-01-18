using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with Switch");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision with Switch");
        spriteRenderer.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.green;
        
    }

}

