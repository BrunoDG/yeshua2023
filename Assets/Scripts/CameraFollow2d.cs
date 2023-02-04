using UnityEngine;

public class CameraFollow2d : MonoBehaviour
{
    public Transform target;
    public static CameraFollow2d Instance;
    public static bool enableCamera = true;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        
    }
    private  void CheckActiveCamera()
    {
        if(enableCamera)
        CamaeraFollow2d();
    }
    private void CamaeraFollow2d()
    {
         
            transform.position = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        CheckActiveCamera();
    }
    
}
