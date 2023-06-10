using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfSwing : MonoBehaviour
{
    public Transform clubHead;  // Reference to the club head transform
    public AnimationCurve swingCurve;  // Animation curve for the swing motion
    public float swingDuration = 1f;  // Duration of the swing animation

    private bool isSwinging = false;  // Flag to track if the swing animation is playing
    private float timer = 0f;  // Timer for the animation

    void Update()
    {
        // Check for input to initiate the swing
        if (Input.GetKeyDown(KeyCode.Space) && !isSwinging)
        {
            // Start the swing animation
            isSwinging = true;
            timer = 0f;
        }

        // Update the swing animation
        if (isSwinging && timer <= swingDuration)
        {
            // Calculate the normalized time for the animation
            float normalizedTime = timer / swingDuration;

            // Evaluate the animation curve to get the current swing value
            float swingValue = swingCurve.Evaluate(normalizedTime);

            // Rotate the club head based on the swing value
            clubHead.localRotation = Quaternion.Euler(new Vector3(swingValue * 90f, 0f, 0f));

            // Increment the timer
            timer += Time.deltaTime;
        }
        else if (isSwinging)
        {
            // End the swing animation
            isSwinging = false;
            clubHead.localRotation = Quaternion.identity;  // Reset the club head rotation
        }
    }
}
