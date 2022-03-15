Module VaciarTextbox
    Public Sub BorrarTextBoxForm(Form As Form)
        For Each obj As Control In Form.Controls
            If TypeOf obj Is TextBox Then
                Dim txtTemp As TextBox = CType(obj, TextBox)
                txtTemp.Text = ""
            End If
        Next
    End Sub

End Module
