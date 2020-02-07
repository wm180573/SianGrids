Module Module1

    Sub Main()
        ' For each record in x (there are 4) run the loop
        For x = 1 To 4
            ' For each record in y (there are 3) run the loop
            For y = 1 To 3
                ' Output x= the value of x variable + y= the value of y variable
                ' Also convert x and y to string so that they can be concatenated to a string
                Console.WriteLine("x=" + Convert.ToString(x) + "y=" + (Convert.ToString(y)))
                ' Do for each y
            Next y
            ' Do for each x
        Next x
        ' Keep program open for the user to read the output until they press a button
        Console.ReadKey()
    End Sub

End Module
