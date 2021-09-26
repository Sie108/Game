using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBehavior : MonoBehaviour
{
    public float holdTime = 2f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        Destroy(gameObject);
    }

}