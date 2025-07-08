using System;
using UnityEngine;
using UnityEngine.UI;
public class MathFSamples : MonoBehaviour
{
    public Slider lerpSlider;
    public Slider pingPongSlider;
    public Slider moveTowardsSlider;

    public float lerpT = 0;
    public float pingPongSpeed, moveTowardsSpeed;
    public GameObject upDown;


    // Update is called once per frame
    void Update()
    {
        LerpSamples();
        PingPongSamples();
        MoveTowardsSamples();
        SinSamples();
    }

    public void AbsSamples()
    {
        //returns positive value
        float absVal = Mathf.Abs(-25);
    }

    public void RepeatSample()
    {
        float repeatedValue = Mathf.Repeat(Time.time, 5);
        Debug.Log("repeated value: " + repeatedValue);
    }

    public void RoundSamples()
    {
        Mathf.Round(123.35f);

    }

    public void MoveTowardsSamples()
    {
        moveTowardsSlider.value = Mathf.MoveTowards(moveTowardsSlider.value, moveTowardsSlider.maxValue, moveTowardsSpeed * Time.deltaTime);
    }

    public void PingPongSamples()
    {
        pingPongSlider.value = Mathf.PingPong(Time.time * pingPongSpeed, pingPongSlider.maxValue);
    }
    public void LerpSamples()
    {
        //lerp mathf implementation
        //linear interpolation
        //It's a way to smoothly move or transition between two values
        // float startValue = 0;
        // float endValue = 10f;

        // float value = Mathf.Lerp(startValue, endValue, lerpT);    //t = 0.25
        // Debug.Log(value);
        lerpT += Time.deltaTime * 0.1f;
        lerpSlider.value = Mathf.Lerp(0, 100, Mathf.Clamp01(lerpT));
        //clamp (min, max, what variable should we clamp)
        //Mathf.Clamp01 clamps it to min 0 and max value is 1
    }

    public void SinSamples()
    {
        float amplitude = 0.5f;
        float frequency = 2f;
        Vector3 startPos;
        startPos = upDown.transform.position;

        float verticalMovement = Mathf.Sin(Time.time * frequency) * amplitude;
        upDown.transform.position = startPos + new Vector3(0, verticalMovement, 0);
    }
}
