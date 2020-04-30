Module Module1
    Sub main()
        'Mostramos el mensaje en Consola

        'Declaracion de Array

        Dim miVariariable1 As String = "Hola Mundo"
        Console.WriteLine(miVariariable1)
        'Console.ReadKey()

        Dim miArray01() As String = {"Antonio", "Ines", "Franciso"}
        'Mostrar el Valor en la Consola
        Console.WriteLine(miArray01(1))   'Ines
        Console.Read()

        Dim miArray02(2) As String
        miArray02(0) = "Antonio"
        miArray02(1) = "Ines"
        miArray02(2) = "Franciso"
        Console.WriteLine(miArray01(0))   'Antonio

        ReDim miArray02(1) 'Se borra todo el contenido de la Tabla
        ReDim Preserve miArray02(1)  'Crea el Array pero mantiene los elementos


        Dim miArray03(2, 2) As String
        miArray03(0, 0) = "Antonio" : miArray03(0, 1) = "Pervy" : miArray03(0, 2) = "Wilder"
        miArray03(1, 0) = "Ana    " : miArray03(1, 1) = "Melva" : miArray03(1, 2) = "Rosa  "
        miArray03(2, 0) = "Arturo " : miArray03(2, 1) = "Mabel" : miArray03(2, 2) = "Yalu  "

        Console.WriteLine(miArray03(2, 0) & " " & miArray03(2, 1) & " " & miArray03(2, 2))
        Console.Read()

    End Sub
End Module
