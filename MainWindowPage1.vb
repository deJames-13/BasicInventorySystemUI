
Public Class MainWindowPage1

    ' CREATE REQUEST
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ShowInputForm("Create Item")
    End Sub

    ' READ REQUEST
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If SelectItem() Then
            ShowInputForm("Get Item")
        End If
    End Sub

    ' UPDATE REQUEST
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If SelectItem() Then
            ShowInputForm("Update Item")
        End If
    End Sub

    ' DELETE REQUEST
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dtInvent.SelectedRows.Count > 0 Then
            DeleteItem(dtInvent.SelectedRows(0).Cells(0).Value)
            dtInvent.Rows.Remove(dtInvent.SelectedRows(0))
        Else
            Dim id As String = InputBox("Enter Item ID", "Delete Item")
            If String.IsNullOrEmpty(id) Then
                Return
            End If
            Dim pos As Integer = IndexFromGrid(dtInvent, id)
            If pos < 0 Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
                Return
            End If
            DeleteItem(id)
            dtInvent.Rows.RemoveAt(pos)
        End If
    End Sub

    ' SEARCH ITEM
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, txtSearch.TextChanged
        Dim datas As String() = SearchItems(txtSearch.Text)
        dtInvent.Rows.Clear()
        For row As Integer = dtInvent.RowCount To datas.Count - 1
            Dim item As String() = datas(row).Split("=")(1).Split(",")
            dtInvent.Rows.Add(item)
        Next
    End Sub

    ' NEW INVENTORY
    Private Sub btnNewInvent_Click(sender As Object, e As EventArgs) Handles btnNewInvent.Click
        openFile.InitialDirectory = DB_DIR
        Dim name As String
        If openFile.ShowDialog() = DialogResult.OK Then
            name = openFile.SafeFileName
        Else
            name = InputBox("Enter Inventory Name", "New Inventory")
        End If
        NewInventory(name)
        dtInvent.Rows.Clear()
        ReloadGrid(dtInvent)
        inventName.Text = "Inventory Name: " & DB_FILE.Split("\").Last
    End Sub

    ' LOAD INVENTORY
    Private Sub MainWindowPage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewInventory("")
        ReloadGrid(dtInvent)
        inventName.Text = "Inventory Name: " & DB_FILE.Split("\").Last
    End Sub

    ' SELECT ITEM
    Public Function SelectItem() As Boolean
        If dtInvent.SelectedRows.Count > 0 Then
            currentItemId = dtInvent.SelectedRows(0).Cells(0).Value
        Else
            Dim id As String = InputBox("Enter Item ID", "Get Item")
            If String.IsNullOrEmpty(id) Then
                Return 0
            End If
            itemPos = IndexFromGrid(dtInvent, id)
            If itemPos < 0 Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
                Return 0
            End If
            currentItemId = id
        End If
        SelectedItem = ReadItem(currentItemId)
        Return 1
    End Function


End Class
