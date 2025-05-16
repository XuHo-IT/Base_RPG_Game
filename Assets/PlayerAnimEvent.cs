using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimEvent : MonoBehaviour
{
    private MainPlayer player;
    void Start()
    {
        player = GetComponentInParent<MainPlayer>();
    }

    private void AnimationTrigger()
    {
        player.AttackOver();
    }
}
