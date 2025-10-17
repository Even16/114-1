using UnityEngine;
using UnityEngine.AI;

public class NPCrun : MonoBehaviour
{
    private NavMeshAgent 導航;
    private Animator 動畫器;
    public Transform 目標;
    private float 距離 = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        導航 = GetComponent<NavMeshAgent>();
        動畫器 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (目標!= null)
        {
            導航.SetDestination(目標.position);
            距離 = Vector3.Distance(目標.position, this.transform.position );
            if (距離 <= 1.0f) { 動畫器.SetBool("isWalk", false); }
            else { 動畫器.SetBool("isWalk", true); }

        }
    }
}
