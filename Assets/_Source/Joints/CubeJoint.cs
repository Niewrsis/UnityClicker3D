using System.Collections;
using UnityEngine;

namespace Joints
{
    public class CubeJoint : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] private float minTarget, maxTarget;

        private HingeJoint _joint;
        private JointMotor _motor;

        private void Start()
        {
            _joint = GetComponent<HingeJoint>();
            _motor = _joint.motor;
            StartCoroutine(TimeToChangeTarget());
        }

        private IEnumerator TimeToChangeTarget()
        {
            while (true)
            {
                _motor.targetVelocity = minTarget;
                _joint.motor = _motor;
                yield return new WaitForSeconds(2);

                _motor.targetVelocity = maxTarget;
                _joint.motor = _motor;
                yield return new WaitForSeconds(2);
            }
        }
    }
}