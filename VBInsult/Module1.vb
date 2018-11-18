Module Module1

    Sub Main()
        'Dichiarazione varaibili
        Dim name As String
        Dim insult As String
        Dim sentence As String
        'Impostazione di colori e titolo della finestra
        Console.Title = "VBInsult"
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.White
        Console.Clear()
        'Introduzione
        Console.WriteLine("VBInsult")
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
