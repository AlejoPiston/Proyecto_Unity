using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    void Update()
    {
        StartCoroutine(WaitList());
    }

    IEnumerator WaitList()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            yield return new WaitForSeconds(Random.Range(1f, 5f));
            StartCoroutine(Spawn(i));
        }
    }

    IEnumerator Spawn(int id)
    {
        yield return new WaitForSeconds(Random.Range(1f, 5f));
        GameObject balloon = transform.GetChild(id).gameObject;
        if (!balloon.activeSelf)
            balloon.SetActive(true);
    }
}
