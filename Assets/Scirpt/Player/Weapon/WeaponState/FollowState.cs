﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowState : IState
{
    public void OnEnterState(object action)
    {
        var actor = (ShiActor) action;
        actor.LogState = 1;
        Debug.Log("IsFollow");
    }

    public void OnStayState(object action)
    {
        var actor = (ShiActor) action;
        actor.ShiFollowMove();
        actor.ShiFollowPosMax();
        actor.ShiRotation();
        //Debug.Log("VARC");

        /*
        if (Input.GetAxis("SummonKey") >= 0.85f || Input.GetMouseButtonDown(1) && actor.SummonCD == false)
        {
            actor.SummonsShi();
            actor.ChangeState(new SummonState());
            actor.OnSummonCD();
        }
        */
    }

    public void OnExitState(object action)
    {
        
    }
    
}
