using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArrow : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
