using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageController : MonoBehaviour
{
    public int pages;
    public Enemy enemy;
    public AudioSource source;
    public AudioClip clip;
    public FirstPersonMovement player;
    private void OnTriggerEnter(Collider other)
    {
        print("you found it");
        Destroy(other.gameObject);
        pages++;

        if(pages == 1)
        {
            enemy.target = transform;
        }
        if (pages == 2)
        {
            enemy.speed *= 2;
        }
        if (pages == 3)
        {
            enemy.viewDistance *= 1.5f;
        }
        if (pages == 4)
        {
            InvokeRepeating("Sounds", 1f, Random.Range(1f, 5f));
            source.clip = clip;
            source.Play();
        }
        if (pages == 5)
        {
            player.runSpeed = 7;
            player.speed = 4;
        }

    }

    public void Sounds()
    {
        source.clip = clip;
        source.Play();
    }
}
