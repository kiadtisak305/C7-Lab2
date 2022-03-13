using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    public void getAnimatorFlair() {
        this.GetComponent<Animator>().Play("Flair");
    }

    public void getAnimatorHiphop()
    {
        this.GetComponent<Animator>().Play("Hip Hop Dancing");
    }
}
