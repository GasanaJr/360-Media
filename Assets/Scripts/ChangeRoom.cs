using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ChangeRoom : MonoBehaviour
{
    public GameObject target;
    public GameObject current;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransitionToTarget()
    {
        StartCoroutine(LoadTarget());
    }

    IEnumerator LoadTarget()
    {
        yield return new WaitForSeconds(2f);
        if (current != null && target != null)
        {
            current.SetActive(false);
            target.SetActive(true);
        }
        else
        {
            Debug.LogError("Spheres Error: Current or Target is not assigned");
        }
    }
}
