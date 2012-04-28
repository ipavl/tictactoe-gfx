' Tic-Tac-Toe
' Author: Ian P [ippavlin]

Imports System.Drawing

Public Class TicTacToe

    Private P1Wins, P2Wins, CatWins As Byte
    Private WINNER As String

    Private PLAYER_TURN, GAME_OVER, isCATS_GAME As Boolean
    Private BOX1, BOX2, BOX3, BOX4, BOX5, BOX6, BOX7, BOX8, BOX9 As Char

    Private Function CheckifGameOver()
        'This will check if the game is over.
        If GAME_OVER = False Then
            If BOX1 = "X" And BOX2 = "X" And BOX3 = "X" Then
                'This will cover boxes 1-3.
                picBox1.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox2.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox3.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX1 = "O" And BOX2 = "O" And BOX3 = "O" Then
                'This will cover boxes 1-3.
                picBox1.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox2.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox3.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX4 = "X" And BOX5 = "X" And BOX6 = "X" Then
                'This will cover boxes 4-6.
                picBox4.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox6.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX4 = "O" And BOX5 = "O" And BOX6 = "O" Then
                'This will cover boxes 4-6.
                picBox4.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox6.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX7 = "X" And BOX8 = "X" And BOX9 = "X" Then
                'This will cover boxes 7-9.
                picBox7.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox8.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox9.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX7 = "O" And BOX8 = "O" And BOX9 = "O" Then
                'This will cover boxes 7-9.
                picBox7.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox8.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox9.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX1 = "X" And BOX4 = "X" And BOX7 = "X" Then
                'This will cover boxes 1-4-7.
                picBox1.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox4.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox7.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX1 = "O" And BOX4 = "O" And BOX7 = "O" Then
                'This will cover boxes 1-4-7.
                picBox1.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox4.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox7.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX2 = "X" And BOX5 = "X" And BOX8 = "X" Then
                'This will cover boxes 2-5-8.
                picBox2.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox8.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX2 = "O" And BOX5 = "O" And BOX8 = "O" Then
                'This will cover boxes 2-5-8.
                picBox2.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox8.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX3 = "X" And BOX6 = "X" And BOX9 = "X" Then
                'This will cover boxes 3-6-9.
                picBox3.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox6.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox9.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX3 = "O" And BOX6 = "O" And BOX9 = "O" Then
                'This will cover boxes 3-6-9.
                picBox3.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox6.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox9.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX1 = "X" And BOX5 = "X" And BOX9 = "X" Then
                'This will cover boxes 1-5-9.
                picBox1.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox9.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX1 = "O" And BOX5 = "O" And BOX9 = "O" Then
                'This will cover boxes 1-5-9.
                picBox1.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox9.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX3 = "X" And BOX5 = "X" And BOX7 = "X" Then
                'This will cover boxes 3-5-7.
                picBox3.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_X_HL.PNG")
                picBox7.Image = New Bitmap("res\BOX_X_HL.PNG")
                GAME_OVER = True
                WINNER = "X"
            ElseIf BOX3 = "O" And BOX5 = "O" And BOX7 = "O" Then
                'This will cover boxes 3-5-7.
                picBox3.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox5.Image = New Bitmap("res\BOX_O_HL.PNG")
                picBox7.Image = New Bitmap("res\BOX_O_HL.PNG")
                GAME_OVER = True
                WINNER = "O"
            End If

            If BOX1 <> Nothing And BOX2 <> Nothing And BOX3 <> Nothing And BOX4 <> Nothing And BOX5 <> Nothing And BOX6 <> Nothing And BOX7 <> Nothing And BOX8 <> Nothing And BOX9 <> Nothing And GAME_OVER = False Then
                'The game should end if all boxes are taken and the game isn't over by now.
                GAME_OVER = True
                isCATS_GAME = True
            End If

            If GAME_OVER = True And isCATS_GAME = False Then
                If WINNER = "X" Then
                    P1Wins = P1Wins + 1
                    bP1Wins.Text = "Player 1 Wins: " & P1Wins
                ElseIf WINNER = "O" Then
                    P2Wins = P2Wins + 1
                    bP2Wins.Text = "Player 2 Wins: " & P2Wins
                End If
                MessageBox.Show("The game is over! " & WINNER & " has won!", "Game over!")
            ElseIf GAME_OVER = True And isCATS_GAME = True Then
                CatWins = CatWins + 1
                bCatWins.Text = "Cat's Games: " & CatWins
                MessageBox.Show("The game is over! Neither player won.", "Game over!")
            End If
        End If
        Return Nothing
    End Function

    Private Function NewGame()
        If MessageBox.Show("Is Player 1 going to be X?", "Choose player", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            PLAYER_TURN = False
        Else
            PLAYER_TURN = True
        End If
        Return Nothing
    End Function

    Private Sub TicTacToe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NewGame()
    End Sub

    Private Sub picBox1_Click(sender As System.Object, e As System.EventArgs) Handles picBox1.Click
        If BOX1 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX1 = "O"
                'Load the image
                picBox1.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX1 = "X"
                'Load the image
                picBox1.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub picBox2_Click(sender As System.Object, e As System.EventArgs) Handles picBox2.Click
        If BOX2 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX2 = "O"
                'Load the image
                picBox2.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX2 = "X"
                'Load the image
                picBox2.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub


    Private Sub picBox3_Click(sender As System.Object, e As System.EventArgs) Handles picBox3.Click
        If BOX3 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX3 = "O"
                'Load the image
                picBox3.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX3 = "X"
                'Load the image
                picBox3.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub picBox4_Click(sender As System.Object, e As System.EventArgs) Handles picBox4.Click
        If BOX4 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX4 = "O"
                'Load the image
                picBox4.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX4 = "X"
                'Load the image
                picBox4.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub picBox5_Click(sender As System.Object, e As System.EventArgs) Handles picBox5.Click
        If BOX5 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX5 = "O"
                'Load the image
                picBox5.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX5 = "X"
                'Load the image
                picBox5.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub picBox6_Click(sender As System.Object, e As System.EventArgs) Handles picBox6.Click
        If BOX6 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX6 = "O"
                'Load the image
                picBox6.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX6 = "X"
                'Load the image
                picBox6.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub picBox7_Click(sender As System.Object, e As System.EventArgs) Handles picBox7.Click
        If BOX7 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX7 = "O"
                'Load the image
                picBox7.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX7 = "X"
                'Load the image
                picBox7.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub picBox8_Click(sender As System.Object, e As System.EventArgs) Handles picBox8.Click
        If BOX8 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX8 = "O"
                'Load the image
                picBox8.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX8 = "X"
                'Load the image
                picBox8.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub picBox9_Click(sender As System.Object, e As System.EventArgs) Handles picBox9.Click
        If BOX9 = Nothing And GAME_OVER = False Then
            If PLAYER_TURN = True Then
                'Box is now of type O
                BOX9 = "O"
                'Load the image
                picBox9.Image = New Bitmap("res\BOX_O.PNG")
                PLAYER_TURN = False
            Else
                'Box is now of type X
                BOX9 = "X"
                'Load the image
                picBox9.Image = New Bitmap("res\BOX_X.PNG")
                PLAYER_TURN = True
            End If
            CheckifGameOver()
        End If
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to start a new game?", "Start new game?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            picBox1.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox2.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox3.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox4.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox5.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox6.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox7.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox8.Image = New Bitmap("res\BOX_BLANK.PNG")
            picBox9.Image = New Bitmap("res\BOX_BLANK.PNG")

            PLAYER_TURN = False
            GAME_OVER = False
            isCATS_GAME = False
            WINNER = Nothing
            BOX1 = Nothing
            BOX2 = Nothing
            BOX3 = Nothing
            BOX4 = Nothing
            BOX5 = Nothing
            BOX6 = Nothing
            BOX7 = Nothing
            BOX8 = Nothing
            BOX9 = Nothing

            NewGame()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("Made by Ian P." & vbNewLine & vbNewLine & "August 2011", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
