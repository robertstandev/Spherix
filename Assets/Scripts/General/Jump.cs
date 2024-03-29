﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]private float jumpPower = 10f;
    [SerializeField]private int maxJumps = 2;
    private int jumpCounter = 0;
    private Vector3 jumpVector3 = new Vector3(0f, 100f, 0f);

    public void jump(Rigidbody rb, Stamina staminaComponent, int staminaToConsume)
    {
        if((this.jumpCounter < this.maxJumps) && (staminaComponent.getCurrentStamina() >= staminaToConsume))
        {
            staminaComponent.substractStamina(staminaToConsume);
            this.jumpCounter += 1;
            rb.AddForce(this.jumpVector3 * this.jumpPower);
        }
    }

    public void setJumpCounter(int value) { this.jumpCounter = value < this.maxJumps ? value : this.jumpCounter; }

    public int getJumpCounter() { return this.jumpCounter; }

    public void setJumpPower(float value) { this.jumpPower = value; }

    public float getJumpPower() { return this.jumpPower; }
}