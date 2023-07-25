using System;
using UnityEngine;

namespace Enemy_Scripts
{
    public class Sight : MonoBehaviour
    {
        public float distance, angle;
        public LayerMask objectsLayers, obstaclesLayers;
        public Collider detectedObject;
        
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            Collider[] colliders = Physics.OverlapSphere(
                transform.position, distance, objectsLayers);

            detectedObject = null;
            for (int i = 0; i < colliders.Length; i++)
            {
                Collider collider = colliders[i];
                
                // Start calculating the direction toward the object, which can be done by normalizing the 
                // difference between the object’s position and ours
                // used bounds.center instead of transform.position; this way, we check the direction
                // to the center of the object instead of its pivot. Remember that the player’s pivot is in the 
                // ground and the ray check might collide against it before the player
                Vector3 directionToController = Vector3.Normalize(
                    collider.bounds.center - transform.position);

                // use the Vector3.Angle function to calculate the angle between two directions.
                // In our case, we can calculate the angle between the direction toward the enemy and our
                // forward vector to see the angle:
                float angleToCollider = Vector3.Angle(
                    transform.forward, directionToController);

                if (angleToCollider < angle)
                {
                    if (!Physics.Linecast(transform.position,
                            collider.bounds.center, 
                            out RaycastHit hit, obstaclesLayers))
                    {
                        Debug.DrawLine(transform.position,
                            collider.bounds.center, Color.green);
                        detectedObject = collider;
                        break;
                    }
                    else
                    {
                        Debug.DrawLine(transform.position, hit.point, Color.red);
                    }
                }
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, distance);
            
            Vector3 rightDirection = Quaternion.Euler(0, angle, 0) * transform.forward;
            Gizmos.DrawRay(transform.position, rightDirection * distance);
            Vector3 leftDirection = Quaternion.Euler(0, -angle, 0) * transform.forward;
            Gizmos.DrawRay(transform.position, leftDirection * distance);
            
        }
    }
}