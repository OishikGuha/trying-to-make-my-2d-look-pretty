using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public ParticleSystemThing fire;
    public ParticleSystemThing hit;

    AudioSource adsrc;

    // Start is called before the first frame update
    void Start()
    {
        adsrc = GetComponent<AudioSource>();
        Instantiate(fire, transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.01f,0);

        if(transform.position.y < -30f)
        {
            Destroy(gameObject);
        }

        // let it attach to your mouse
        // Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // transform.position = mousePos; 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Block")
        {
            var hitInst = Instantiate(hit, transform);
            hitInst.Play(); 

            Destroy(hitInst,5);

            adsrc.Play();
            CameraScript.Shake();
        }
    }
}
