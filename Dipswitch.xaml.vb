Class Dipswitch

    Dim Byte1 As Integer = 0
    Dim Byte2 As Integer = 0
    Dim Byte3 As Integer = 0
    Dim Byte4 As Integer = 0
    Dim Byte5 As Integer = 0
    Dim Byte6 As Integer = 0
    Dim Byte7 As Integer = 0
    Dim Byte8 As Integer = 0
    Dim ByteSume As Integer = 0

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

    Private Sub RB1_1_Click(sender As Object, e As RoutedEventArgs) Handles RB1_1.Click
        If RB1_1.IsChecked = True Then
            Byte1 = 1
            RB1_3.IsChecked = True
            RB2_2.IsChecked = True
            Byte2 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB1_2_Click(sender As Object, e As RoutedEventArgs) Handles RB1_2.Click
        If RB1_2.IsChecked = True Then
            Byte1 = 0
            RB1_4.IsChecked = True
        End If
        Call Adresse()
    End Sub

    Private Sub RB1_3_Click(sender As Object, e As RoutedEventArgs) Handles RB1_3.Click
        If RB1_3.IsChecked = True Then
            RB1_1.IsChecked = True
            RB2_2.IsChecked = True
            Byte1 = 1
            Byte2 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB1_4_Click(sender As Object, e As RoutedEventArgs) Handles RB1_4.Click
        If RB1_4.IsChecked = True Then
            RB1_2.IsChecked = True
            Byte1 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB2_1_Click(sender As Object, e As RoutedEventArgs) Handles RB2_1.Click
        If RB2_1.IsChecked = True Then
            Byte2 = 2
            RB1_2.IsChecked = True
            RB1_4.IsChecked = True
            Byte1 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB2_2_Click(sender As Object, e As RoutedEventArgs) Handles RB2_2.Click
        If RB2_2.IsChecked = True Then Byte2 = 0
        Call Adresse()
    End Sub

    Private Sub RB3_1_Click(sender As Object, e As RoutedEventArgs) Handles RB3_1.Click
        If RB3_1.IsChecked = True Then
            Byte3 = 4
            RB3_3.IsChecked = True
            RB4_2.IsChecked = True
            Byte4 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB3_2_Click(sender As Object, e As RoutedEventArgs) Handles RB3_2.Click
        If RB3_2.IsChecked = True Then
            Byte3 = 0
            RB3_4.IsChecked = True
        End If
        Call Adresse()
    End Sub

    Private Sub RB3_3_Click(sender As Object, e As RoutedEventArgs) Handles RB3_3.Click
        If RB3_3.IsChecked = True Then
            RB3_1.IsChecked = True
            RB4_2.IsChecked = True
            Byte3 = 4
            Byte4 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB3_4_Click(sender As Object, e As RoutedEventArgs) Handles RB3_4.Click
        If RB3_4.IsChecked = True Then
            RB3_2.IsChecked = True
            Byte3 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB4_1_Click(sender As Object, e As RoutedEventArgs) Handles RB4_1.Click
        If RB4_1.IsChecked = True Then
            Byte4 = 8
            RB3_2.IsChecked = True
            RB3_4.IsChecked = True
            Byte3 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB4_2_Click(sender As Object, e As RoutedEventArgs) Handles RB4_2.Click
        If RB4_2.IsChecked = True Then Byte4 = 0
        Call Adresse()
    End Sub

    Private Sub RB5_1_Click(sender As Object, e As RoutedEventArgs) Handles RB5_1.Click
        If RB5_1.IsChecked = True Then
            Byte5 = 16
            RB6_2.IsChecked = True
            RB5_3.IsChecked = True
            Byte6 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB5_2_Click(sender As Object, e As RoutedEventArgs) Handles RB5_2.Click
        If RB5_2.IsChecked = True Then
            Byte5 = 0
            RB5_4.IsChecked = True
        End If
        Call Adresse()
    End Sub

    Private Sub RB5_3_Click(sender As Object, e As RoutedEventArgs) Handles RB5_3.Click
        If RB5_3.IsChecked = True Then
            RB5_1.IsChecked = True
            RB6_2.IsChecked = True
            Byte5 = 16
            Byte6 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB5_4_Click(sender As Object, e As RoutedEventArgs) Handles RB5_4.Click
        If RB5_4.IsChecked = True Then
            RB5_2.IsChecked = True
            Byte5 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB6_1_Click(sender As Object, e As RoutedEventArgs) Handles RB6_1.Click
        If RB6_1.IsChecked = True Then
            Byte6 = 32
            RB5_2.IsChecked = True
            RB5_4.IsChecked = True
            Byte5 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB6_2_Click(sender As Object, e As RoutedEventArgs) Handles RB6_2.Click
        If RB6_2.IsChecked = True Then
            Byte6 = 0
            RB5_4.IsChecked = True
        End If
        Call Adresse()
    End Sub

    Private Sub RB7_1_Click(sender As Object, e As RoutedEventArgs) Handles RB7_1.Click
        If RB7_1.IsChecked = True Then
            Byte7 = 64
            RB8_2.IsChecked = True
            RB7_3.IsChecked = True
            Byte8 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB7_2_Click(sender As Object, e As RoutedEventArgs) Handles RB7_2.Click
        If RB7_2.IsChecked = True Then
            Byte7 = 0
            RB7_4.IsChecked = True
        End If
        Call Adresse()
    End Sub

    Private Sub RB7_3_Click(sender As Object, e As RoutedEventArgs) Handles RB7_3.Click
        If RB7_3.IsChecked = True Then
            RB7_1.IsChecked = True
            RB8_2.IsChecked = True
            Byte7 = 64
            Byte8 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB7_4_Click(sender As Object, e As RoutedEventArgs) Handles RB7_4.Click
        If RB7_4.IsChecked = True Then
            RB7_2.IsChecked = True
            Byte7 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB8_1_Click(sender As Object, e As RoutedEventArgs) Handles RB8_1.Click
        If RB8_1.IsChecked = True Then
            Byte8 = 128
            RB7_2.IsChecked = True
            RB7_4.IsChecked = True
            Byte7 = 0
        End If
        Call Adresse()
    End Sub

    Private Sub RB8_2_Click(sender As Object, e As RoutedEventArgs) Handles RB8_2.Click
        If RB8_2.IsChecked = True Then Byte8 = 0
        Call Adresse()
    End Sub

    Sub Adresse()


        LbDelta_2.Visibility = Visibility.Hidden
        LbDelta_3.Visibility = Visibility.Hidden
        LbDelta_4.Visibility = Visibility.Hidden
        LbDelta_5.Visibility = Visibility.Hidden

        ByteSume = Byte1 + Byte2 + Byte3 + Byte4 + Byte5 + Byte6 + Byte7 + Byte8

        Select Case ByteSume
            Case 1
                Txt_M_Adres.Text = 78
                Txt_D_Adres.Text = 78
                LbDelta_2.Visibility = Visibility.Visible
            Case 2
                Txt_M_Adres.Text = 79
                Txt_D_Adres.Text = ""
            Case 4
                Txt_M_Adres.Text = 74
                Txt_D_Adres.Text = 74
            Case 5
                Txt_M_Adres.Text = 72
                Txt_D_Adres.Text = 72
                LbDelta_5.Visibility = Visibility.Visible
            Case 6
                Txt_M_Adres.Text = 73
                Txt_D_Adres.Text = ""
            Case 8
                Txt_M_Adres.Text = 77
                Txt_D_Adres.Text = ""
            Case 9
                Txt_M_Adres.Text = 75
                Txt_D_Adres.Text = ""
            Case 10
                Txt_M_Adres.Text = 76
                Txt_D_Adres.Text = ""
            Case 16
                Txt_M_Adres.Text = 62
                Txt_D_Adres.Text = 62
            Case 17
                Txt_M_Adres.Text = 60
                Txt_D_Adres.Text = 60
                LbDelta_3.Visibility = Visibility.Visible
            Case 18
                Txt_M_Adres.Text = 61
                Txt_D_Adres.Text = ""
            Case 20
                Txt_M_Adres.Text = 56
                Txt_D_Adres.Text = 56
            Case 21
                Txt_M_Adres.Text = 54
                Txt_D_Adres.Text = 54
            Case 22
                Txt_M_Adres.Text = 55
                Txt_D_Adres.Text = ""
            Case 24
                Txt_M_Adres.Text = 59
                Txt_D_Adres.Text = ""
            Case 25
                Txt_M_Adres.Text = 57
                Txt_D_Adres.Text = ""
            Case 26
                Txt_M_Adres.Text = 58
                Txt_D_Adres.Text = ""
            Case 32
                Txt_M_Adres.Text = 71
                Txt_D_Adres.Text = ""
            Case 33
                Txt_M_Adres.Text = 69
                Txt_D_Adres.Text = ""
            Case 34
                Txt_M_Adres.Text = 70
                Txt_D_Adres.Text = ""
            Case 36
                Txt_M_Adres.Text = 65
                Txt_D_Adres.Text = ""
            Case 37
                Txt_M_Adres.Text = 63
                Txt_D_Adres.Text = ""
            Case 38
                Txt_M_Adres.Text = 64
                Txt_D_Adres.Text = ""
            Case 40
                Txt_M_Adres.Text = 68
                Txt_D_Adres.Text = ""
            Case 41
                Txt_M_Adres.Text = 66
                Txt_D_Adres.Text = ""
            Case 42
                Txt_M_Adres.Text = 67
                Txt_D_Adres.Text = ""
            Case 64
                Txt_M_Adres.Text = 26
                Txt_D_Adres.Text = 26
            Case 65
                Txt_M_Adres.Text = 24
                Txt_D_Adres.Text = 24
                LbDelta_4.Visibility = Visibility.Visible
            Case 66
                Txt_M_Adres.Text = 25
                Txt_D_Adres.Text = ""
            Case 68
                Txt_M_Adres.Text = 20
                Txt_D_Adres.Text = 20
            Case 69
                Txt_M_Adres.Text = 18
                Txt_D_Adres.Text = 18
            Case 70
                Txt_M_Adres.Text = 19
                Txt_D_Adres.Text = ""
            Case 72
                Txt_M_Adres.Text = 23
                Txt_D_Adres.Text = ""
            Case 73
                Txt_M_Adres.Text = 21
                Txt_D_Adres.Text = ""
            Case 74
                Txt_M_Adres.Text = 22
                Txt_D_Adres.Text = ""
            Case 80
                Txt_M_Adres.Text = 8
                Txt_D_Adres.Text = 8
            Case 81
                Txt_M_Adres.Text = 6
                Txt_D_Adres.Text = 6
            Case 82
                Txt_M_Adres.Text = 7
                Txt_D_Adres.Text = ""
            Case 84
                Txt_M_Adres.Text = 2
                Txt_D_Adres.Text = 2
            Case 85
                Txt_M_Adres.Text = 80
                Txt_D_Adres.Text = 80
            Case 86
                Txt_M_Adres.Text = 1
                Txt_D_Adres.Text = ""
            Case 88
                Txt_M_Adres.Text = 5
                Txt_D_Adres.Text = ""
            Case 89
                Txt_M_Adres.Text = 3
                Txt_D_Adres.Text = ""
            Case 90
                Txt_M_Adres.Text = 4
                Txt_D_Adres.Text = ""
            Case 96
                Txt_M_Adres.Text = 5
                Txt_D_Adres.Text = ""
            Case 97
                Txt_M_Adres.Text = 6
                Txt_D_Adres.Text = ""
            Case 98
                Txt_M_Adres.Text = 7
                Txt_D_Adres.Text = ""
            Case 100
                Txt_M_Adres.Text = 11
                Txt_D_Adres.Text = ""
            Case 101
                Txt_M_Adres.Text = 9
                Txt_D_Adres.Text = ""
            Case 102
                Txt_M_Adres.Text = 10
                Txt_D_Adres.Text = ""
            Case 104
                Txt_M_Adres.Text = 14
                Txt_D_Adres.Text = ""
            Case 105
                Txt_M_Adres.Text = 12
                Txt_D_Adres.Text = ""
            Case 106
                Txt_M_Adres.Text = 13
                Txt_D_Adres.Text = ""
            Case 128
                Txt_M_Adres.Text = 53
                Txt_D_Adres.Text = ""
            Case 129
                Txt_M_Adres.Text = 51
                Txt_D_Adres.Text = ""
            Case 130
                Txt_M_Adres.Text = 52
                Txt_D_Adres.Text = ""
            Case 132
                Txt_M_Adres.Text = 47
                Txt_D_Adres.Text = ""
            Case 133
                Txt_M_Adres.Text = 45
                Txt_D_Adres.Text = ""
            Case 134
                Txt_M_Adres.Text = 46
                Txt_D_Adres.Text = ""
            Case 136
                Txt_M_Adres.Text = 50
                Txt_D_Adres.Text = ""
            Case 137
                Txt_M_Adres.Text = 48
                Txt_D_Adres.Text = ""
            Case 138
                Txt_M_Adres.Text = 49
                Txt_D_Adres.Text = ""
            Case 144
                Txt_M_Adres.Text = 35
                Txt_D_Adres.Text = ""
            Case 145
                Txt_M_Adres.Text = 33
                Txt_D_Adres.Text = ""
            Case 146
                Txt_M_Adres.Text = 34
                Txt_D_Adres.Text = ""
            Case 148
                Txt_M_Adres.Text = 29
                Txt_D_Adres.Text = ""
            Case 149
                Txt_M_Adres.Text = 27
                Txt_D_Adres.Text = ""
            Case 150
                Txt_M_Adres.Text = 28
                Txt_D_Adres.Text = ""
            Case 152
                Txt_M_Adres.Text = 32
                Txt_D_Adres.Text = ""
            Case 153
                Txt_M_Adres.Text = 30
                Txt_D_Adres.Text = ""
            Case 154
                Txt_M_Adres.Text = 31
                Txt_D_Adres.Text = ""
            Case 160
                Txt_M_Adres.Text = 44
                Txt_D_Adres.Text = ""
            Case 161
                Txt_M_Adres.Text = 42
                Txt_D_Adres.Text = ""
            Case 162
                Txt_M_Adres.Text = 43
                Txt_D_Adres.Text = ""
            Case 164
                Txt_M_Adres.Text = 38
                Txt_D_Adres.Text = ""
            Case 165
                Txt_M_Adres.Text = 36
                Txt_D_Adres.Text = ""
            Case 166
                Txt_M_Adres.Text = 37
                Txt_D_Adres.Text = ""
            Case 168
                Txt_M_Adres.Text = 41
                Txt_D_Adres.Text = ""
            Case 169
                Txt_M_Adres.Text = 39
                Txt_D_Adres.Text = ""
            Case 170
                Txt_M_Adres.Text = 40
                Txt_D_Adres.Text = ""
            Case Else
                Txt_M_Adres.Text = ""
                Txt_D_Adres.Text = ""
        End Select
    End Sub




End Class
