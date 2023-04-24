using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetKinematic : MonoBehaviour
{
    public List<Rigidbody> rbs = new();

    private void OnEnable()
    {
        rbs.AddRange(FindObjectsOfType<Rigidbody>());
        StartExplosion();
    }

    public void StartExplosion()
    {
        foreach (Rigidbody rb in rbs)
        {
            rb.isKinematic = false;
        }
    }
}
