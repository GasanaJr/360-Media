using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public GameObject target;
    public GameObject current;

    public Animator animator;

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
        animator.SetTrigger("Start");
        Debug.Log("Animator triggered");
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
