using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using System;
using UnityEngine.Assertions;

public class MovePlayer : MonoBehaviour {

    public MoveToTarget player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnEnable()
    {
        // subscribe to gesture's Tapped event
        GetComponent<FlickGesture>().Flicked += flickHandler;
    }

    private void OnDisable()
    {
        // don't forget to unsubscribe
        GetComponent<FlickGesture>().Flicked -= flickHandler;
    }

    private void flickHandler(object sender, EventArgs e)
    {
        Assert.IsNotNull(player, "Player is null cannot handle flick");

        var gesture = sender as FlickGesture;

        Vector2 flickDirection = (gesture.ScreenPosition - gesture.PreviousScreenPosition);

        //Get angle of flick direction (0,pi) U (-pi, 0)
        float angle = Mathf.Atan2(flickDirection.y, flickDirection.x);

        //player.ChangeTarget(getNewTarget(angle));

        Debug.Log(angle);

    }

    private Transform getNewTarget(float angle)
    {
        return null;
    }
}
