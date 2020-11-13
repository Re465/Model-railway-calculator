Class Gyroscope
    Dim Lengte_R As Single
    Dim Lengte_O As Single
    Dim Unit As String = "cm"

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
            Txt_Unit_R.Text = Unit
            Txt_Unit_O.Text = Unit
        End If
    End Sub

    Private Sub Chk_Foot_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Foot.Click
        If Chk_Foot.IsChecked = True Then
            Unit = " ft"
            Txt_Unit_R.Text = Unit
            Txt_Unit_O.Text = Unit
        End If
    End Sub

    Private Sub Chk_Inch_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Inch.Click
        If Chk_Inch.IsChecked = True Then
            Unit = " in"
            Txt_Unit_R.Text = Unit
            Txt_Unit_O.Text = Unit
        End If
    End Sub

    Private Sub Chk_Km_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Km.Click
        If Chk_Km.IsChecked = True Then
            Unit = " km"
            Txt_Unit_R.Text = Unit
            Txt_Unit_O.Text = Unit
        End If
    End Sub

    Private Sub Chk_M_Click(sender As Object, e As RoutedEventArgs) Handles Chk_M.Click
        If Chk_M.IsChecked = True Then
            Unit = " m"
            Txt_Unit_R.Text = Unit
            Txt_Unit_O.Text = Unit
        End If
    End Sub

    Private Sub Chk_Cm_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Cm.Click
        If Chk_Cm.IsChecked = True Then
            Unit = " cm"
            Txt_Unit_R.Text = Unit
            Txt_Unit_O.Text = Unit
        End If
    End Sub

    Private Sub Chk_Mm_Click(sender As Object, e As RoutedEventArgs) Handles Chk_Mm.Click
        If Chk_Mm.IsChecked = True Then
            Unit = " mm"
            Txt_Unit_R.Text = Unit
            Txt_Unit_O.Text = Unit
        End If
    End Sub

    Private Sub Txb_R_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_R.KeyUp
        If Txb_R.Text = "" Then Exit Sub
        If (IsNumeric(Txb_R.Text)) Then
            Lengte_R = CSng(Txb_R.Text)
            Lengte_O = 2 * Lengte_R * Math.PI
            Txb_R_Calc.Text = Lengte_R.ToString("0.##") + Unit
            Txb_O_Calc.Text = Lengte_O.ToString("0.##") + Unit
            Txb_O.Text = ""
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_R.Text = ""
            Txb_O.Text = ""
        End If
    End Sub

    Private Sub Txb_O_KeyUp(sender As Object, e As KeyEventArgs) Handles Txb_O.KeyUp
        If Txb_O.Text = "" Then Exit Sub
        If (IsNumeric(Txb_O.Text)) Then
            Lengte_O = CSng(Txb_O.Text)
            Lengte_R = (Lengte_O / 2) / Math.PI
            Txb_R_Calc.Text = Lengte_R.ToString("0.##") + Unit
            Txb_O_Calc.Text = Lengte_O.ToString("0.##") + Unit
            Txb_R.Text = ""
        Else
            MessageBox.Show("This is not a number!", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txb_R.Text = ""
            Txb_O.Text = ""
        End If
    End Sub
End Class
