using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UiFillScript : MonoBehaviour
{
    public Transform Player;
    public Transform End;

    public Slider slider;
    float maxDistance;
    void Start()
    {
        maxDistance = getDistance();

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.y <= maxDistance && Player.position.y <= End.position.y)
        {
            float distance = 1 - (getDistance() / maxDistance);
            setProgress(distance);
        }
    }
    float getDistance()
    {
        return Vector3.Distance(Player.position, End.position);
    }
    void setProgress(float p)
    {
        slider.value = p;
    }
}
