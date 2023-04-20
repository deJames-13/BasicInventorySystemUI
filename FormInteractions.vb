Imports System.IO
Module FormInteractions
    Public DB_DIR As String = CurDir.Replace("bin\Debug\net6.0-windows", "Inventories\")
    Public DB_DEFAULT As String = DB_DIR + "InventoryDEFAULT.txt"
    Public DB_FILE As String = DB_DEFAULT

    Public itemPos As Integer
    Public currentItemId As String
    Public SelectedItem As String

    Public Sub NewInventory(name As String)
        If String.IsNullOrEmpty(name) Then
            name = DB_DEFAULT
        Else
            name = DB_DIR + name
        End If
        If Not name.EndsWith(".txt") Then
            name += ".txt"
        End If

        If Not File.Exists(name) Then
            File.Create(name).Dispose()
            MsgBox("File Created Successfully", MsgBoxStyle.Information, "Success")
        End If
        DB_FILE = name
    End Sub

    Public Sub ShowInputForm(title As String)
        Dim form As InputForm = InputForm
        form.Text = title
        form.labelTitle.Text = title
        form.ShowDialog()
    End Sub

    Public Function IndexFromGrid(grid As DataGridView, id As Integer) As Integer
        Dim i = 0
        While i < grid.Rows.Count
            If grid.Rows(i).Cells(0).Value = id Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    ' INPUT MANAGEMENT
    Public Sub ClearAll(inputs As TextBox())
        For Each t In inputs
            t.Clear()
        Next
    End Sub

    Public Function ConcatStrings(str As String()) As String
        Dim result As String = ""
        For Each s In str
            result += s + ","
        Next
        Return result.Remove(result.Length - 1)
    End Function

    Public Function GetInputs(ByRef inputs As TextBox()) As String()
        Dim datas As New ArrayList

        For Each t In inputs
            datas.Add(t.Text)
        Next
        Return datas.ToArray(GetType(String))
    End Function

    ' INPUT VALIDATION
    Public Function IsEmptyInputs(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If String.IsNullOrEmpty(t.Text) Then
                Dim msg As String = "Found missing value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Please fill all the fields")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsValidNumbers(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If Not IsNumeric(t.Text) Then
                Dim msg As String = "Found invalid value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Invalid Value")
                t.Focus()
                Return False
            End If
        Next
        Return True
    End Function

End Module
