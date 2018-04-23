Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Collections.Generic

Namespace MvcApp_Q367963
	Public Class InMemoryModel
		Private Const DataItemsCount As Integer = 10

		Public Shared Function GetDataTableModel() As DataTable
			Dim dataTable As New DataTable()

			dataTable.Columns.Add("ProductID", GetType(Integer))
			dataTable.Columns.Add("ProductName", GetType(String))

			dataTable.PrimaryKey = New DataColumn() { dataTable.Columns("ProductID") }

			Dim randomizer As New Random()

			For index As Integer = 0 To DataItemsCount - 1
				dataTable.Rows.Add(index, "Name_" & index.ToString())
			Next index

			Return dataTable
		End Function
	End Class
End Namespace

