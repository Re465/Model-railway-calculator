Class CV29_Calculator

    Dim Bit0 As Integer
    Dim Bit1 As Integer = 0
    Dim Bit2 As Integer = 0
    Dim Bit3 As Integer = 0
    Dim Bit4 As Integer = 0
    Dim Bit5 As Integer = 0
    Dim Bit6 As Integer = 0
    Dim Bit7 As Integer = 0
    Dim Byte_Total As Integer = 0

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

    Private Sub ChkBox0_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit0.Click
        If ChkBit0.IsChecked = True Then
            TxtBit0.Text = "1"
            Bit0 = 1
        Else
            TxtBit0.Text = "0"
            Bit0 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

    Private Sub ChkBit1_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit1.Click
        If ChkBit1.IsChecked = True Then
            TxtBit1.Text = "2"
            Bit1 = 2
        Else
            TxtBit1.Text = "0"
            Bit1 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

    Private Sub ChkBit2_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit2.Click
        If ChkBit2.IsChecked = True Then
            TxtBit2.Text = "4"
            Bit2 = 4
        Else
            TxtBit2.Text = "0"
            Bit2 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

    Private Sub ChkBit3_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit3.Click
        If ChkBit3.IsChecked = True Then
            TxtBit3.Text = "8"
            Bit3 = 8
        Else
            TxtBit3.Text = "0"
            Bit3 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

    Private Sub ChkBit4_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit4.Click
        If ChkBit4.IsChecked = True Then
            TxtBit4.Text = "16"
            Bit4 = 16
        Else
            TxtBit4.Text = "0"
            Bit4 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

    Private Sub ChkBit5_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit5.Click
        If ChkBit5.IsChecked = True Then
            TxtBit5.Text = "32"
            Bit5 = 32
        Else
            TxtBit5.Text = "0"
            Bit5 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

    Private Sub ChkBit6_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit6.Click
        If ChkBit6.IsChecked = True Then
            TxtBit6.Text = "64"
            Bit6 = 64
        Else
            TxtBit6.Text = "0"
            Bit6 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

    Private Sub ChkBit7_Click(sender As Object, e As RoutedEventArgs) Handles ChkBit7.Click
        If ChkBit7.IsChecked = True Then
            TxtBit7.Text = "128"
            Bit7 = 128
        Else
            TxtBit7.Text = "0"
            Bit7 = 0
        End If
        Byte_Total = Bit0 + Bit1 + Bit2 + Bit3 + Bit4 + Bit5 + Bit6 + Bit7
        TxtSumme.Text = CStr(Byte_Total)
    End Sub

End Class
