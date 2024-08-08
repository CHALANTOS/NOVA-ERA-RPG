using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public int vertical = 0;
    public int horizontal = 0;

    public void Esquerda()
    {
        horizontal = -1;
    }

    public void Direita()
    {
        horizontal = 1;
    }

    public void Cima()
    {
        vertical = 1;
    }

    public void Baixo()
    {
        vertical = -1;
    }

    public void parar()
    {
        vertical = horizontal = 0;
    }
}
