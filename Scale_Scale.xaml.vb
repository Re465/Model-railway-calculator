Class Scale_Scale

    Dim Unit_A As String = "cm"
    Dim Unit_A_1 As String = 6
    Dim Unit_B As String = "cm"
    Dim Unit_B_1 As String = 6
    Dim Scale_A As Single = 87
    Dim Scale_A1 As String = "H0 scale (1:87)"
    Dim Scale_B As Single = 87
    Dim Scale_B1 As String = "H0 scale (1:87)"
    Dim Input1 As Single
    Dim Output1 As Single
    Dim Output2 As Single

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

    Private Sub Slope_Click(sender As Object, e As RoutedEventArgs) Handles Slope.Click
        Dim Blad3_1 As New Slope
        Blad3_1.Show()
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

    Private Sub Chk_Mile1_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mile1.Click
        If Chk_Mile1.IsChecked = True Then
            Unit_A = " mile"
            Unit_A_1 = 1
            Txt_Unit_A.Text = Unit_A
        End If
    End Sub

    Private Sub Chk_Foot1_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Foot1.Click
        If Chk_Foot1.IsChecked = True Then
            Unit_A = " ft"
            Unit_A_1 = 2
            Txt_Unit_A.Text = Unit_A
        End If
    End Sub

    Private Sub Chk_Inch1_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Inch1.Click
        If Chk_Inch1.IsChecked = True Then
            Unit_A = " in"
            Unit_A_1 = 3
            Txt_Unit_A.Text = Unit_A
        End If
    End Sub

    Private Sub Chk_Km1_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Km1.Click
        If Chk_Km1.IsChecked = True Then
            Unit_A = " km"
            Unit_A_1 = 4
            Txt_Unit_A.Text = Unit_A
        End If
    End Sub

    Private Sub Chk_M1_Click(sender As Object, e As RoutedEventArgs) Handles Chk_M1.Click
        If Chk_M1.IsChecked = True Then
            Unit_A = " m"
            Unit_A_1 = 5
            Txt_Unit_A.Text = Unit_A
        End If
    End Sub

    Private Sub Chk_Cm1_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Cm1.Click
        If Chk_Cm1.IsChecked = True Then
            Unit_A = " cm"
            Unit_A_1 = 6
            Txt_Unit_A.Text = Unit_A
        End If
    End Sub

    Private Sub Chk_Mm1_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mm1.Click
        If Chk_Mm1.IsChecked = True Then
            Unit_A = " mm"
            Unit_A_1 = 7
            Txt_Unit_A.Text = Unit_A
        End If
    End Sub

    Private Sub Chk_Mile2_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mile2.Click
        If Chk_Mile2.IsChecked = True Then
            Unit_B = " mile"
            Unit_B_1 = 1
        End If
    End Sub

    Private Sub Chk_Foot2_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Foot2.Click
        If Chk_Foot2.IsChecked = True Then
            Unit_B = " ft"
            Unit_B_1 = 2
        End If
    End Sub

    Private Sub Chk_Inch2_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Inch2.Click
        If Chk_Inch2.IsChecked = True Then
            Unit_B = " in"
            Unit_B_1 = 3
        End If
    End Sub

    Private Sub Chk_Km2_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Km2.Click
        If Chk_Km2.IsChecked = True Then
            Unit_B = " km"
            Unit_B_1 = 4
        End If
    End Sub

    Private Sub Chk_M2_Click(sender As Object, e As RoutedEventArgs) Handles Chk_M2.Click
        If Chk_M2.IsChecked = True Then
            Unit_B = " m"
            Unit_B_1 = 5
        End If
    End Sub

    Private Sub Chk_Cm2_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Cm2.Click
        If Chk_Cm2.IsChecked = True Then
            Unit_B = " cm"
            Unit_B_1 = 6
        End If
    End Sub

    Private Sub Chk_Mm2_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mm2.Click
        If Chk_Mm2.IsChecked = True Then
            Unit_B = " mm"
            Unit_B_1 = 7
        End If
    End Sub

    Private Sub Chk_Z_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Z_A.Click
        If Chk_Z_A.IsChecked = True Then
            Scale_A = 220
            Scale_A1 = "Z scale (1:220)"
        End If
    End Sub

    Private Sub Chk_N_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_N_A.Click
        If Chk_N_A.IsChecked = True Then
            Scale_A = 160
            Scale_A1 = "N scale (1:160)"
        End If
    End Sub

    Private Sub Chk_TT_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_TT_A.Click
        If Chk_TT_A.IsChecked = True Then
            Scale_A = 120
            Scale_A1 = "TT scale (1:120)"
        End If
    End Sub

    Private Sub Chk_H0_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_H0_A.Click
        If Chk_H0_A.IsChecked = True Then
            Scale_A = 87
            Scale_A1 = "H0 scale (1:87)"
        End If
    End Sub

    Private Sub Chk_00_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_00_A.Click
        If Chk_00_A.IsChecked = True Then
            Scale_A = 76
            Scale_A1 = "00 scale (1:76)"
        End If
    End Sub

    Private Sub Chk_S_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_S_A.Click
        If Chk_S_A.IsChecked = True Then
            Scale_A = 64
            Scale_A1 = "S scale (1:64)"
        End If
    End Sub

    Private Sub Chk_0_1_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_0_1_A.Click
        If Chk_0_1_A.IsChecked = True Then
            Scale_A = 48
            Scale_A1 = "0 scale (1:48, NMRA)"
        End If
    End Sub

    Private Sub Chk_0_2_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_0_2_A.Click
        If Chk_0_2_A.IsChecked = True Then
            Scale_A = 45
            Scale_A1 = "0 scale (1:45, NEM)"
        End If
    End Sub

    Private Sub Chk_0_3_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_0_3_A.Click
        If Chk_0_3_A.IsChecked = True Then
            Scale_A = 43.5
            Scale_A1 = "0 scale (1:43.5, BRMSB)"
        End If
    End Sub

    Private Sub Chk_I_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_I_A.Click
        If Chk_I_A.IsChecked = True Then
            Scale_A = 32
            Scale_A1 = "I scale (1:32)"
        End If
    End Sub

    Private Sub Chk_II_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_II_A.Click
        If Chk_II_A.IsChecked = True Then
            Scale_A = 22.5
            Scale_A1 = "II scale (1:22.5)"
        End If
    End Sub

    Private Sub Chk_III_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_III_A.Click
        If Chk_III_A.IsChecked = True Then
            Scale_A = 16
            Scale_A1 = "III scale (1:16)"
        End If
    End Sub

    Private Sub Chk_V_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_V_A.Click
        If Chk_V_A.IsChecked = True Then
            Scale_A = 11
            Scale_A1 = "V scale (1:11)"
        End If
    End Sub

    Private Sub Chk_VII_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_VII_A.Click
        If Chk_VII_A.IsChecked = True Then
            Scale_A = 8
            Scale_A1 = "VII scale (1:8)"
        End If
    End Sub

    Private Sub Chk_X_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_X_A.Click
        If Chk_X_A.IsChecked = True Then
            Scale_A = 5.5
            Scale_A1 = "X scale (1:5.5)"
        End If
    End Sub

    Private Sub Chk_XY_A_Click(sender As Object, e As RoutedEventArgs) Handles Chk_XY_A.Click
        If Chk_XY_A.IsChecked = True Then
            If (IsNumeric(Txb_XY.Text) = True) Then
                Scale_A = CSng(Txb_XY.Text)
                Scale_A1 = "XY scale (1:" + CStr(Scale_A) + ")"
            Else
                Chk_H0_A.IsChecked = True
                Scale_A = 87
                Txb_XY.Text = ""
                MessageBox.Show("You have not entered XY number.", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
            End If
        End If
    End Sub

    Private Sub Chk_Z_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Z_B.Click
        If Chk_Z_B.IsChecked = True Then
            Scale_B = 220
            Scale_B1 = "Z scale (1:220)"
        End If
    End Sub

    Private Sub Chk_N_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_N_B.Click
        If Chk_N_B.IsChecked = True Then
            Scale_B = 160
            Scale_B1 = "N scale (1:160)"
        End If
    End Sub

    Private Sub Chk_TT_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_TT_B.Click
        If Chk_TT_B.IsChecked = True Then
            Scale_B = 120
            Scale_B1 = "TT scale (1:120)"
        End If
    End Sub

    Private Sub Chk_H0_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_H0_B.Click
        If Chk_H0_B.IsChecked = True Then
            Scale_B = 87
            Scale_B1 = "H0 scale (1:87)"
        End If
    End Sub

    Private Sub Chk_00_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_00_B.Click
        If Chk_00_B.IsChecked = True Then
            Scale_B = 76
            Scale_B1 = "00 scale (1:76)"
        End If
    End Sub

    Private Sub Chk_S_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_S_B.Click
        If Chk_S_B.IsChecked = True Then
            Scale_B = 64
            Scale_B1 = "S scale (1:64)"
        End If
    End Sub

    Private Sub Chk_0_1_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_0_1_B.Click
        If Chk_0_1_B.IsChecked = True Then
            Scale_B = 48
            Scale_B1 = "0 scale (1:48, NMRA)"
        End If
    End Sub

    Private Sub Chk_0_2_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_0_2_B.Click
        If Chk_0_2_B.IsChecked = True Then
            Scale_B = 45
            Scale_B1 = "0 scale (1:45, NEM)"
        End If
    End Sub

    Private Sub Chk_0_3_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_0_3_B.Click
        If Chk_0_3_B.IsChecked = True Then
            Scale_B = 43.5
            Scale_B1 = "0 scale (1:43.5, BRMSB)"
        End If
    End Sub

    Private Sub Chk_I_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_I_B.Click
        If Chk_I_B.IsChecked = True Then
            Scale_B = 32
            Scale_B1 = "I scale (1:32)"
        End If
    End Sub

    Private Sub Chk_II_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_II_B.Click
        If Chk_II_B.IsChecked = True Then
            Scale_B = 22.5
            Scale_B1 = "II scale (1:22.5)"
        End If
    End Sub

    Private Sub Chk_III_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_III_B.Click
        If Chk_III_B.IsChecked = True Then
            Scale_B = 16
            Scale_B1 = "III scale (1:16)"
        End If
    End Sub

    Private Sub Chk_V_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_V_B.Click
        If Chk_V_B.IsChecked = True Then
            Scale_B = 11
            Scale_B1 = "V scale (1:11)"
        End If
    End Sub

    Private Sub Chk_VII_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_VII_B.Click
        If Chk_VII_B.IsChecked = True Then
            Scale_B = 8
            Scale_B1 = "VII scale (1:8)"
        End If
    End Sub

    Private Sub Chk_X_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_X_B.Click
        If Chk_X_B.IsChecked = True Then
            Scale_B = 5.5
            Scale_B1 = "X scale (1:5.5)"
        End If
    End Sub

    Private Sub Chk_YZ_B_Click(sender As Object, e As RoutedEventArgs) Handles Chk_YZ_B.Click
        If Chk_YZ_B.IsChecked = True Then
            If (IsNumeric(Txb_YZ.Text) = True) Then
                Scale_B = CSng(Txb_YZ.Text)
                Scale_B1 = "YZ scale (1:" + CStr(Scale_B) + ")"
            Else
                Chk_H0_B.IsChecked = True
                Scale_B = 87
                Txb_YZ.Text = ""
                MessageBox.Show("You have not entered YZ number.", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
            End If
        End If
    End Sub

    Private Sub Btn_Calculate_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Calculate.Click
        If (IsNumeric(Txt_Input.Text) = True) Then
            Input1 = CInt(Txt_Input.Text)
        Else
            MessageBox.Show("You have not entered a size.", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txt_Output.Text = ""
            Exit Sub
        End If
        If Chk_XY_A.IsChecked = True Then
            If (IsNumeric(Txb_XY.Text) = True) Then
                Scale_A = CSng(Txb_XY.Text)
                Scale_A1 = "XY scale (1:" + CStr(Scale_A) + ")"
            Else
                Txt_Output.Text = ""
                Txb_XY.Text = ""
                MessageBox.Show("You have not entered XY number.", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Exit Sub
            End If
        End If
        If Chk_YZ_B.IsChecked = True Then
            If (IsNumeric(Txb_YZ.Text) = True) Then
                Scale_B = CSng(Txb_YZ.Text)
                Scale_B1 = "YZ scale (1:" + CStr(Scale_B) + ")"
            Else
                Txt_Output.Text = ""
                Txb_YZ.Text = ""
                MessageBox.Show("You have not entered YZ number.", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Exit Sub
            End If
        End If
        Call Unit()
    End Sub

    Private Sub Txb_XY_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_XY.KeyUp
        If Txb_XY.Text = "" Then Exit Sub
        If (IsNumeric(Txb_XY.Text) = True) Then
            Chk_XY_A.IsChecked = True
            Scale_A = CSng(Txb_XY.Text)
            Scale_A1 = "XY scale (1:" + CStr(Scale_A) + ")"
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_XY.Text = ""
            Txt_Output.Text = ""
            Scale_A1 = ""
        End If
    End Sub

    Private Sub Txb_YZ_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_YZ.KeyUp
        If Txb_YZ.Text = "" Then Exit Sub
        If (IsNumeric(Txb_YZ.Text) = True) Then
            Chk_YZ_B.IsChecked = True
            Scale_B = CSng(Txb_YZ.Text)
            Scale_B1 = "YZ scale (1:" + CStr(Scale_B) + ")"
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_YZ.Text = ""
            Txt_Output.Text = ""
            Scale_B1 = ""
        End If
    End Sub

    Private Sub Unit()
        Select Case Unit_A_1
            Case 1
                Output1 = Input1 * 1609.344 * Scale_A
            Case 2
                Output1 = Input1 * 3.048 * Scale_A
            Case 3
                Output1 = Input1 * 0.0254 * Scale_A
            Case 4
                Output1 = Input1 * 1000 * Scale_A
            Case 5
                Output1 = Input1 * Scale_A
            Case 6
                Output1 = Input1 * 0.01 * Scale_A
            Case 7
                Output1 = Input1 * 0.001 * Scale_A
        End Select

        Select Case Unit_B_1
            Case 1
                Output2 = Output1 / 1609.344 / Scale_B
            Case 2
                Output2 = Output1 / 3.048 / Scale_B
            Case 3
                Output2 = Output1 / 0.0254 / Scale_B
            Case 4
                Output2 = Output1 / 1000 / Scale_B
            Case 5
                Output2 = Output1 / Scale_B
            Case 6
                Output2 = Output1 / 0.01 / Scale_B
            Case 7
                Output2 = Output1 / 0.001 / Scale_B
        End Select
        Txt_Output.Text = $"{CStr(Input1)}{Unit_A} from {Scale_A1} is to {Scale_B1} {Output2:0.##}{Unit_B} long"
    End Sub

    Private Sub Txt_Input_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Input.KeyUp
        If Txt_Input.Text = "" Then Exit Sub
        If (IsNumeric(Txt_Input.Text) = True) Then
            Input1 = CInt(Txt_Input.Text)
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txt_Input.Text = ""
        End If
    End Sub
End Class
