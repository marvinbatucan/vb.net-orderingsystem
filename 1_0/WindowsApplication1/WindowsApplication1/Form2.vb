
Public Class Form2
    Dim AmericanBreakfast As Decimal
    Dim FilipinoBreakfast As Decimal
    Dim FilipinoBeefSteak As Decimal
    Dim ContinentalBreakfast As Decimal
    Dim Omeletwithcheeseormushroom As Decimal
    Dim Chopsueywithrice As Decimal
    Dim Fishfillet As Decimal
    Dim Chickengardonblue As Decimal
    Dim Chickenadobo As Decimal
    Dim Burger As Decimal
    Dim FrenchFries As Decimal
    Dim Softdrinks As Decimal
    Dim total As Decimal


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox2.Text += 1
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox3.Text += 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox4.Text += 1
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox5.Text += 1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox6.Text += 1
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox7.Text += 1
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox8.Text += 1
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox9.Text += 1
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TextBox11.Text += 1
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox12.Text += 1
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TextBox13.Text += 1
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        TextBox14.Text += 1
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox2.Text -= 1
        If TextBox2.Text <= 0 Then
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox3.Text -= 1
        TextBox3.Text -= 1
        If TextBox3.Text <= 0 Then
            TextBox3.Text = 0
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox4.Text -= 1
        TextBox4.Text -= 1
        If TextBox4.Text <= 0 Then
            TextBox4.Text = 0
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox5.Text -= 1
        TextBox5.Text -= 1
        If TextBox5.Text <= 0 Then
            TextBox5.Text = 0
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox6.Text -= 1
        TextBox6.Text -= 1
        If TextBox6.Text <= 0 Then
            TextBox6.Text = 0
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox7.Text -= 1
        TextBox7.Text -= 1
        If TextBox7.Text <= 0 Then
            TextBox7.Text = 0
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox8.Text -= 1
        TextBox8.Text -= 1
        If TextBox8.Text <= 0 Then
            TextBox8.Text = 0
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox9.Text -= 1
        TextBox9.Text -= 1
        If TextBox9.Text <= 0 Then
            TextBox9.Text = 0
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox11.Text -= 1
        TextBox11.Text -= 1
        If TextBox11.Text <= 0 Then
            TextBox11.Text = 0
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox12.Text -= 1
        TextBox12.Text -= 1
        If TextBox12.Text <= 0 Then
            TextBox12.Text = 0
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox13.Text -= 1
        TextBox13.Text -= 1
        If TextBox13.Text <= 0 Then
            TextBox13.Text = 0
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        TextBox14.Text -= 1
        TextBox14.Text -= 1
        If TextBox14.Text <= 0 Then
            TextBox14.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AmericanBreakfast = TextBox2.Text * 180.0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FilipinoBreakfast = TextBox3.Text * 120.0

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FilipinoBeefSteak = TextBox4.Text * 150.0

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ContinentalBreakfast = TextBox5.Text * 65.0

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Omeletwithcheeseormushroom = TextBox6.Text * 75.0

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Chopsueywithrice = TextBox7.Text * 135.0

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Fishfillet = TextBox8.Text * 200.0

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Chickengardonblue = TextBox9.Text * 220.0

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Chickenadobo = TextBox11.Text * 190.0
        txtTotal.Text = "P" & Format(AmericanBreakfast + FilipinoBreakfast + FilipinoBeefSteak + ContinentalBreakfast + Omeletwithcheeseormushroom + Chopsueywithrice + Fishfillet + Chickengardonblue + Chickenadobo + Burger + FrenchFries + Softdrinks, "0.00")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Burger = TextBox12.Text * 45.0

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FrenchFries = TextBox13.Text * 30.0

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Softdrinks = TextBox14.Text * 15.0

    End Sub

    Private Sub Resibo_Click(sender As Object, e As EventArgs) Handles Resibo.Click
        'reciept for the transaction
        rtfResibo.AppendText("----------------------------------" + vbNewLine)
        rtfResibo.AppendText("Palm Restaurant and Beach Resorts" + vbNewLine)
        rtfResibo.AppendText("----------------------------------" + vbNewLine)
        rtfResibo.AppendText("American Breakfast --------" + vbTab + TextBox2.Text + vbNewLine)
        rtfResibo.AppendText("Filipino Breakfast --------" + vbTab + TextBox3.Text + vbNewLine)
        rtfResibo.AppendText("Filipino BeefSteak --------" + vbTab + TextBox4.Text + vbNewLine)
        rtfResibo.AppendText("Continental Breakfast --------" + vbTab + TextBox5.Text + vbNewLine)
        rtfResibo.AppendText("Omelet --------" + vbTab + TextBox6.Text + vbNewLine)
        rtfResibo.AppendText("Chopsuey w/ Rice --------" + vbTab + TextBox7.Text + vbNewLine)
        rtfResibo.AppendText("Fish Fillet --------" + vbTab + TextBox8.Text + vbNewLine)
        rtfResibo.AppendText("Chicken Gardon Blu --------" + vbTab + TextBox9.Text + vbNewLine)
        rtfResibo.AppendText("Chicken Adobo --------" + vbTab + TextBox11.Text + vbNewLine)
        rtfResibo.AppendText("Burger --------" + vbTab + TextBox12.Text + vbNewLine)
        rtfResibo.AppendText("French Fries --------" + vbTab + TextBox13.Text + vbNewLine)
        rtfResibo.AppendText("Softdrinks --------" + vbTab + TextBox14.Text + vbNewLine)
        rtfResibo.AppendText("Total Payment --------" + vbTab + txtTotal.Text + vbNewLine)
        rtfResibo.AppendText("-----------------------------------" + vbNewLine)
        rtfResibo.AppendText("HAVE A GOOD DAY" + vbNewLine)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'for the close or exit buttons
        Me.Close()
        MessageBox.Show("Thank you for ordering!")

    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox14.Text = 0
        txtTotal.Text = 0
        rtfResibo.Clear()

        AmericanBreakfast = 0
        FilipinoBreakfast = 0
        FilipinoBeefSteak = 0
        ContinentalBreakfast = 0
        Omeletwithcheeseormushroom = 0
        Chopsueywithrice = 0
        Fishfillet = 0
        Chickengardonblue = 0
        Chickenadobo = 0
        Burger = 0
        FrenchFries = 0
        Softdrinks = 0
        total = 0
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        AmericanBreakfast = TextBox2.Text * 180.0
        FilipinoBreakfast = TextBox3.Text * 120.0
        FilipinoBeefSteak = TextBox4.Text * 160.0
        ContinentalBreakfast = TextBox5.Text * 65.0
        Omeletwithcheeseormushroom = TextBox6.Text * 75.0
        Chopsueywithrice = TextBox7.Text * 160.0
        Fishfillet = TextBox8.Text * 200.0
        Chickengardonblue = TextBox9.Text * 200.0
        Chickenadobo = TextBox11.Text * 200.0
        Burger = TextBox12.Text * 35.0
        FrenchFries = TextBox13.Text * 35.0
        Softdrinks = TextBox14.Text * 15.0


        txtTotal.Text = "P" & Format(AmericanBreakfast + FilipinoBreakfast + FilipinoBeefSteak + ContinentalBreakfast + Omeletwithcheeseormushroom + Chopsueywithrice + Fishfillet + Chickengardonblue + Chickenadobo + Burger + FrenchFries + Softdrinks, "0.00")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(rtfResibo.Text, rtfResibo.Font, Brushes.Blue, 100, 100)
    End Sub

    Private Sub rtfResibo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtfResibo.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub



    Private Sub rtfResibo_TextChanged(sender As Object, e As EventArgs) Handles rtfResibo.TextChanged

    End Sub

    Private Sub Button37_Click_1(sender As Object, e As EventArgs)
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub Button38_Click_1(sender As Object, e As EventArgs)
        rtfResibo.Text = ""
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        rtfResibo.Text = ""
    End Sub


    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox14.Text = 0
        txtTotal.Text = 0
        rtfResibo.Clear()

        AmericanBreakfast = 0
        FilipinoBreakfast = 0
        FilipinoBeefSteak = 0
        ContinentalBreakfast = 0
        Omeletwithcheeseormushroom = 0
        Chopsueywithrice = 0
        Fishfillet = 0
        Chickengardonblue = 0
        Chickenadobo = 0
        Burger = 0
        FrenchFries = 0
        Softdrinks = 0
        total = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class