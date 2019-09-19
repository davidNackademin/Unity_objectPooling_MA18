using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
