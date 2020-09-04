'Ian Gunter
'RCET 0265
'Fall 2020
'BetterCalculator



Option Explicit On
Option Strict On
Option Compare Text
Module BetterCalculator

    Sub Main()
        Dim userInput, userInput2, userResponse As String
        Dim firstNumber, secondNumber, thirdNumber, fourthNumber As Integer
        Dim goodData As Boolean

        'Do loops restarts the program when it is finished.
        Do
            Do
                'Do loops Re-asks the question if input is bad data.
                Do

                    Console.WriteLine("Please enter 2 numbers. Enter Q at any time to quit")

                    'Try catch catches bad data and performs a do loop.
                    Try

                        userInput = Console.ReadLine()

                        If userInput = "Q" Then
                            Console.WriteLine("Have a nice day!")
                            Console.WriteLine("Press enter to close this window.")
                            Console.ReadLine()
                            Exit Sub
                        End If
                        'CInt converts string to Decimal.
                        firstNumber = CInt(userInput)
                        Console.WriteLine("You Entered " & firstNumber)



                        goodData = True
                    Catch
                        goodData = False
                        Console.WriteLine("You entered " & userInput & ". Please enter a whole number.")

                    End Try

                Loop Until goodData = True

                Try



                    'CInt converts string to Decimal.

                    Console.WriteLine("Choose another number.")

                    userInput2 = Console.ReadLine()
                    If userInput2 = "Q" Then
                        Console.WriteLine("Have a nice day!")
                        Console.WriteLine("Press enter to close this window.")
                        Console.ReadLine()
                        Exit Sub
                    End If
                    secondNumber = CInt(userInput2)


                    goodData = True
                    Console.WriteLine("You entered " & secondNumber)
                    Console.ReadLine()
                Catch
                    goodData = False
                    Console.WriteLine("You entered " & userInput2 & ". Please enter a whole number.")

                End Try

            Loop Until goodData = True

            'Do loop loops this section if the input is bad.
            Do
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                userResponse = Console.ReadLine()

                'If statement chooses different events based upon user response.
                If userResponse = "1" Then
                    Console.WriteLine("Your answer: " & firstNumber + secondNumber)
                    Console.ReadLine()

                ElseIf userResponse = "Q" Then
                    Console.WriteLine("Have a nice day!")
                    Console.WriteLine("Press enter to close this window.")
                    Console.ReadLine()
                    Exit Sub

                ElseIf userResponse = "2" Then
                    Console.WriteLine("Your answer: " & firstNumber - secondNumber)
                    Console.ReadLine()

                ElseIf userResponse = "3" Then
                    Console.WriteLine("Your answer: " & firstNumber * secondNumber)
                    Console.ReadLine()

                ElseIf userResponse = "4" Then
                    Console.WriteLine("Your answer: " & firstNumber / secondNumber)
                    Console.ReadLine()

                ElseIf userResponse <> "1" And userResponse <> "2" And userResponse <> "3" And userResponse <> "4" And userResponse <> "Q" Then
                    Console.WriteLine("Human Error... Uhh try again....")
                    Console.ReadLine()


                End If

            Loop Until userResponse = "1" Or userResponse = "2" Or userResponse = "3" Or userResponse = "4"

            'Console.clear will clear the the console.
            Console.Clear()

        Loop Until userInput = "Q"

    End Sub

End Module



