using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 3f;
    public GameObject missilePrefab;
    public Transform spawn;
    public Transform TurretBase;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(direction * speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab, transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            TurretBase.transform.Rotate(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            TurretBase.transform.Rotate(0, 0, -1);
        }
    }
}
