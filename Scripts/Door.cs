using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject player;
    public GameObject door;

    public Animator doorrot;
    public bool isopen = false;
    void Start()
    {
        doorrot = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.transform.position - door.transform.position);
        if (player.transform.position.z - door.transform.position.z > -4f && player.transform.position.z - door.transform.position.z<-2f&& Input.GetKeyDown(KeyCode.E))
        {
            if (!isopen)
            {
                doorrot.Play("door_open_front");
                isopen = true;
            }
            else
            {
                doorrot.Play("door_close");
                isopen = false;
            }
        }
         if (player.transform.position.z - door.transform.position.z < 4f && player.transform.position.z - door.transform.position.z>2f&& Input.GetKeyDown(KeyCode.E))
        {
            if (!isopen)
            {
                doorrot.Play("door_open_front");
                isopen = true;
            }
            else
            {
              doorrot.Play("door_close");
                isopen = false;
            }
        }
    }
}
