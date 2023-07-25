using System;
using UnityEngine;

namespace Enemy_Scripts
{
    public class EnemyFSM : MonoBehaviour
    {
        public enum EnemyState
        {
            GoToBase,
            AttackBase,
            ChasePlayer,
            AttackPlayer
        }

        public EnemyState currentState;

        public Sight sightSensor;

        public Transform baseTransform;

        public float baseAttackDistance;
        public float playerAttackDistance;


        private void Awake()
        {
            baseTransform = GameObject.Find("Base").transform;
        }

        // Update is called once per frame
        void Update()
        {
            if (currentState == EnemyState.GoToBase)
            {
                GoToBase();
            }
            else if (currentState == EnemyState.AttackBase)
            {
                AttackBase();
            }
            else if (currentState == EnemyState.ChasePlayer)
            {
                ChasePlayer();
            }
            else
            {
                AttackPlayer();
            }
        }

        private void AttackPlayer()
        {
            if (sightSensor.detectedObject == null)
            {
                currentState = EnemyState.GoToBase;
                return;
            }

            float distanceToPlayer = Vector3.Distance(transform.position,
                sightSensor.detectedObject.transform.position);

            if (distanceToPlayer > playerAttackDistance * 1.1f)
            {
                currentState = EnemyState.ChasePlayer;
            }
        }

        private void ChasePlayer()
        {
            if (sightSensor.detectedObject == null)
            {
                currentState = EnemyState.GoToBase;
                return;
            }

            float distanceToPlayer = Vector3.Distance(transform.position,
                sightSensor.detectedObject.transform.position);

            if (distanceToPlayer <= playerAttackDistance)
            {
                currentState = EnemyState.AttackPlayer;
            }
        }

        private void AttackBase()
        {
            print("AttackBase");
        }

        private void GoToBase()
        {
            if (sightSensor.detectedObject != null)
            {
                currentState = EnemyState.ChasePlayer;
            }

            float distanceToBase = Vector3.Distance(
                transform.position, baseTransform.position);

            if (distanceToBase < baseAttackDistance)
            {
                currentState = EnemyState.AttackBase;
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, playerAttackDistance);
            
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, baseAttackDistance);
        }
    }
}