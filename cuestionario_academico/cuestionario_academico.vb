Imports System
Module cuestionario_academico
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim preguntas(9) As String
        Dim opcionA(9) As String
        Dim opcionB(9) As String
        Dim opcionC(9) As String
        Dim opcionD(9) As String
        Dim respuestasCorrectas(9) As String
        Dim respuestasEstudiante(9) As String
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '----------------------------------------------'
        '--|menu_principal_de_cuestionario_academico|--'
        '----------------------------------------------'
        Do
            Console.WriteLine("menu principal de cuestionario academico")
            Console.WriteLine("1) Registrar pregunta")
            Console.WriteLine("2) Editar pregunta")
            Console.WriteLine("3) Listar preguntas")
            Console.WriteLine("4) Buscar pregunta")
            Console.WriteLine("5) Eliminar pregunta")
            Console.WriteLine("6) Resolver cuestionario")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '------------------------'
                '--|registrar_pregunta|--'
                '------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas preguntas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Ingrese la pregunta: ")
                        preguntas(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion A: ")
                        opcionA(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion B: ")
                        opcionB(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion C: ")
                        opcionC(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion D: ")
                        opcionD(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la respuesta correcta (A, B, C o D): ")
                        respuestasCorrectas(cantidad) = Console.ReadLine().ToUpper()
                        If respuestasCorrectas(cantidad) = "A" OrElse respuestasCorrectas(cantidad) = "B" OrElse respuestasCorrectas(cantidad) = "C" OrElse respuestasCorrectas(cantidad) = "D" Then
                            respuestasEstudiante(cantidad) = ""
                            estados(cantidad) = "Sin resolver"
                            cantidad += 1
                            Console.WriteLine("Pregunta registrada correctamente.")
                            Console.WriteLine("ID: " & ids(cantidad - 1) & " | Pregunta: " & preguntas(cantidad - 1) & " | A: " & opcionA(cantidad - 1) & " | B: " & opcionB(cantidad - 1) & " | C: " & opcionC(cantidad - 1) & " | D: " & opcionD(cantidad - 1) & " | Correcta: " & respuestasCorrectas(cantidad - 1))
                        Else
                            Console.WriteLine("La respuesta correcta debe ser A, B, C o D.")
                        End If
                    End If
                '---------------------'
                '--|editar_pregunta|--'
                '---------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i))
                        Next
                        Console.Write("Ingrese el ID de la pregunta a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nueva pregunta: ")
                            preguntas(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion A: ")
                            opcionA(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion B: ")
                            opcionB(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion C: ")
                            opcionC(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion D: ")
                            opcionD(posicion) = Console.ReadLine()
                            Console.Write("Nueva respuesta correcta (A, B, C o D): ")
                            Dim nuevaRespuesta As String = Console.ReadLine().ToUpper()
                            If nuevaRespuesta = "A" OrElse nuevaRespuesta = "B" OrElse nuevaRespuesta = "C" OrElse nuevaRespuesta = "D" Then
                                respuestasCorrectas(posicion) = nuevaRespuesta
                                respuestasEstudiante(posicion) = ""
                                estados(posicion) = "Sin resolver"
                                Console.WriteLine("Pregunta actualizada correctamente.")
                                Console.WriteLine("ID: " & ids(posicion) & " | Pregunta: " & preguntas(posicion) & " | A: " & opcionA(posicion) & " | B: " & opcionB(posicion) & " | C: " & opcionC(posicion) & " | D: " & opcionD(posicion) & " | Correcta: " & respuestasCorrectas(posicion))
                            Else
                                Console.WriteLine("La respuesta correcta debe ser A, B, C o D.")
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|listar_preguntas|--'
                '----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i) & " | Respuesta estudiante: " & respuestasEstudiante(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '---------------------'
                '--|buscar_pregunta|--'
                '---------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por pregunta")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID de la pregunta: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Pregunta: " & preguntas(posicion) & " | A: " & opcionA(posicion) & " | B: " & opcionB(posicion) & " | C: " & opcionC(posicion) & " | D: " & opcionD(posicion) & " | Correcta: " & respuestasCorrectas(posicion) & " | Respuesta estudiante: " & respuestasEstudiante(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el texto de la pregunta: ")
                            Dim preguntaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If preguntas(i).ToLower().Contains(preguntaBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i) & " | Respuesta estudiante: " & respuestasEstudiante(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron preguntas.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '-----------------------'
                '--|eliminar_pregunta|--'
                '-----------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i))
                        Next
                        Console.Write("Ingrese el ID de la pregunta a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                preguntas(i) = preguntas(i + 1)
                                opcionA(i) = opcionA(i + 1)
                                opcionB(i) = opcionB(i + 1)
                                opcionC(i) = opcionC(i + 1)
                                opcionD(i) = opcionD(i + 1)
                                respuestasCorrectas(i) = respuestasCorrectas(i + 1)
                                respuestasEstudiante(i) = respuestasEstudiante(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            preguntas(cantidad) = ""
                            opcionA(cantidad) = ""
                            opcionB(cantidad) = ""
                            opcionC(cantidad) = ""
                            opcionD(cantidad) = ""
                            respuestasCorrectas(cantidad) = ""
                            respuestasEstudiante(cantidad) = ""
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Pregunta eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------------'
                '--|resolver_cuestionario|--'
                '---------------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas para resolver.")
                    Else
                        Dim correctas As Integer = 0
                        Dim incorrectas As Integer = 0
                        Console.WriteLine("INICIO DEL CUESTIONARIO ACADEMICO")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine()
                            Console.WriteLine("PREGUNTA " & (i + 1))
                            Console.WriteLine(preguntas(i))
                            Console.WriteLine("A) " & opcionA(i))
                            Console.WriteLine("B) " & opcionB(i))
                            Console.WriteLine("C) " & opcionC(i))
                            Console.WriteLine("D) " & opcionD(i))
                            Console.Write("Seleccione su respuesta: ")
                            respuestasEstudiante(i) = Console.ReadLine().ToUpper()
                            If respuestasEstudiante(i) = respuestasCorrectas(i) Then
                                estados(i) = "Correcta"
                                correctas += 1
                            Else
                                estados(i) = "Incorrecta"
                                incorrectas += 1
                            End If
                            Console.WriteLine("Respuesta: " & respuestasEstudiante(i) & " | Correcta: " & respuestasCorrectas(i) & " | Estado: " & estados(i))
                        Next
                        Dim porcentaje As Double = (correctas * 100.0) / cantidad
                        Dim calificacion As Double = (correctas * 5.0) / cantidad
                        Console.WriteLine()
                        Console.WriteLine("RESULTADO DEL CUESTIONARIO")
                        Console.WriteLine("Preguntas: " & cantidad & " | Correctas: " & correctas & " | Incorrectas: " & incorrectas & " | Porcentaje: " & porcentaje.ToString("0.00") & "% | Calificacion: " & calificacion.ToString("0.00"))
                        If calificacion >= 3.0 Then
                            Console.WriteLine("Resultado: Aprobado")
                        Else
                            Console.WriteLine("Resultado: Reprobado")
                        End If
                        Console.WriteLine()
                        Console.WriteLine("DETALLE DE RESPUESTAS")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | Respuesta: " & respuestasEstudiante(i) & " | Correcta: " & respuestasCorrectas(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Cuestionario Academico.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module