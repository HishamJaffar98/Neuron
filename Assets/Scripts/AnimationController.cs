using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator cameraAnimator;
    [SerializeField] Animator labelSet1Animator;
    [SerializeField] Animator labelSet2Animator;
    [SerializeField] Animator labelSet3Animator;
    bool walkthroughStarted;
    void Start()
    {
        walkthroughStarted = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartWalkthrough()
    {
        if(!walkthroughStarted)
        {
            cameraAnimator.SetBool("WalkthroughStart", true);
            walkthroughStarted = true;
        }
        else
        {
            cameraAnimator.SetBool("WalkthroughStart", true);
            cameraAnimator.Play("Walkthrough", -1,0f);
            labelSet1Animator.SetBool("FadeIn", false);
            labelSet2Animator.SetBool("FadeIn",false);
            labelSet3Animator.SetBool("FadeIn",false);
        }
        
    }

    public void FadeInLabelSet1()
    {
        labelSet1Animator.SetBool("FadeIn", true);
    }

    public void FadeOutLabelSet1()
    {
        labelSet1Animator.SetBool("FadeIn", false);
    }

    public void FadeInLabelSet2()
    {
        labelSet2Animator.SetBool("FadeIn", true);
    }

    public void FadeOutLabelSet2()
    {
        labelSet2Animator.SetBool("FadeIn", false);
    }

    public void FadeInLabelSet3()
    {
        labelSet3Animator.SetBool("FadeIn", true);
    }

    public void FadeOutLabelSet3()
    {
        labelSet3Animator.SetBool("FadeIn", false);
    }

    public void StopWalkthrough()
    {
        cameraAnimator.SetBool("WalkthroughStart", false);
        labelSet1Animator.SetBool("FadeIn", false);
        labelSet2Animator.SetBool("FadeIn", false);
        labelSet3Animator.SetBool("FadeIn", false);
    }
}
