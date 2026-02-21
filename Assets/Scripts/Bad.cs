using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bad : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Bullet bullet = hitInfo.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.Gone();

            //--Score;
        }

    }
}
