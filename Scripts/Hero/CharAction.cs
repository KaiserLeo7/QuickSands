using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;
using Spine.Unity.AttachmentTools;
using System;

public class CharAction : MonoBehaviour {

    private CharAnimation charAnim;
    public SkeletonMecanim skeleton;

    private State state;
    private Vector3 slideTargetPosition;

    private Action onSlideComplete;
    private Action onAttackComplete;
    private Action onHealComplete;


    private float attackEndTime;
    private float healEndTime;

    private enum State {
        Idle,
        Sliding,
        BusyAttacking,
        BusyHealing,
    }


    private void Awake() {
        state = State.Idle;

        charAnim = GetComponent<CharAnimation>();
        skeleton = GetComponent<SkeletonMecanim>();
    }

    private void Start() {
    }

    public void Setup(bool isPlayerTeam) {

        if (isPlayerTeam)
        {
            charAnim.IdleAnim();
        }
        else {
            //play idle animation
            charAnim.IdleAnim();

            ////create a new skin class variable
            ////assign a skin to it
            ////add it's other attachments to the set
            //Skin enemySkin = new Skin("enemySkin");
            //Skin shadow = skeleton.skeleton.Data.FindSkin("e5");
            //enemySkin.AddAttachments(shadow);

            ////set the skin to the skeleton model
            ////attach everything
            //skeleton.skeleton.SetSkin(enemySkin);
            //skeleton.skeleton.SetSlotsToSetupPose();
        }
    }

    private void Update() {
        switch (state) {
            case State.Idle:
                break;
            case State.BusyAttacking:
                if (Time.time > attackEndTime) {
                    onAttackComplete();
                }
                break;
            case State.BusyHealing:
                if (Time.time > healEndTime) {
                    onHealComplete();
                }
                break;
            case State.Sliding:
                float slideSpeed = 5f;
                transform.position += (slideTargetPosition - GetPosition()) * slideSpeed * Time.deltaTime;

                float reachedDistance = 1f;
                if (Vector3.Distance(GetPosition(), slideTargetPosition) < reachedDistance) {
                    // Arrived at Slide Target Position
                    transform.position = slideTargetPosition;
                    onSlideComplete();
                }
                break;
        }
    }

    //helper function gets position
    public Vector3 GetPosition() {
        return transform.position;
    }

    public void Attack(CharAction targetCharacter, Action onAttackComplete) {
        
        slideTargetPosition = Vector3.Lerp(GetPosition(), targetCharacter.GetPosition(), 0.8f);
        Vector3 startingPosition = GetPosition();


        //Slide to Target
        SlideToPosition(slideTargetPosition, () => {
            //Arrive at Target, attack him
            state = State.BusyAttacking;
            charAnim.AttackAnim();

            //call a function from BattleSystem to calculate damage
           BattleSystem.instance.CalculateDamage();

            attackEndTime = Time.time + .8f;

            this.onAttackComplete = () => {
                   
                //Attack completed, slide back
                SlideToPosition(startingPosition, () => {
                    state = State.Idle;

                    onAttackComplete();
                });
            };
        });
        
    }

    public void Heal(Action onHealComplete) {
        state = State.BusyHealing;
        //Trigger a healing animation
        charAnim.HealAnim();
       //calculate the healing
       BattleSystem.instance.CalculateHeal();

        healEndTime = Time.time + .5f;

        this.onHealComplete = () => {
            state = State.Idle;

        onHealComplete();
        };
    }

    private void SlideToPosition(Vector3 slideTargetPosition, Action onSlideComplete) {
        this.slideTargetPosition = slideTargetPosition;
        this.onSlideComplete = onSlideComplete;



        ////hey doofus you need to add slide left and slide right animetions then trigger them with this code:
        /// if(slideTargetPosition.x > 0) { charAnim.PlaySlideRight();} else { charAnim.PlaySlideLeft(); }
        ///



        state = State.Sliding;
    }

}
