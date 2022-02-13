Module VaciarTextbox
    Public Sub BorrarTextBoxForm(Form As Form)
        For Each obj As Control In Form.Controls
            If TypeOf obj Is TextBox Then
                Dim txttemp As TextBox = CType(obj, TextBox)
                txttemp.Text = ""
            End If
        Next
    End Sub

End Module
