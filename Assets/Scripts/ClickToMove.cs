using UnityEngine;
using UnityEngine.AI;


public class ClickToMove : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    private void OnValidate()
    {
        if (agent == null) agent = GetComponent<NavMeshAgent>();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray mouseToWorldRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseToWorldRay, out RaycastHit hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
    }
}
