Class MainWindow
    Dim h As Double
    Dim num1, num2, sign As String
    Dim refresher, newNum As Boolean
    Public Sub reset_all()
        ui_Display.Text = ""
        sign = ""
        num1 = ""
        num2 = ""
        refresher = True
        newNum = False

    End Sub

    Private Sub key_Clear_Click() Handles key_ClearAll.Click

        reset_all()

    End Sub

    Private Sub key_Decimal_Click()

        If sign <> "" And newNum = False Then
            ui_Display.Text = "0."
            newNum = True
        Else
        End If

        If ui_Display.Text = "" Then
            ui_Display.Text = "0."
            refresher = True
        Else
            ui_Display.Text = ui_Display.Text & "."
            refresher = True
        End If

    End Sub


    Private Sub key_0_Click(sender As Object, e As RoutedEventArgs) Handles key_0.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 0
    End Sub
    Private Sub key_1_Click(sender As Object, e As RoutedEventArgs) Handles key_1.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 1
    End Sub

    Private Sub opp_div_Click() Handles opp_div.Click

        If num1 > "" And refresher = True Then
            sign = "div"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "div"
            newNum = False
            refresher = True
        Else
        End If

    End Sub
    Private Sub opp_equal_Click() Handles opp_equal.Click


        Evaluate()

    End Sub

    Public Sub Evaluate()
        If num1 <> "" Then


            num2 = Val(ui_Display.Text)



            Select Case sign
                Case "add"
                    'function for addition button goes here
                Case "sub"
                    'function for subtraction button goes here
                Case "mul"
                    'function for multiplication button goes here
                Case "div"
                    'function for division button goes here
                    ui_Display.Text = Val(num1) / Val(num2)
                Case "pow"
                    'function for addition button goes here
                Case ""
            End Select


            refresher = False
            newNum = True

        Else
        End If

    End Sub


End Class
