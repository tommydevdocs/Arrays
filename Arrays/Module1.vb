Module Module1

    Sub Main()
        'Dim numbers(0 To 4) As Integer
        'Dim numbers(4) As Integer
        'numbers(0) = 4
        'numbers(1) = 8
        'numbers(2) = 15
        'numbers(3) = 16
        'numbers(4) = 23

        'Dim numbers() As Integer = {4, 8, 15, 16, 23}

        'Console.WriteLine("The third element of the array contains: " & numbers(2))
        'Console.WriteLine("Iterating through the entire array: " & numbers(2))

        'For index = 0 To numbers.Length - 1
        '    Console.WriteLine(numbers(index))
        'Next
        'Console.ReadLine()

        'Dim names() As String = {"Bob", "Steve", "Aaron", "Thomas"}
        'For Each name As String In names
        '    Console.WriteLine(name)

        'Next
        'Console.ReadLine()

        Dim myText As String = "Now is the time for all good men to come to the aid of their country."

        Dim charArray() As Char = myText.ToCharArray()
        Array.Reverse(charArray)
        For Each myChar As Char In charArray
            Console.WriteLine(myChar)
        Next
        Console.ReadLine()
    End Sub

End Module
