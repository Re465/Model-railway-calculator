Class Helex
    Dim Lengte_H As Single
    Dim Lengte_A As Single
    Dim Lengte_Total As Single
    Dim Lengte_Total2 As Single
    Dim Lengte_A2 As Single
    Dim Lengte_B As Single
    Dim Lengte_C As Single
    Dim Lengte_C2 As Single
    Dim Lengte_R As Single
    Dim Lengte_R2 As Single
    Dim Amount As Single
    Dim Promile As Single
    Dim Promile2 As Single
    Dim Grade As Single
    Dim Grade2 As Single
    Dim Cos As Single
    Dim Cos2 As Single
    Dim Unit As String = "cm"
    Dim Teller As Single = 0
    Dim Helex_H As Single



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
            Txt_Unit_H.Text = Unit
            Txt_Unit_B.Text = Unit
        End If
    End Sub

    Private Sub Chk_Foot_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Foot.Click
        If Chk_Foot.IsChecked = True Then
            Unit = " ft"
            Txt_Unit_H.Text = Unit
            Txt_Unit_B.Text = Unit
        End If
    End Sub

    Private Sub Chk_Inch_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Inch.Click
        If Chk_Inch.IsChecked = True Then
            Unit = " in"
            Txt_Unit_H.Text = Unit
            Txt_Unit_B.Text = Unit
        End If
    End Sub

    Private Sub Chk_Km_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Km.Click
        If Chk_Km.IsChecked = True Then
            Unit = " km"
            Txt_Unit_H.Text = Unit
            Txt_Unit_B.Text = Unit
        End If
    End Sub

    Private Sub Chk_M_Click(sender As Object, e As RoutedEventArgs) Handles Chk_M.Click
        If Chk_M.IsChecked = True Then
            Unit = " m"
            Txt_Unit_H.Text = Unit
            Txt_Unit_B.Text = Unit
        End If
    End Sub

    Private Sub Chk_Cm_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Cm.Click
        If Chk_Cm.IsChecked = True Then
            Unit = " cm"
            Txt_Unit_H.Text = Unit
            Txt_Unit_B.Text = Unit
        End If
    End Sub

    Private Sub Chk_Mm_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mm.Click
        If Chk_Mm.IsChecked = True Then
            Unit = " mm"
            Txt_Unit_H.Text = Unit
            Txt_Unit_B.Text = Unit
        End If
    End Sub

    Private Sub Btn_Calculate_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Calculate.Click
        Teller = 0
        If (IsNumeric(Txb_H.Text)) Then
            Lengte_H = CSng(Txb_H.Text)
            Teller += 1
        End If
        If (IsNumeric(Txb_B.Text)) Then
            Lengte_B = CSng(Txb_B.Text)
        Else
            Lengte_B = 0
        End If
        If (IsNumeric(Txb_Amount.Text)) Then
            Amount = CSng(Txb_Amount.Text)
            Teller += 1
        End If
        If (IsNumeric(Txb_Alfa.Text)) Then
            Promile = CSng(Txb_Alfa.Text)
            Teller += 1
        End If

        If Teller = 3 Then
            Call Caculator()

        Else
            MessageBox.Show("You must fill out more fields.
     Field B is facultative.", "Incorrect input",
                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
        End If

    End Sub

    Sub Caculator()
        'Track 1 and  2
        Helex_H = Lengte_H * Amount

        'Track 1
        Lengte_A = Lengte_H / (Promile / 1000) 'Baseline
        Lengte_C = Math.Sqrt((Lengte_A * Lengte_A) + (Lengte_H * Lengte_H)) 'Hypotenusa(Track)
        Lengte_Total = Lengte_C * Amount 'Totale track
        Cos = Lengte_A / Lengte_C 'Grade step 1
        Grade = (Math.Acos(Cos) / Math.PI) * 180 'Grade step 2
        Lengte_R = Lengte_A / 2 / Math.PI 'Radius

        Txt_Track1.Visibility = Visibility.Visible

        'Track 2
        If Lengte_B > 0 Then
            Lengte_R2 = Lengte_R + Lengte_B 'Radius
            Lengte_A2 = (Lengte_R2 * 2) * Math.PI 'Baseline
            Lengte_C2 = Math.Sqrt((Lengte_A2 * Lengte_A2) + (Lengte_H * Lengte_H)) 'Hypotenusa(Track)
            Lengte_Total2 = Lengte_C2 * Amount 'Totale track
            Cos2 = Lengte_A2 / Lengte_C2 'Grade step 1
            Grade2 = (Math.Acos(Cos2) / Math.PI) * 180 'Grade step 2
            Promile2 = Lengte_H / Lengte_A2 * 1000 'Promile

            Txt_Track2.Visibility = Visibility.Visible
            Txb_Track_T2_Calc.Text = "Track lengthy :  " + Lengte_Total2.ToString("0.## ") + Unit
            Txb_Slope_T2_Calc.Text = "Slope :  " + Promile2.ToString("0.##") + "‰ und " + Grade2.ToString("0.##°")
            Txb_Radius_T2_Calc.Text = "Radius :  " + Lengte_R2.ToString("0.## ") + Unit
        Else

            Txt_Track2.Visibility = Visibility.Hidden
            Txb_Track_T2_Calc.Text = ""
            Txb_Slope_T2_Calc.Text = ""
            Txb_Radius_T2_Calc.Text = ""
        End If


        Txb_H_Calc.Text = Lengte_H.ToString("0.## ") + Unit
        Txb_B_Calc.Text = Lengte_B.ToString("0.## ") + Unit
        Txb_Layer_Calc.Text = "Layer highest :  " + Lengte_H.ToString("0.## ") + Unit
        Txb_Tot_H_Calc.Text = "Total highest :  " + Helex_H.ToString("0.## ") + Unit
        Txb_Amount_Calc.Text = "Amount of layers :  " + Amount.ToString("0.## ")
        Txb_Track_T1_Calc.Text = "Track lengthy :  " + Lengte_Total.ToString("0.## ") + Unit
        Txb_Slope_T1_Calc.Text = "Slope :  " + Promile.ToString("0.##") + "‰ und " + Grade.ToString("0.##°")
        Txb_Radius_T1_Calc.Text = "Radius :  " + Lengte_R.ToString("0.## ") + Unit




        Teller = 0

    End Sub

End Class
