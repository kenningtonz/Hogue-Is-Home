using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakw : MonoBehaviour
{
    public Animator camAnim;
    
    public void camshake()
    {
        camAnim.SetTrigger("shake");
    }
}
