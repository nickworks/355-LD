using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiles
{
    public class DelayedEnterance : MonoBehaviour
    {

        public float delayTimer;
        public Vector3 startingOffset;
        Rigidbody body;
        bool iWantToMove = false;
        bool canIMove = false;
        Vector3 startingPosition;
        public enum Trigger { Plunger, LeftFlipper, RightFlipper, LeftTilt, RightTilt, GameStart, ScoreAmount, MultAmount, BallsLeft };
        public enum GreaterLessOrEqual { GreaterThan, GreaterOrEqual, Equal, LessOrEqual, LessThan};
        public Trigger trigger;
        public GreaterLessOrEqual compareEnum;
        public int numberValue;
        public GameObject gameRef;
        GameValues gameValue;

        // Start is called before the first frame update
        void Start()
        {
            body = GetComponent<Rigidbody>();
            startingPosition = transform.position;
            Vector3 startMove = transform.position + startingOffset;
            transform.position = startMove;
            gameValue = gameRef.GetComponent<GameValues>();
        }

        // Update is called once per frame
        void Update()
        {
            switch (trigger)
            {
                case Trigger.Plunger:
                    if (Input.GetButtonUp("Plunger")) iWantToMove = true;
                    break;
                case Trigger.LeftFlipper:
                    if (Input.GetButtonUp("FlipperLeft")) iWantToMove = true;
                    break;
                case Trigger.RightFlipper:
                    if (Input.GetButtonUp("FlipperRight")) iWantToMove = true;
                    break;
                case Trigger.LeftTilt:
                    if (Input.GetAxis("Tilt") < -500) iWantToMove = true;
                    break;
                case Trigger.RightTilt:
                    if (Input.GetAxis("Tilt") > 500) iWantToMove = true;
                    break;
                case Trigger.GameStart:
                    iWantToMove = true;
                    break;
                case Trigger.ScoreAmount:
                    CompareValueSwitch(gameValue.score);
                    break;
                case Trigger.MultAmount:
                    CompareValueSwitch(gameValue.multiplyer);
                    break;
                case Trigger.BallsLeft:
                    CompareValueSwitch(gameValue.ballsLeft);
                    break;
                default:
                    break;
            }
            if (iWantToMove) delayTimer = delayTimer - Time.deltaTime;
            if (delayTimer <= 0)
            {
                canIMove = true;
                delayTimer = 0;
            }
            if (canIMove) transform.position = Vector3.Lerp(transform.position, startingPosition, .01f);
        }
        void CompareValueSwitch(int compareValue)
        {
            switch (compareEnum)
            {
                case GreaterLessOrEqual.GreaterThan:
                    if (compareValue > numberValue) iWantToMove = true;
                    break;
                case GreaterLessOrEqual.GreaterOrEqual:
                    if (compareValue >= numberValue) iWantToMove = true;
                    break;
                case GreaterLessOrEqual.Equal:
                    if (compareValue == numberValue) iWantToMove = true;
                    break;
                case GreaterLessOrEqual.LessOrEqual:
                    if (compareValue < numberValue) iWantToMove = true;
                    break;
                case GreaterLessOrEqual.LessThan:
                    if (compareValue <= numberValue) iWantToMove = true;
                    break;
                default:
                    break;
            }
        }
    }
}