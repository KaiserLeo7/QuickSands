using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;
using System;

public class CharAnimation : MonoBehaviour {


    public Animator anim;

    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();
      
    }
    
    public void AttackAnim() {
        
        anim.SetTrigger("Attack");
    }

    public void HealAnim() {

        anim.SetTrigger("Skill");
    }

    public void RunningAnim() {

        anim.SetBool("Running", true);
    }
    
    public void IdleAnim() {
        
        anim.SetBool("Running", false);
    }













    /// /// /// /// /// /// /// /// ANIMATIONS /// /// /// /// /// /// /// ///


    //animation states
    //public SkeletonAnimation skeletonAnimation;
    //public AnimationReferenceAsset idle, walking, attack;
    //public string currentState;
    //public string currentAnimation;




    ////sets character animation
    //public void SetAnimation(AnimationReferenceAsset animation, bool loop, float timeScale)
    //{
    //    if (animation.name.Equals(currentAnimation))
    //    {
    //        return;
    //    }
    //    skeletonAnimation.state.SetAnimation(0, animation, loop).TimeScale = timeScale;
    //    currentAnimation = animation.name;
    //}


    ////checks character state and sets the animation accordingly
    //public void SetCharacterState(string state)
    //{

    //    if (state.Equals("Idle"))
    //    {
    //        SetAnimation(idle, true, 1f);
    //    }
    //    else if (state.Equals("Walking"))
    //    {

    //        SetAnimation(walking, true, 1f);
    //    }
    //    else if (state.Equals("Attack"))
    //    {

    //        SetAnimation(attack, false, 1f);
    //    }
    //}

    //public void Move()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SetCharacterState("Attack");
    //    }

    //    //else
    //    //{
    //    //    SetCharacterState("Idle");
    //    //}
    //}

}
