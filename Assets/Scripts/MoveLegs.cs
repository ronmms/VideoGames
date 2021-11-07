using UnityEngine;

public class MoveLegs : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float LimbRotationSpeed = 3.0f;

    [SerializeField]
    private GameObject LeftLeg;


    
    private void Start()
    {

        if (LeftLeg == null)
        {
            Debug.LogErrorFormat("Missing 'Head' GameObject!");
        }
    }

        void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            moveUpLeg(LeftLeg);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDownLeg(LeftLeg);
        }


    }

    private void moveUpLeg(GameObject leg)
    {
        Quaternion legRot = leg.transform.localRotation;
        Vector3 limbRotEuler = legRot.eulerAngles;
        if (!Mathf.Approximately(limbRotEuler.x, 45.0f))
        {
            float deltaAngle = 45.0f - limbRotEuler.x;

           Vector3 localRotationAxis = leg.transform.InverseTransformVector(Vector3.right);

            leg.transform.Rotate(localRotationAxis, deltaAngle * LimbRotationSpeed * Time.deltaTime);
        }

      
    }

    private void moveDownLeg(GameObject leg)
    {
        Quaternion legRot = leg.transform.localRotation;
        Vector3 limbRotEuler = legRot.eulerAngles;
        if (!Mathf.Approximately(limbRotEuler.x, 0))
        {
            float deltaAngle = 0 -limbRotEuler.x;
            Vector3 localRotationAxis = leg.transform.InverseTransformVector(Vector3.right);
            leg.transform.Rotate(localRotationAxis, deltaAngle * LimbRotationSpeed * Time.deltaTime);

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        Debug.Log("test");


    }
}
