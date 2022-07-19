////////using System;

////////namespace Library
////////{
////////    class Program
////////    {
////////        static void Main(string[] args)
////////        {
////////            LibraryService libraryService = new LibraryService();
////////            Console.ForegroundColor = ConsoleColor.Green;
////////            Console.WriteLine("Select one option");
////////            Console.WriteLine("1 - Creat library, 2 - Get library by id, 3 - Update library, 4 - Delete library");

////////            while (true)
////////            {
////////            SelectOption: string selectOption = Console.ReadLine();

////////                int selectTrueOption;

////////                bool isSelectOption = int.TryParse(selectOption, out selectTrueOption);

////////                if (isSelectOption)
////////                {
////////                    switch (selectTrueOption)
////////                    {
////////                        case 1:

////////                            Console.ForegroundColor = ConsoleColor.Red;
////////                            Console.WriteLine("Add library name: ");
////////                        SeatCount: string libraryName = Console.ReadLine();
////////                            Console.ForegroundColor = ConsoleColor.Red;
////////                            Console.WriteLine("Add library seat count: ");

////////                            string librarySeatCount = Console.ReadLine();
////////                            int seatCount;
////////                            bool isSeatCount = int.TryParse(librarySeatCount, out seatCount);

////////                            if (isSeatCount)
////////                            {
////////                                Library library = new Library
////////                                {
////////                                    Name = libraryName,
////////                                    SeatCount = seatCount
////////                                };
////////                                var result = libraryService.Create(library);
////////                                Console.ForegroundColor = ConsoleColor.White;
////////                  Console.WriteLine($"Library id : {result.Id}, Library name : {result.Name}, Seat count {result.SeatCount} ");
////////                            }
////////                            else
////////                            {
////////                                Console.ForegroundColor = ConsoleColor.Red;
////////                                Console.WriteLine("Add library seat count: ");
////////                                goto SeatCount;
////////                            }


////////                            break;
////////                        case 2:
////////                            Console.WriteLine(selectTrueOption);
////////                            break;
////////                        case 3:
////////                            Console.WriteLine(selectTrueOption);
////////                            break;
////////                        case 4:
////////                            Console.WriteLine(selectTrueOption);
////////                            break;

////////                        default:
////////                            Console.WriteLine("Select corret option number");
////////                            break;
////////                    }

////////                }
////////                else
////////                {
////////                    Console.ForegroundColor = ConsoleColor.Green;
////////                    Console.WriteLine("Select correct option");
////////                    goto SelectOption;
////////                }
////////            }
////////        }
////////    }
////////}