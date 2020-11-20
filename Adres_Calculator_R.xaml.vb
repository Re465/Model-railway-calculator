Class Adres_Calculator_R

    Dim CV29_R As Integer
    Dim Adres_1 As Integer
    Dim CV1_R As Integer
    Dim CV17_R As Integer
    Dim CV17_1 As Integer
    Dim CV17_2 As Integer
    Dim CV18_R As Integer

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

    Private Sub Rdb_Calcul_Click(sender As Object, e As RoutedEventArgs) Handles Rdb_Calcul.Click
        Dim Blad4_3 As New Adres_Calculator
        Blad4_3.Show()
        Close()
    End Sub

    Private Sub Txt_Adres_CV1_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Adres_CV1.KeyUp
        If (IsNumeric(Txt_Adres_CV1.Text)) Then
            CV1_R = CSng(Txt_Adres_CV1.Text)
        Else
            MessageBox.Show("This is not a number!
            You must enter a number from 1 to 127.", "Incorrect input",
                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txt_Adres_CV1.Text = ""
            Exit Sub
        End If
        Select Case CV1_R
            Case < 1
                MessageBox.Show("You must enter a number from 1 to 127.", "Incorrect input",
                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case > 127
                MessageBox.Show("You must enter a number from 1 to 127.", "Incorrect input",
                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub Txt_Adres_CV17_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Adres_CV17.KeyUp
        If (IsNumeric(Txt_Adres_CV17.Text)) Then
            CV17_R = CSng(Txt_Adres_CV17.Text)
        Else
            MessageBox.Show("This is not a number!
            You must enter a number from 192 to 231.", "Incorrect input",
                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txt_Adres_CV17.Text = ""
            Exit Sub
        End If
        Select Case CV17_R
            Case = 1
                Exit Sub
            Case = 2
                Exit Sub
            Case = 19
                Exit Sub
            Case = 20
                Exit Sub
            Case = 21
                Exit Sub
            Case = 22
                Exit Sub
            Case = 23
                Exit Sub
            Case < 192
                MessageBox.Show("You must enter a number from 192 to 231.", "Incorrect input",
                                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case > 231
                MessageBox.Show("You must enter a number from 192 to 231.", "Incorrect input",
                                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case Else
                CV17_1 = CV17_R - 192
                Call Adress()
        End Select
    End Sub

    Private Sub Txt_Adres_CV18_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Adres_CV18.KeyUp
        If (IsNumeric(Txt_Adres_CV18.Text)) Then
            CV18_R = CSng(Txt_Adres_CV18.Text)
        Else
            MessageBox.Show("This is not a number!
            You must enter a number from 1 to 255.", "Incorrect input",
                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txt_Adres_CV18.Text = ""
            Exit Sub
        End If
        Select Case CV18_R
            Case < 0
                MessageBox.Show("You must enter a number from 1 to 255.", "Incorrect input",
                                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case > 255
                MessageBox.Show("You must enter a number from 1 to 255.", "Incorrect input",
                                                       MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Case Else
                Call Adress()
        End Select
    End Sub

    Private Sub Txt_Adres_CV29_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Adres_CV29.KeyUp
        If (IsNumeric(Txt_Adres_CV29.Text)) Then
            CV29_R = CSng(Txt_Adres_CV29.Text)
        Else
            MessageBox.Show("This is not a number!
            You must enter a number from 1 to 63.", "Incorrect input",
                                           MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Txt_Adres_CV29.Text = "2"
            ChkBit0.IsChecked = False
            TxtBit0.Text = "0"
            ChkBit1.IsChecked = True
            TxtBit1.Text = "2"
            ChkBit2.IsChecked = False
            TxtBit2.Text = "0"
            ChkBit3.IsChecked = False
            TxtBit3.Text = "0"
            ChkBit4.IsChecked = False
            TxtBit4.Text = "0"
            ChkBit5.IsChecked = False
            TxtBit5.Text = "0"
            Exit Sub
        End If
        Select Case CV29_R
            Case < 1
                MessageBox.Show("You must enter a number from 1 to 63.", "Incorrect input",
                                                          MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Txt_Adres_CV29.Text = "2"
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 1
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 2
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 3
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 4
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 5
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 6
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 7
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 8
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 9
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 10
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 11
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 12
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 13
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 14
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 15
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 16
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 17
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 18
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 19
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 20
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 21
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 22
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 23
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 24
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 25
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 26
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 27
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 28
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 29
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 30
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 31
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
            Case 32
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 33
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 34
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 35
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 36
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 37
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 38
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 39
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 40
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 41
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 42
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 43
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 44
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 45
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 46
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 47
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 48
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 49
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 50
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 51
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 52
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 53
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 54
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 55
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 56
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 57
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 58
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 59
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 60
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 61
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = False
                TxtBit1.Text = "0"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 62
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case 63
                ChkBit0.IsChecked = True
                TxtBit0.Text = "1"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = True
                TxtBit2.Text = "4"
                ChkBit3.IsChecked = True
                TxtBit3.Text = "8"
                ChkBit4.IsChecked = True
                TxtBit4.Text = "16"
                ChkBit5.IsChecked = True
                TxtBit5.Text = "32"
            Case Else
                MessageBox.Show("You must enter a number from 1 to 63.", "Incorrect input",
                                                          MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Txt_Adres_CV29.Text = "2"
                ChkBit0.IsChecked = False
                TxtBit0.Text = "0"
                ChkBit1.IsChecked = True
                TxtBit1.Text = "2"
                ChkBit2.IsChecked = False
                TxtBit2.Text = "0"
                ChkBit3.IsChecked = False
                TxtBit3.Text = "0"
                ChkBit4.IsChecked = False
                TxtBit4.Text = "0"
                ChkBit5.IsChecked = False
                TxtBit5.Text = "0"
        End Select
        Call Adress()
    End Sub

    Sub Adress()
        If ChkBit5.IsChecked = True Then
            CV17_2 = CV17_1 * 256
            Adres_1 = CV17_2 + CV18_R
            Select Case Adres_1
                Case < 1
                    MessageBox.Show("For Extended address, CV17 and CV18 must be completed.", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
                    TxB_Adress_Text.Text = ""
                    TxB_Adress.Text = ""
                    Exit Sub
                Case < 100
                    MessageBox.Show("For Extended address, the address must be higher than 99.", "Incorrect input",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation)
                    TxB_Adress_Text.Text = ""
                    TxB_Adress.Text = ""
                    Exit Sub
                Case > 10239
                    MessageBox.Show("An undefined error.", "Error",
                                    MessageBoxButton.OK, MessageBoxImage.Error)
                Case Else
                    TxB_Adress_Text.Text = "Extended address is in use"
                    TxB_Adress.Text = "Address:    " + Adres_1.ToString
            End Select
        Else
                CV1_R = CSng(Txt_Adres_CV1.Text)
            TxB_Adress_Text.Text = "Primary address is in use"
            TxB_Adress.Text = "Address:    " + CV1_R.ToString
        End If

    End Sub

End Class


