using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo; // geralmente o jogador
    public float suavidade = 0.125f;
    public Vector3 offset; // ajuste da posição da câmera

    void LateUpdate()
    {
        if (alvo == null) return;

        Vector3 posDesejada = alvo.position + offset;
        Vector3 posSuave = Vector3.Lerp(transform.position, posDesejada, suavidade);
        transform.position = new Vector3(posSuave.x, posSuave.y, transform.position.z); // trava o Z
    }
}
