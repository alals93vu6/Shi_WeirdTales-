﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdeoState : IState
{
    public void OnEnterState(object action)
    {
        //Debug.Log("IsIdeo");
        PlayerAnimatorManager.instance.PlayIdeo();
    }

    public void OnStayState(object action)
    {
        var actor = (PlayerActor) action;
        //actor.PlayerMove();
        actor.OnPlayerJump();
        actor.PlayerJumpWhether();
        actor.OnPlayerSquatDetect();

        if (Mathf.Abs(Input.GetAxis("HorizontalA")) >= 0.55f)
        {
            actor.ChangeState(new MoveState());
        }
    }

    public void OnExitState(object action)
    {
        PlayerAnimatorManager.instance.ExitIdeo();
    }
}
