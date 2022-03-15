Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Module moduloValidaciones
    Public Function validarLetras(text As String, msj As String)
        For Each letra As Char In text
            If Not Regex.IsMatch(letra, "^[[A-Za-z\s]") Then
                MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return True

            End If
        Next
        Return False
    End Function
    Public Function validarSoloNumeros(text As String, msj As String)
        For Each letra As Char In text
            If Not Regex.IsMatch(letra, "^[0-9]") Then
                MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return True

            End If
        Next
        Return False
    End Function

    Public Function validarAlfanumericos(text As String, msj As String)
        For Each letra As Char In text
            If Not Regex.IsMatch(letra, "^[A-Za-z0-9\s]") Then
                MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return True

            End If
        Next
        Return False
    End Function

    Public Function validarCaracteres(text As String, msj As String) As Double
        For Each letra As Char In text
            If Not Regex.IsMatch(letra, "^[A-Za-z]") Then
                MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
                Exit For

            End If
        Next
        Return False
    End Function

    Public Function validarLargoyEmpty(min As Integer, max As Integer, msj As String, text As String)
        If Len(text) < min Or Len(text) > max Or text = String.Empty Or Mid(text, 1, 1) = " " Then
            MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False
    End Function

    Public Function validarLargoyEmptyNumero(min As Integer, max As Integer, msj As String, text As String)
        If Val(text) < min Or Val(text) > max Or text = String.Empty Or Mid(text, 1, 1) = " " Then
            MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False
    End Function

    Public Function validarRadioButton(radiobtn1 As RadioButton, radiobtn2 As RadioButton)
        If radiobtn1.Checked = False And radiobtn2.Checked = False Then

            MessageBox.Show("No ha seleccionado ninguna opcion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False
    End Function

    Public Function validarEdad(dtpEdad As DateTimePicker)
        If DateAndTime.Today.Year - dtpEdad.Value.Year < 18 Then
            MessageBox.Show("No cumples con los requisitos de edad", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False


    End Function

    Public Function validarDecimals(text As String)
        If Not IsNumeric(text) Then
            MessageBox.Show("Solo puedes ingresar numeros", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True

        End If
        Return False
    End Function

    Public Function validarVacio(msj As String, text As String)
        If text = String.Empty Or Mid(text, 1, 1) = " " Then
            MessageBox.Show(msj, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False
    End Function

End Module
