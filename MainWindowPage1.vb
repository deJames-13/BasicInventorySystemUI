
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

        Dim id As String
        Dim pos As Integer

        If dtInvent.SelectedRows.Count > 0 Then
            id = dtInvent.SelectedRows(0).Cells(0).Value
            pos = dtInvent.SelectedRows(0).Index
        Else
            id = InputBox("Enter Item ID", "Delete Item")
            If String.IsNullOrEmpty(id) Then
                Return
            End If
            pos = IndexFromGrid(dtInvent, id)
            If pos < 0 Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
                Return
            End If
        End If

        ' Confirm Delete
        Dim m As Integer = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo, "Confirm Delete")
        If m = MsgBoxResult.No Then
            Return
        End If

        DeleteItem(id)
        dtInvent.Rows.RemoveAt(pos)
    End Sub

    ' SEARCH ITEM
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click ', txtSearch.TextChanged ' (enabling this will make the search button obsolete)
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

    ' HANDLE SELECT
    Private Sub dtInvent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtInvent.CellClick
        If dtInvent.SelectedCells.Count >= 0 Then
            dtInvent.Rows(dtInvent.SelectedCells(0).RowIndex).Selected = True
        End If
    End Sub
End Class
