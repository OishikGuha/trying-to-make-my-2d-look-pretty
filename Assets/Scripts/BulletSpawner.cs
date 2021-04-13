using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public GameObject bullet;

    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, new Vector2(mousePos.x, 3f), Quaternion.identity);
        }
    }
}
