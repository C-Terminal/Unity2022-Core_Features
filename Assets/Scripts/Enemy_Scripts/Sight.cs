using UnityEngine;

namespace Enemy_Scripts
{
    public class Sight : MonoBehaviour
    {
        public float distance, angle;

        public LayerMask objectsLayers, obstaclesLayers;
    
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Collider[] colliders = Physics.OverlapSphere(
                transform.position, distance, objectsLayers);

            for (int i = 0; i < colliders.Length; i++)
            {
                Collider collider = colliders[i];
            }
        }
    }
}
