using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{

    public float spinSpeed = 1000.0f;
    public PlayerControllerX forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime * forwardInput.forwardInput);
    }
}
