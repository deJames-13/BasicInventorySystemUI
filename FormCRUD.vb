Imports System.IO
Module FormCRUD
    ' CREATE ITEM
    Public Sub CreateItem(item As String)
        If Not String.IsNullOrEmpty(item) Then
            File.AppendAllText(DB_FILE, item)
        End If
    End Sub

    ' READ ITEMS
    Public Function ReadItems() As String()
        Return File.ReadAllLines(DB_FILE)
    End Function

    ' READ ITEM
    Public Function ReadItem(id As String) As String
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return ""
        End If

        Dim datas As String() = ReadItems()
        Dim i As Integer = 0
        Dim item As String = ""

        While i < datas.Length
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then
                item = datas(i).Split("=")(1)
                Return item
            End If
            i += 1
        End While
        Return item
    End Function

    ' UPDATE ITEM
    Public Sub UpdateItem(id As String, text As String)
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return
        End If

        Dim datas As ArrayList = New ArrayList(ReadItems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then

                datas(i) = text
                Dim new_datas As String() = datas.ToArray(GetType(String))
                File.WriteAllLines(DB_FILE, new_datas)

                Return
            End If
            i += 1
        End While

    End Sub

    ' DELETE ITEM
    Public Sub DeleteItem(id As String)
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return
        End If

        Dim datas As ArrayList = New ArrayList(ReadItems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then

                datas.RemoveAt(i)
                Dim new_datas As String() = datas.ToArray(GetType(String))
                File.WriteAllLines(DB_FILE, new_datas)

                Return
            End If
            i += 1
        End While


    End Sub


    ' SEARCH ITEMS
    Public Function SearchItems(keyword As String) As String()
        If String.IsNullOrEmpty(keyword) Then
            Return ReadItems()
        End If
        Dim datas As String() = ReadItems()
        Dim items As ArrayList = New ArrayList()
        For i As Integer = 0 To datas.Length - 1
            Dim item As String = datas(i).Split("=")(1)
            If item.Contains(keyword.Trim) Then
                items.Add(datas(i))
            End If
        Next
        Return items.ToArray(GetType(String))
    End Function

    ' LOAD INVENTORY to GRID
    Public Sub ReloadGrid(ByRef grid As DataGridView)
        Dim datas As String() = ReadItems()
        If Not datas.Length - grid.RowCount = 1 Then
            grid.Rows.Clear()
        End If
        For row As Integer = grid.RowCount To datas.Count - 1
            Dim item As String() = datas(row).Split("=")(1).Split(",")
            grid.Rows.Add(item)
        Next
    End Sub

End Module
