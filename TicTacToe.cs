using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    Boolean checker;
    int plusOne;

    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;

    public Text btnReset = null;
    public Text btnNew = null;
    public Text msgFeedback = null;

    public Text txtX ;
    public Text txtY ;

    public void score()
    {
        // Xác định các ký hiệu của người chơi X và O
        string playerX = "X";
        string playerO = "O";

        // Tạo một mảng 2D chứa tất cả các ô của bảng
        Text[,] board = new Text[,] { { btnText1, btnText2, btnText3 },
                                   { btnText4, btnText5, btnText6 },
                                   { btnText7, btnText8, btnText9 } };

        // Duyệt qua tất cả các hàng, cột và đường chéo để kiểm tra chiến thắng
        for (int i = 0; i < 3; i++)
        {
            // Kiểm tra hàng
            if (board[i, 0].text == board[i, 1].text && board[i, 1].text == board[i, 2].text && !string.IsNullOrEmpty(board[i, 0].text))
            {
                if (board[i, 0].text == playerX)
                {
                    // Người chơi X thắng
                    ShowWinner(board[i, 0], board[i, 1], board[i, 2], "X");
                }
                else if (board[i, 0].text == playerO)
                {
                    // Người chơi O thắng
                    ShowWinner(board[i, 0], board[i, 1], board[i, 2], "O");
                }
            }

            // Kiểm tra cột
            if (board[0, i].text == board[1, i].text && board[1, i].text == board[2, i].text && !string.IsNullOrEmpty(board[0, i].text))
            {
                if (board[0, i].text == playerX)
                {
                    // Người chơi X thắng
                    ShowWinner(board[0, i], board[1, i], board[2, i], "X");
                }
                else if (board[0, i].text == playerO)
                {
                    // Người chơi O thắng
                    ShowWinner(board[0, i], board[1, i], board[2, i], "O");
                }
            }
        }

        // Kiểm tra đường chéo chính
        if (board[0, 0].text == board[1, 1].text && board[1, 1].text == board[2, 2].text && !string.IsNullOrEmpty(board[0, 0].text))
        {
            if (board[0, 0].text == playerX)
            {
                // Người chơi X thắng
                ShowWinner(board[0, 0], board[1, 1], board[2, 2], "X");
            }
            else if (board[0, 0].text == playerO)
            {
                // Người chơi O thắng
                ShowWinner(board[0, 0], board[1, 1], board[2, 2], "O");
            }
        }

        // Kiểm tra đường chéo phụ
        if (board[0, 2].text == board[1, 1].text && board[1, 1].text == board[2, 0].text && !string.IsNullOrEmpty(board[0, 2].text))
        {
            if (board[0, 2].text == playerX)
            {
                // Người chơi X thắng
                ShowWinner(board[0, 2], board[1, 1], board[2, 0], "X");
            }
            else if (board[0, 2].text == playerO)
            {
                // Người chơi O thắng
                ShowWinner(board[0, 2], board[1, 1], board[2, 0], "O");
            }
        }
    }

    // Hiển thị người chiến thắng và cập nhật điểm số
    void ShowWinner(Text cell1, Text cell2, Text cell3, string winner)
    {
        // Đổi màu cho các ô chiến thắng
        cell1.color = Color.red;
        cell2.color = Color.red;
        cell3.color = Color.red;

        // Hiển thị thông báo người chiến thắng
        msgFeedback.text = "The winner is player " + winner;

        // Cập nhật điểm số
        if (winner == "X")
        {
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else if (winner == "O")
        {
            plusOne = int.Parse(txtY.text);
            txtY.text = Convert.ToString(plusOne + 1);
        }
    }

    public void btn1_Click()
    {
        if (checker == false)
        {
            btnText1.text = "X";
            checker = true;
        }
        else
        {
            btnText1.text = "O";
            checker = false;
        }
        score();
    }

    public void btn2_Click()
    {
        if (checker == false)
        {
            btnText2.text = "X";
            checker = true;
        }
        else
        {
            btnText2.text = "O";
            checker = false;
        }
        score();
    }

    public void btn3_Click()
    {
        if (checker == false)
        {
            btnText3.text = "X";
            checker = true;
        }
        else
        {
            btnText3.text = "O";
            checker = false;
        }
        score();
    }

    public void btn4_Click()
    {
        if (checker == false)
        {
            btnText4.text = "X";
            checker = true;
        }
        else
        {
            btnText4.text = "O";
            checker = false;
        }
        score();
    }

    public void btn5_Click()
    {
        if (checker == false)
        {
            btnText5.text = "X";
            checker = true;
        }
        else
        {
            btnText5.text = "O";
            checker = false;
        }
        score();
    }

    public void btn6_Click()
    {
        if (checker == false)
        {
            btnText6.text = "X";
            checker = true;
        }
        else
        {
            btnText6.text = "O";
            checker = false;
        }
        score();
    }

    public void btn7_Click()
    {
        if (checker == false)
        {
            btnText7.text = "X";
            checker = true;
        }
        else
        {
            btnText7.text = "O";
            checker = false;
        }
        score();
    }

    public void btn8_Click()
    {
        if (checker == false)
        {
            btnText8.text = "X";
            checker = true;
        }
        else
        {
            btnText8.text = "O";
            checker = false;
        }
        score();
    }

    public void btn9_Click()
    {
        if (checker == false)
        {
            btnText9.text = "X";
            checker = true;
        }
        else
        {
            btnText9.text = "O";
            checker = false;
        }
        score();
    }

    public void btnReset_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";

        msgFeedback.text = "";
        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;
    }

    public void btnNew_Click()
    {
        btnReset_Click();
        txtX.text = "0";
        txtY.text = "0";
    }
}
