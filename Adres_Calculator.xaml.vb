Class Adres_Calculator

    Dim Bit0 As Integer
    Dim Bit1 As Integer = 2
    Dim Bit2 As Integer
    Dim Bit3 As Integer
    Dim Bit4 As Integer
    Dim Bit5 As Integer
    Dim CV29 As Integer
    Dim A As Integer
    Dim CV29_R As Integer
    Dim Primary As Integer
    Dim Adres_1 As Integer
    Dim CV_17_Stufe1 As Integer
    Dim CV_17_Stufe2 As Integer
    Dim CV_18 As Integer


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

    Private Sub ChkBox0_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit0.Click
        If ChkBit0.IsChecked = True Then
            TxtBit0.Text = "1"
            Bit0 = 1
        Else
            TxtBit0.Text = "0"
            Bit0 = 0
        End If
        Call BByte()
    End Sub

    Private Sub ChkBit1_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit1.Click
        If ChkBit1.IsChecked = True Then
            TxtBit1.Text = "2"
            Bit1 = 2
        Else
            TxtBit1.Text = "0"
            Bit1 = 0
        End If
        Call BByte()
    End Sub

    Private Sub ChkBit2_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit2.Click
        If ChkBit2.IsChecked = True Then
            TxtBit2.Text = "4"
            Bit2 = 4
        Else
            TxtBit2.Text = "0"
            Bit2 = 0
        End If
        Call BByte()
    End Sub

    Private Sub ChkBit3_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit3.Click
        If ChkBit3.IsChecked = True Then
            TxtBit3.Text = "8"
            Bit3 = 8
        Else
            TxtBit3.Text = "0"
            Bit3 = 0
        End If
        Call BByte()
    End Sub

    Private Sub ChkBit4_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit4.Click
        If ChkBit4.IsChecked = True Then
            TxtBit4.Text = "16"
            Bit4 = 16
        Else
            TxtBit4.Text = "0"
            Bit4 = 0
        End If
        Call BByte()
    End Sub

    Private Sub ChkBit5_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit5.Click
        If ChkBit5.IsChecked = True Then
            TxtBit5.Text = "32"
            Bit5 = 32
        Else
            TxtBit5.Text = "0"
            Bit5 = 0
        End If
        Call BByte()
    End Sub

    Private Sub RdB_99_Click(sender As Object, e As RoutedEventArgs) Handles Rdb_99.Click
        If (IsNumeric(Txt_Adres.Text)) Then Adres_1 = CSng(Txt_Adres.Text)
        Call Adres()
    End Sub

    Private Sub RdB_127_Click(sender As Object, e As RoutedEventArgs) Handles Rdb_127.Click
        If (IsNumeric(Txt_Adres.Text)) Then Adres_1 = CSng(Txt_Adres.Text)
        Call Adres()
    End Sub

    Sub Adres()
        If ChkBit1.IsChecked = True Then
            TxtBit1.Text = "2"
            Bit1 = 2
        Else
            TxtBit2.Text = "0"
            Bit1 = 0
        End If
        If Rdb_99.IsChecked = True Then
            Primary = 100
        Else
            Primary = 128
        End If
        Select Case Adres_1
            Case < 1
                MessageBox.Show("This address is too low!", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Call Hidden()
            Case < 100
                Call Sub_Primary()
            Case < 128
                If Primary = 100 Then
                    Call Extended()
                Else
                    Primary = 128
                    Call Sub_Primary()
                End If
            Case < 10000
                Call Extended()
            Case Else
                MessageBox.Show("This address is too high!", "Incorrect input",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Call Hidden()
        End Select
    End Sub

    Sub BByte()
        CV29 = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5
        Txt_CV29.Text = CV29.ToString
    End Sub

    Sub Hidden()
        Txt_CV1.Visibility = Visibility.Hidden
        Txt_CV17.Visibility = Visibility.Hidden
        Txt_CV18.Visibility = Visibility.Hidden
        Txt_Adres.Text = ""
    End Sub

    Sub Extended()
        Txt_CV1.Visibility = Visibility.Hidden
        Txt_CV17.Visibility = Visibility.Visible
        Txt_CV18.Visibility = Visibility.Visible
        CV_17_Stufe1 = (Adres_1 + 127) / 256 - 1
        CV_18 = Adres_1 - 256 * CV_17_Stufe1
        CV_17_Stufe2 = CV_17_Stufe1 + 192
        If CV_18 = 256 Then
            CV_18 = 0
            CV_17_Stufe2 = CV_17_Stufe2 + 1
        End If
        If CV_18 = 257 Then
            CV_18 = 1
            CV_17_Stufe2 = CV_17_Stufe2 + 1
        End If

        ChkBit5.IsChecked = True
        TxtBit5.Text = "32"
        Bit5 = 32
        Txt_CV17.Text = CV_17_Stufe2.ToString
        Txt_CV18.Text = CV_18.ToString
        Txt_CV29.Text = CV29.ToString
        Call BByte()
    End Sub

    Sub Sub_Primary()

        Txt_CV1.Visibility = Visibility.Visible
        Txt_CV1.Text = Adres_1.ToString
        Txt_CV17.Visibility = Visibility.Hidden
        Txt_CV18.Visibility = Visibility.Hidden
        ChkBit5.IsChecked = False
        TxtBit5.Text = "0"
        Bit5 = 0
        Call BByte()
    End Sub

    Private Sub Txt_Adres_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Adres.KeyUp
        If (IsNumeric(Txt_Adres.Text)) Then
            Adres_1 = CSng(Txt_Adres.Text)
            Call Adres()
        Else
            MessageBox.Show("This is not a number!
            You must enter a number from 1 to 9999.", "Incorrect input",
                                           MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Call Hidden()
        End If
    End Sub



    Private Sub Rdb_Rivers_Click(sender As Object, e As RoutedEventArgs) Handles Rdb_Rivers.Click
        Dim Rivers As New Adres_Calculator_R
        Rivers.Show()
        Close()
    End Sub

End Class


