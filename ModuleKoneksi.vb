Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet
	Public Cmd As SqlCommand

	Sub Konek()
		Try
			Conn = New SqlConnection("Data Source")
		Catch ex As Exception

		End Try
	End Sub


End Module
