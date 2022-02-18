'Carson Bogart
'RCET 0265
'Spring 22
'ConvertAndValidate
'


Option Explicit On
Option Strict On
Module ConvertAndValidate

    Sub Main()
        'for testing the function add this to your Sub Main()
        Dim userResponse As String
        Dim aValidNumber As Integer
        Do
            Console.WriteLine($"Enter a number:")
            userResponse = Console.ReadLine()
            If ConversionValid(userResponse, CBool(aValidNumber)) = True Then
                Console.WriteLine($"{userResponse} converted successfully to {userResponse}!")
            Else
                Console.WriteLine($"Oops, {userResponse} does not seem to be a number")
            End If
        Loop
    End Sub
    Function ConversionValid(convertThisString As String, toThisInteger As Boolean) As Boolean
        Dim status As Boolean
        Try
            Convert.ToInt32(convertThisString)
            status = True
        Catch ex As Exception
        End Try
        Return status
    End Function

End Module
