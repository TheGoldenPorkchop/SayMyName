'Angel Nava
'Spring 2025
'RCET2265
'SayMyName
'https://github.com/TheGoldenPorkchop/SayMyName

Module SayMyName

    Sub Main()
        Dim userName As String

        Console.WriteLine("Give me your name: ")
        userName = Console.ReadLine()

        If userName = "Tim" Then
            Console.WriteLine("You should give me extra credit for remembering your name")
        ElseIf userName = "Angel" Then
            Console.WriteLine("Woah, that's the programmer")
        ElseIf userName = "1" Then
            Console.WriteLine("haha, 1")
        Else
            Console.WriteLine(vbNewLine & "Hello, " & userName)
        End If

    End Sub

End Module
