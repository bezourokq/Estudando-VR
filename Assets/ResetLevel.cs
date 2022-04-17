using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class ResetLevel : MonoBehaviour
{
    public List<GameObject> Objects = new List<GameObject>();
    public List<GameObject> Cables = new List<GameObject>();
    private List<Vector3> ObjectsPosition = new List<Vector3>();
    private List<Quaternion> ObjectsRotation = new List<Quaternion>();
    private List<Material> ObjectsMaterial = new List<Material>();
    public GameObject particle;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in Objects)
        {
            ObjectsPosition.Add(obj.transform.position);
            ObjectsRotation.Add(obj.transform.rotation);
        }
        foreach (GameObject obj in Cables)
        {
            ObjectsMaterial.Add(obj.GetComponent<MeshRenderer>().material);
        }
        reset();
    }

    public void reset()
    {
        GameObject.Find("Level").GetComponent<LevelController>().resetState();
        int temp = Objects.Count;
        for (int x = 0; x < temp; x++)
        {
            Objects[x].transform.position = ObjectsPosition[x];
            Objects[x].transform.rotation = ObjectsRotation[x];
            try
            {
                Objects[x].GetComponent<Rigidbody>().isKinematic = false;
            }
            catch
            {

            }
            try
            {
                Objects[x].GetComponent<XRGrabInteractable>().enabled = true;
            }
            catch
            {

            }
            try
            {
                Objects[x].GetComponent<BoxCollider>().isTrigger = false;
            }
            catch
            {

            }
        }
        temp = Cables.Count;
        for (int x = 0; x < temp; x++)
        {
            Cables[x].GetComponent<MeshRenderer>().material = ObjectsMaterial[x];
        }

        var em = particle.GetComponent<ParticleSystem>().emission;
        em.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
