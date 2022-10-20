using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{
   private NavMeshAgent _agent;
   public Transform playerLoc;

   private void Start()
   {
      _agent = GetComponent<NavMeshAgent>();
   }

   private void Update()
   {
      _agent.destination = playerLoc.position;
   }
}
