Option Strict On
Option Explicit On

Public Class Form1
    'Declaring dynamic Array
    Private number_of_days() As Integer
    Private days As Integer


    Private Sub btn_set_days_Click(sender As Object, e As EventArgs) Handles btn_set_days.Click


        If txt_days_to_monitor_blood_donations.Text <> "" Then
            'setting up the ujgrid
            ReDim number_of_days(CInt(txt_days_to_monitor_blood_donations.Text)) 'resizing array
            grd_blood_donations.Rows = CInt(txt_days_to_monitor_blood_donations.Text) + 3 'initially 1
            days = CInt(txt_days_to_monitor_blood_donations.Text) + 2
            grd_blood_donations.Cols = 3

            grd_blood_donations.Row = 0
            grd_blood_donations.Col = 1
            grd_blood_donations.Text = "number of donors"
            grd_blood_donations.Col = 2
            grd_blood_donations.Text = "Average"

            Dim counter As Integer = 0
            Dim average_counter As Integer = 2
            For i = 0 To CInt(txt_days_to_monitor_blood_donations.Text) - 1
                grd_blood_donations.Row = counter + 1
                grd_blood_donations.Col = 0
                grd_blood_donations.Text = "Day " + CStr(counter + 1)

                counter += 1


            Next
            grd_blood_donations.Row = days - 1
            grd_blood_donations.Text = "total donors"
            grd_blood_donations.Row = days
            grd_blood_donations.Text = "Average"

        End If
    End Sub

    Private Sub btn_set_donors_Click(sender As Object, e As EventArgs) Handles btn_set_donors.Click
        Dim counter As Integer = 0
        For i = 0 To number_of_days.Length
            If counter <= number_of_days.Length - 2 Then
                Dim input = InputBox("Enter number of donor:", "number of donor", "") 'asking the user how many donors where there per day

                If input <> "" Then
                    number_of_days(i) = CInt(input)
                    register_donor()

                    grd_blood_donations.Col = 1
                    grd_blood_donations.Row = days - 1
                    grd_blood_donations.Text = "total donors"
                    grd_blood_donations.Row = days
                    grd_blood_donations.Text = "Average"

                    grd_blood_donations.Col = 2
                    grd_blood_donations.Row = days - 1
                    grd_blood_donations.Text = CStr(get_total_donors())

                    grd_blood_donations.Row = days
                    grd_blood_donations.Text = CStr(get_total_average())

                End If


            End If
            counter += 1
        Next

    End Sub

    Private Sub register_donor()
        For i = 0 To number_of_days.Length - 2
            If CStr(number_of_days(i)) <> "" Then

                grd_blood_donations.Row = i + 1
                grd_blood_donations.Col = 1
                grd_blood_donations.Text = CStr(number_of_days(i))

                grd_blood_donations.Col = 2
                grd_blood_donations.Row = i + 1
                grd_blood_donations.Text = CStr(get_average(number_of_days(i), i + 1))

            End If

        Next
    End Sub

    Private Function get_average(ByVal x As Integer, ByVal number_of_days As Integer) As Double
        'calculating total average people who donated blood
        Return x / number_of_days

    End Function

    Private Function get_total_average() As Double
        'calculating total average people who donated blood
        Dim total_average As Integer = 0

        For i = 0 To number_of_days.Length - 1
            total_average += number_of_days(i)
        Next

        Return total_average / number_of_days.Length
    End Function

    Private Function get_total_donors() As Integer
        Dim total_donors As Integer = 0

        For i = 0 To number_of_days.Length - 1
            total_donors += number_of_days(i)
        Next

        Return total_donors
    End Function


End Class



