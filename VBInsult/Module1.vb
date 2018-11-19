Module Module1

    Sub Main()
        'Dichiarazione varaibili
        Dim name As String
        Dim insult As String
        Dim sentence As String
        Dim background As String
        Dim foreground As String
        'Impostazione del titolo della finestra
        Console.Title = "VBInsult v1.0.1"
        'Selezione del colore di sfondo
        Console.WriteLine("Seleziona il colore di sfondo:")
        Console.WriteLine("")
        Console.WriteLine("1) Nero")
        Console.WriteLine("2) Blu")
        Console.WriteLine("3) Ciano")
        Console.WriteLine("4) Blu scuro")
        Console.WriteLine("5) Ciano scuro")
        Console.WriteLine("6) Grigio scuro")
        Console.WriteLine("7) Verde scuro")
        Console.WriteLine("8) Magenta scuro")
        Console.WriteLine("9) Rosso scuro")
        Console.WriteLine("10) Giallo scuro")
        Console.WriteLine("11) Grigio")
        Console.WriteLine("12) Verde")
        Console.WriteLine("13) Magenta")
        Console.WriteLine("14) Rosso")
        Console.WriteLine("15) Bianco")
        Console.WriteLine("16) Giallo")
        background = Console.ReadLine()
        Select Case background
            Case 1
                Console.BackgroundColor = ConsoleColor.Black
            Case 2
                Console.BackgroundColor = ConsoleColor.Blue
            Case 3
                Console.BackgroundColor = ConsoleColor.Cyan
            Case 4
                Console.BackgroundColor = ConsoleColor.DarkBlue
            Case 5
                Console.BackgroundColor = ConsoleColor.DarkCyan
            Case 6
                Console.BackgroundColor = ConsoleColor.DarkGray
            Case 7
                Console.BackgroundColor = ConsoleColor.DarkGreen
            Case 8
                Console.BackgroundColor = ConsoleColor.DarkMagenta
            Case 9
                Console.BackgroundColor = ConsoleColor.DarkRed
            Case 10
                Console.BackgroundColor = ConsoleColor.DarkYellow
            Case 11
                Console.BackgroundColor = ConsoleColor.Gray
            Case 12
                Console.BackgroundColor = ConsoleColor.Green
            Case 13
                Console.BackgroundColor = ConsoleColor.Magenta
            Case 14
                Console.BackgroundColor = ConsoleColor.Red
            Case 15
                Console.BackgroundColor = ConsoleColor.White
            Case 16
                Console.BackgroundColor = ConsoleColor.Yellow
        End Select
        Console.Clear()
        'Selezione del colore del testo
        Console.WriteLine("Seleziona il colore del testo:")
        Console.WriteLine("")
        Console.WriteLine("1) Nero")
        Console.WriteLine("2) Blu")
        Console.WriteLine("3) Ciano")
        Console.WriteLine("4) Blu scuro")
        Console.WriteLine("5) Ciano scuro")
        Console.WriteLine("6) Grigio scuro")
        Console.WriteLine("7) Verde scuro")
        Console.WriteLine("8) Magenta scuro")
        Console.WriteLine("9) Rosso scuro")
        Console.WriteLine("10) Giallo scuro")
        Console.WriteLine("11) Grigio")
        Console.WriteLine("12) Verde")
        Console.WriteLine("13) Magenta")
        Console.WriteLine("14) Rosso")
        Console.WriteLine("15) Bianco")
        Console.WriteLine("16) Giallo")
        foreground = Console.ReadLine()
        Select Case foreground
            Case 1
                Console.ForegroundColor = ConsoleColor.Black
            Case 2
                Console.ForegroundColor = ConsoleColor.Blue
            Case 3
                Console.ForegroundColor = ConsoleColor.Cyan
            Case 4
                Console.ForegroundColor = ConsoleColor.DarkBlue
            Case 5
                Console.ForegroundColor = ConsoleColor.DarkCyan
            Case 6
                Console.ForegroundColor = ConsoleColor.DarkGray
            Case 7
                Console.ForegroundColor = ConsoleColor.DarkGreen
            Case 8
                Console.ForegroundColor = ConsoleColor.DarkMagenta
            Case 9
                Console.ForegroundColor = ConsoleColor.DarkRed
            Case 10
                Console.ForegroundColor = ConsoleColor.DarkYellow
            Case 11
                Console.ForegroundColor = ConsoleColor.Gray
            Case 12
                Console.ForegroundColor = ConsoleColor.Green
            Case 13
                Console.ForegroundColor = ConsoleColor.Magenta
            Case 14
                Console.ForegroundColor = ConsoleColor.Red
            Case 15
                Console.ForegroundColor = ConsoleColor.White
            Case 16
                Console.ForegroundColor = ConsoleColor.Yellow
        End Select
        Console.Clear()
        'Introduzione
        Console.WriteLine("VBInsult - Versione 1.0.1")
        Console.WriteLine("Insulta chi vuoi con stile, in Visual Basic")
        Console.WriteLine("")
        Console.WriteLine("Premi un tasto (non quello di spegnimento) per continuare")
        Console.ReadKey()
        'Lettura del nome
        Console.Clear()
        Console.WriteLine("Perfetto, iniziamo.")
        Console.WriteLine("Come si chiama la persona che vuoi insultare?")
        name = Console.ReadLine()
        'Lettura dell'insulto
        Console.WriteLine("")
        Console.WriteLine("Come vuoi insultare " & name & "?")
        insult = Console.ReadLine()
        'Creazione dell'insulto
        sentence = (name & " è " & insult & "!")
        'Visualizzazione dell'insulto
        Console.WriteLine("")
        Console.WriteLine(sentence)
        Console.ReadKey()

    End Sub

End Module
