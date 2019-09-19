using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public float speed = 1000;
    public float delay = 1f;

    public int poolSize = 20;


    public List<Rigidbody2D> cannonBallPool = new List<Rigidbody2D>();

    void Start()
    {
        InitObjectPool();
        StartCoroutine(ShootCannon());

    }

    void InitObjectPool()
    {
        for(int i = 0; i < poolSize; i++)
        {
            GameObject cannonBall = Instantiate(cannonBallPrefab);
            cannonBall.SetActive(false);

            Rigidbody2D rb = cannonBall.GetComponent<Rigidbody2D>();
            cannonBallPool.Add(rb);
        }


    }



    IEnumerator ShootCannon()
    {
        while (true)
        {
            GameObject cannonBall = Instantiate(cannonBallPrefab);
            cannonBall.transform.position = transform.position;
            Rigidbody2D rb = cannonBall.GetComponent<Rigidbody2D>();

            rb.AddForce(Vector2.right * speed);

            yield return new WaitForSeconds(delay);
        }
     
    }

}
