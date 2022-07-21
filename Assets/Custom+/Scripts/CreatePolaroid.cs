using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePolaroid : MonoBehaviour
{
    private ChangeMaterial materialChanger;
    private GameObject newPolaroid;
    private Camera myCamera;
    public Material materialTemplate;
    public Transform spawnPosition;
    public GameObject polaroidPrefab;
    public float speed = 5f;
    
    void Start()
    {
        myCamera = transform.GetChild(1).GetComponentInChildren<Camera>();
    }
    public void SpawnPolaroid()
    {
        newPolaroid = Instantiate(polaroidPrefab, spawnPosition.position, spawnPosition.rotation);
        materialChanger = newPolaroid.transform.GetComponentInChildren<ChangeMaterial>();
        RenderCameraOntoMaterial();
        MoveForward();
    }
    private void MoveForward()
    {
        newPolaroid.transform.GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    private void RenderCameraOntoMaterial()
    {
        //Local Screenshot Function
        Texture2D RTImage(Camera camera)
        {
            // The Render Texture in RenderTexture.active is the one
            // that will be read by ReadPixels.
            var currentRT = RenderTexture.active;
            RenderTexture.active = camera.targetTexture;

            // Render the camera's view.
            camera.Render();

            // Make a new texture and read the active Render Texture into it.
            Texture2D image = new Texture2D(camera.targetTexture.width, camera.targetTexture.height);
            image.ReadPixels(new Rect(0, 0, camera.targetTexture.width, camera.targetTexture.height), 0, 0);
            image.Apply();

            // Replace the original active Render Texture.
            RenderTexture.active = currentRT;
            return image;
        }
        Material newMaterial = new Material(materialTemplate);
        materialChanger.otherMaterial = newMaterial;
        materialChanger.otherMaterial.SetTexture("_BaseMap", RTImage(myCamera));
        materialChanger.SetOtherMaterial();
    }

}
