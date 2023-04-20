Public Class InputForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAll({txtID, txtName, txtPrice, txtQuantity, txtTotal})
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsEmptyInputs({txtID, txtName, txtPrice, txtQuantity}) Then
            Return
        End If
        If Not IsValidNumbers({txtPrice, txtQuantity}) Then
            Return
        End If

        txtTotal.Text = (CDec(txtPrice.Text) * CDec(txtQuantity.Text)).ToString("f2")

        Dim datas As String() = GetInputs({txtID, txtName, txtPrice, txtQuantity, txtTotal})
        If datas Is Nothing Then
            Return
        End If

        Dim item As String = txtID.Text + "=" + ConcatStrings(datas)
        If Me.Text = "Create Item" Then
            CreateItem(item + vbCrLf)
        ElseIf Me.Text = "Update Item" Then
            UpdateItem(currentItemId, item)
            MainWindowPage1.dtInvent.Rows.RemoveAt(itemPos)
            MainWindowPage1.dtInvent.Rows.Insert(itemPos)

        End If

        ReloadGrid(MainWindowPage1.dtInvent)
        ClearAll({txtID, txtName, txtPrice, txtQuantity, txtTotal})
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub InputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim texts As TextBox() = {txtID, txtName, txtPrice, txtQuantity, txtTotal}
        ToggleInputs({txtID, txtName, txtPrice, txtQuantity}, True)
        btnSave.Visible = True
        txtID.Focus()

        If Me.Text = "Update Item" Then
            Dim item As String() = SelectedItem.Split(",")
            txtName.Focus()
            labelTitle.Text = "Item ID: " & item(0)
            ShowData(item, texts)
            txtID.Enabled = False

        ElseIf Me.Text = "Get Item" Then
            Dim item As String() = SelectedItem.Split(",")

            labelTitle.Text = "Item ID: " & item(0)
            btnSave.Visible = False
            ShowData(item, texts)
            ToggleInputs({txtID, txtName, txtPrice, txtQuantity}, False)
        End If
    End Sub

    Public Sub ShowData(data As String(), texts As TextBox())
        For i As Integer = 0 To texts.Length - 1
            texts(i).Text = data(i)
        Next
    End Sub
    Public Sub ToggleInputs(texts As TextBox(), state As Boolean)
        For Each t In texts
            t.Enabled = state
        Next
    End Sub

End Class