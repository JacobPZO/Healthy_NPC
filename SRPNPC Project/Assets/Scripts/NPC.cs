using System;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float turnSpeed = 90f;



    private void Start()
    {

    }

    internal void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }

    private void OnTriggerEnter(Collider collider)
    {
        TakeDamage(10);
    }

    private void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
    }

}