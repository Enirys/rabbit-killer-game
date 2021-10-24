using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    private Animator eyeAnim;

    // Start is called before the first frame update
    void Start()
    {
        eyeAnim = GetComponent<Animator>();
    }

    public void AlbinosEyes()
    {
        eyeAnim.SetTrigger("Red");
    }
    
}
