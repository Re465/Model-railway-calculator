Class Slope
    Dim Lengte_A As Single
    Dim Lengte_B As Single
    Dim Lengte_C As Single
    Dim Promile As Single
    Dim Grade As Single
    Dim Cos As Single
    Dim Unit As String = "cm"
    Dim Teller As Single = 0
    Dim Teller2 As Single = 0


    Private Sub FileExit_Click(sender As Object, e As RoutedEventArgs) Handles FileExit.Click
        Close()
    End Sub

    Private Sub MainWindow_Click(sender As Object, e As RoutedEventArgs) Handles MainWindow.Click
        Dim Blad1_1 As New MainWindow
        Blad1_1.Show()
        Close()
    End Sub

    Private Sub Org_Scale_Click(sender As Object, e As RoutedEventArgs) Handles Org_Scale.Click
        Dim Blad2_1 As New Org_Scale
        Blad2_1.Show()
        Close()
    End Sub

    Private Sub Scale_Org_Click(sender As Object, e As RoutedEventArgs) Handles Scale_Org.Click
        Dim Blad2_2 As New Scale_Org
        Blad2_2.Show()
        Close()
    End Sub

    Private Sub Scale_Scale_Click(sender As Object, e As RoutedEventArgs) Handles Scale_Scale.Click
        Dim Blad2_3 As New Scale_Scale
        Blad2_3.Show()
        Close()
    End Sub

    Private Sub Track_radius_Click(sender As Object, e As RoutedEventArgs) Handles Track_radius.Click
        Dim Blad3_2 As New Gyroscope
        Blad3_2.Show()
        Close()
    End Sub

    Private Sub Helex_Click(sender As Object, e As RoutedEventArgs) Handles Helex.Click
        Dim Blad3_3 As New Helex
        Blad3_3.Show()
        Close()
    End Sub

    Private Sub Bit_Calculator_Click(sender As Object, e As RoutedEventArgs) Handles Bit_Calculator.Click
        Dim Blad4_1 As New Bit_Calculator
        Blad4_1.Show()
        Close()
    End Sub

    Private Sub CV29_Calculator_Click(sender As Object, e As RoutedEventArgs) Handles CV29_Calculator.Click
        Dim Blad4_2 As New CV29_Calculator
        Blad4_2.Show()
        Close()
    End Sub

    Private Sub Adres_Calculator_Click(sender As Object, e As RoutedEventArgs) Handles Adres_Calculator.Click
        Dim Blad4_3 As New Adres_Calculator
        Blad4_3.Show()
        Close()
    End Sub

    Private Sub Dipswitch_Click(sender As Object, e As RoutedEventArgs) Handles Dipswitch.Click
        Dim Blad5_1_1 As New Dipswitch
        Blad5_1_1.Show()
        Close()
    End Sub

    Private Sub Info_Click(sender As Object, e As RoutedEventArgs) Handles Info.Click
        Dim Blad6_1 As New Info
        Blad6_1.Show()
        Close()
    End Sub

    Private Sub GNU_Click(sender As Object, e As RoutedEventArgs) Handles GNU.Click
        Dim Blad6_2 As New GNU
        Blad6_2.Show()
        Close()
    End Sub


    Private Sub Chk_Mile_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mile.Click
        If Chk_Mile.IsChecked = True Then
            Unit = " mile"
            Txt_Unit_A.Text = Unit
            Txt_Unit_B.Text = Unit
            Txt_Unit_C.Text = Unit
        End If
    End Sub

    Private Sub Chk_Foot_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Foot.Click
        If Chk_Foot.IsChecked = True Then
            Unit = " ft"
            Txt_Unit_A.Text = Unit
            Txt_Unit_B.Text = Unit
            Txt_Unit_C.Text = Unit
        End If
    End Sub

    Private Sub Chk_Inch_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Inch.Click
        If Chk_Inch.IsChecked = True Then
            Unit = " in"
            Txt_Unit_A.Text = Unit
            Txt_Unit_B.Text = Unit
            Txt_Unit_C.Text = Unit
        End If
    End Sub

    Private Sub Chk_Km_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Km.Click
        If Chk_Km.IsChecked = True Then
            Unit = " km"
            Txt_Unit_A.Text = Unit
            Txt_Unit_B.Text = Unit
            Txt_Unit_C.Text = Unit
        End If
    End Sub

    Private Sub Chk_M_Click(sender As Object, e As RoutedEventArgs) Handles Chk_M.Click
        If Chk_M.IsChecked = True Then
            Unit = " m"
            Txt_Unit_A.Text = Unit
            Txt_Unit_B.Text = Unit
            Txt_Unit_C.Text = Unit
        End If
    End Sub

    Private Sub Chk_Cm_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Cm.Click
        If Chk_Cm.IsChecked = True Then
            Unit = " cm"
            Txt_Unit_A.Text = Unit
            Txt_Unit_B.Text = Unit
            Txt_Unit_C.Text = Unit
        End If
    End Sub

    Private Sub Chk_Mm_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mm.Click
        If Chk_Mm.IsChecked = True Then
            Unit = " mm"
            Txt_Unit_A.Text = Unit
            Txt_Unit_B.Text = Unit
            Txt_Unit_C.Text = Unit
        End If
    End Sub

    Private Sub Btn_Calculate_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Calculate.Click
        Teller = 0
        Teller2 = 0
        If (IsNumeric(Txb_A.Text)) Then
            Lengte_A = CSng(Txb_A.Text)
            Teller += 1
            Teller2 += 2
        End If
        If (IsNumeric(Txb_B.Text)) Then
            Lengte_B = CSng(Txb_B.Text)
            Teller += 1
            Teller2 += 4
        End If
        If (IsNumeric(Txb_C.Text)) Then
            Lengte_C = CSng(Txb_C.Text)
            Teller += 1
            Teller2 += 8
        End If
        If (IsNumeric(Txb_Alfa.Text)) Then
            Promile = CSng(Txb_Alfa.Text)
            Teller += 1
            Teller2 += 16
        End If

        Select Case Teller
            Case 0
                MessageBox.Show("You must fill in two fields.", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case 1
                MessageBox.Show("You must fill in two fields.", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case 2
                Call Caculator()
            Case Else
                MessageBox.Show("You have filled in too many fields.", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)

        End Select
    End Sub

    Sub Caculator()

        Select Case Teller2
            Case 6
                Lengte_C = Math.Sqrt((Lengte_A * Lengte_A) + (Lengte_B * Lengte_B))
                Promile = Lengte_B / Lengte_A * 1000
                Cos = Lengte_A / Lengte_C
                Grade = (Math.Acos(Cos) / Math.PI) * 180
            Case 10
                Lengte_B = Math.Sqrt((Lengte_C * Lengte_C) - (Lengte_A * Lengte_A))
                Promile = Lengte_B / Lengte_A * 1000
                Cos = Lengte_A / Lengte_C
                Grade = (Math.Acos(Cos) / Math.PI) * 180
            Case 12
                Lengte_A = Math.Sqrt((Lengte_C * Lengte_C) - (Lengte_B * Lengte_B))
                Promile = Lengte_B / Lengte_A * 1000
                Cos = Lengte_A / Lengte_C
                Grade = (Math.Acos(Cos) / Math.PI) * 180
            Case 18
                Lengte_B = Lengte_A * (Promile / 1000)
                Lengte_C = Math.Sqrt((Lengte_A * Lengte_A) + (Lengte_B * Lengte_B))
                Cos = Lengte_A / Lengte_C
                Grade = (Math.Acos(Cos) / Math.PI) * 180
            Case 20
                Lengte_A = Lengte_B / (Promile / 1000)
                Lengte_C = Math.Sqrt((Lengte_A * Lengte_A) + (Lengte_B * Lengte_B))
                Cos = Lengte_A / Lengte_C
                Grade = (Math.Acos(Cos) / Math.PI) * 180
            Case 24
                MessageBox.Show("This has not been integrated yet.", "Info",
                                MessageBoxButton.OK, MessageBoxImage.Information)
                Txb_A_Calc.Text = ""
                Txb_B_Calc.Text = ""
                Txb_C_Calc.Text = ""
                Txb_Alfa_Calc.Text = ""
                Teller = 0
                Teller2 = 0
                Exit Sub
        End Select

        Txb_A_Calc.Text = Lengte_A.ToString("0.##") + Unit
        Txb_B_Calc.Text = Lengte_B.ToString("0.##") + Unit
        Txb_C_Calc.Text = Lengte_C.ToString("0.##") + Unit
        Txb_Alfa_Calc.Text = Promile.ToString("0.##") + "‰ and " + Grade.ToString("0.##") + "°"
        Teller = 0
        Teller2 = 0
    End Sub

    Private Sub Txb_A_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_A.KeyUp
        If Txb_A.Text = "" Then Exit Sub
        If (IsNumeric(Txb_A.Text)) Then
            Lengte_A = CSng(Txb_A.Text)
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_A.Text = ""
        End If
    End Sub

    Private Sub Txb_B_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_B.KeyUp
        If Txb_B.Text = "" Then Exit Sub
        If (IsNumeric(Txb_B.Text)) Then
            Lengte_B = CSng(Txb_B.Text)
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_B.Text = ""
        End If
    End Sub

    Private Sub Txb_C_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_C.KeyUp
        If Txb_C.Text = "" Then Exit Sub
        If (IsNumeric(Txb_C.Text)) Then
            Lengte_C = CSng(Txb_C.Text)
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_C.Text = ""
        End If
    End Sub

    Private Sub Txb_Alfa_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_Alfa.KeyUp
        If Txb_Alfa.Text = "" Then Exit Sub
        If (IsNumeric(Txb_Alfa.Text)) Then
            Promile = CSng(Txb_Alfa.Text)
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_Alfa.Text = ""
        End If
    End Sub
End Class
