using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TTT : MonoBehaviour
{
    Boolean Check;
    int Inc;
    public Text Btn1 = null;
    public Text Btn2 = null;
    public Text Btn3 = null;
    public Text Btn4 = null;
    public Text Btn5 = null;
    public Text Btn6 = null;
    public Text Btn7 = null;
    public Text Btn8 = null;
    public Text Btn9 = null;
    public Text Newgame = null;
    public Text Reset = null;
    public Text MsgFeedback = null;
    public Text CountO;
    public Text CountX;

    public void score()
    {
        //===========O===========//
        if (Btn1.text == "O" && Btn2.text == "O" && Btn3.text == "O")
        {
            Btn1.color = Color.blue;
            Btn2.color = Color.blue;
            Btn3.color = Color.blue;   
            Reset_click();
            Inc = int.Parse(CountX.text);
            CountO.text = Convert.ToString(Inc + 1);
            MsgFeedback.text = "The Winner Is O";
        }
        if (Btn1.text == "O" && Btn4.text == "O" && Btn7.text == "O")
        {
            Btn1.color = Color.red;
            Btn4.color = Color.red;
            Btn7.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is O";
            Inc = int.Parse(CountO.text);
            CountO.text = Convert.ToString(Inc + 1);
        }
        if (Btn4.text == "O" && Btn5.text == "O" && Btn6.text == "O")
        {
            Btn4.color = Color.red;
            Btn5.color = Color.red;
            Btn6.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is O";
            Inc = int.Parse(CountO.text);
            CountO.text = Convert.ToString(Inc + 1);
        }
        if (Btn7.text == "O" && Btn8.text == "O" && Btn9.text == "O")
        {
            Btn7.color = Color.red;
            Btn8.color = Color.red;
            Btn9.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is O";
            Inc = int.Parse(CountO.text);
            CountO.text = Convert.ToString(Inc + 1);
        }
        if (Btn2.text == "O" && Btn5.text == "O" && Btn8.text == "O")
        {
            Btn2.color = Color.red;
            Btn5.color = Color.red;
            Btn8.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is O";
            Inc = int.Parse(CountO.text);
            CountO.text = Convert.ToString(Inc + 1);
        }
        if (Btn3.text == "O" && Btn6.text == "O" && Btn9.text == "O")
        {
            Btn3.color = Color.red;
            Btn6.color = Color.red;
            Btn9.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is O";
            Inc = int.Parse(CountO.text);
            CountO.text = Convert.ToString(Inc + 1);
        }
        if (Btn1.text == "O" && Btn5.text == "O" && Btn9.text == "O")
        {
            Btn1.color = Color.red;
            Btn5.color = Color.red;
            Btn9.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is O";
            Inc = int.Parse(CountO.text);
            CountO.text = Convert.ToString(Inc + 1);
        }
        if (Btn3.text == "O" && Btn5.text == "O" && Btn7.text == "O ")
        {
            Btn3.color = Color.red;
            Btn5.color = Color.red;
            Btn7.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is O";
            Inc = int.Parse(CountO.text);
            CountO.text = Convert.ToString(Inc + 1);
        }
        //x
        if (Btn1.text == "X" && Btn2.text == "X" && Btn3.text == "X")
        {
            Btn1.color = Color.blue;
            Btn2.color = Color.blue;
            Btn3.color = Color.blue;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
        if (Btn1.text == "X" && Btn4.text == "X" && Btn7.text == "X")
        {
            Btn1.color = Color.red;
            Btn4.color = Color.red;
            Btn7.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
        if (Btn4.text == "X" && Btn5.text == "X" && Btn6.text == "X")
        {
            Btn4.color = Color.red;
            Btn5.color = Color.red;
            Btn6.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
        if (Btn7.text == "X" && Btn8.text == "X" && Btn9.text == "X")
        {
            Btn7.color = Color.red;
            Btn8.color = Color.red;
            Btn9.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
        if (Btn2.text == "X" && Btn5.text == "X" && Btn8.text == "X")
        {
            Btn2.color = Color.red;
            Btn5.color = Color.red;
            Btn8.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
        if (Btn3.text == "X" && Btn6.text == "X" && Btn9.text == "X")
        {
            Btn3.color = Color.red;
            Btn6.color = Color.red;
            Btn9.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
        if (Btn1.text == "X" && Btn5.text == "X" && Btn9.text == "X")
        {
            Btn1.color = Color.red;
            Btn5.color = Color.red;
            Btn9.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
        if (Btn3.text == "X" && Btn5.text == "X" && Btn7.text == "X")
        {
            Btn3.color = Color.red;
            Btn5.color = Color.red;
            Btn7.color = Color.red;
            Reset_click();
            MsgFeedback.text = "The Winner Is X";
            Inc = int.Parse(CountX.text);
            CountX.text = Convert.ToString(Inc + 1);
        }
    

}



public void Btn1_click()
    {
        if (Check == false)
        {
            Btn1.text = "X";
                Check = true;
        }
        else
        {
            Btn1.text = "O";
            Check = false;
            
        }
        score();
    }
    public void Btn2_click()
    {
        if (Check == false)
        {
            Btn2.text = "X";
            Check = true;
        }
        else
        {
            Btn2.text = "O";
            Check = false;

        }
        score();
    }

    public void Btn3_click()
    {
        if (Check == false)
        {
            Btn3.text = "X";
            Check = true;
        }
        else
        {
            Btn3.text = "O";
            Check = false;

        }
        score();
    }
    public void Btn4_click()
    {
        if (Check == false)
        {
            Btn4.text = "X";
            Check = true;
        }
        else
        {
            Btn4.text = "O";
            Check = false;

        }
        score();
    }
    public void Btn5_click()
    {
        if (Check == false)
        {
            Btn5.text = "X";
            Check = true;
        }
        else
        {
            Btn5.text = "O";
            Check = false;

        }
        score();
    }
    public void Btn6_click()
    {
        if (Check == false)
        {
            Btn6.text = "X";
            Check = true;
        }
        else
        {
            Btn6.text = "O";
            Check = false;

        }
        score();
    }
    public void Btn7_click()
    {
        if (Check == false)
        {
            Btn7.text = "X";
            Check = true;
        }
        else
        {
            Btn7.text = "O";
            Check = false;

        }
        score();
    }
    public void Btn8_click()
    {
        if (Check == false)
        {
            Btn8.text = "X";
            Check = true;
        }
        else
        {
            Btn8.text = "O";
            Check = false;

        }
        score();
    }

    public void Btn9_click()
    {
        if (Check == false)
        {  
            Btn9.text = "X";
            Check = true;
        }
        else
        {
            Btn9.text = "O";
            Check = false;

        }
        score();
    }


    //Reset and New Game
    public void Newgame_click()
    {
        Reset_click();
        CountO.text = "0";
        CountX.text = "0";
    }
    public void Reset_click()
    {
        Btn1.text = "";
        Btn2.text = "";
        Btn3.text = "";
        Btn4.text = "";
        Btn5.text = "";
        Btn6.text = "";
        Btn7.text = "";
        Btn8.text = "";
        Btn9.text = "";
        Btn1.color = Color.black;
        Btn2.color = Color.black;
        Btn3.color = Color.black;
        Btn4.color = Color.black;
        Btn5.color = Color.black;
        Btn6.color = Color.black;
        Btn7.color = Color.black;
        Btn8.color = Color.black;
        Btn9.color = Color.black;
        MsgFeedback.text = "";
    }
}
