Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.cmbSize.DataSource = KeyValue.GetSize()
        Me.cmbSize.DisplayMember = "Value"
        Me.cmbSize.ValueMember = "Key"

        Call Rdo1_CheckedChanged(Nothing, Nothing)
        Call Rdo2_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Function GetSize() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo11.CheckedChanged

        Call ChangeEnable(Me.PnlBody1, Me.Rdo11.Checked)

    End Sub
    Private Sub Rdo2_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo21.CheckedChanged

        Call ChangeEnable(Me.PnlBody2, Me.Rdo21.Checked)

    End Sub
    Private Sub ChangeEnable(ByRef panel As Panel, ByVal isReadOnly As Boolean)

        For Each ctl In panel.Controls

            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).ReadOnly = isReadOnly
                DirectCast(ctl, TextBox).TabStop = Not isReadOnly
            End If

        Next



    End Sub

End Class
