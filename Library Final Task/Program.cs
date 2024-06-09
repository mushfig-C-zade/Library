
using Library_Final_Task.Exceptions;
using Library_Final_Task.Model;
using Library_Final_Task.Model.Managers;
using System.Text.RegularExpressions;
int numx = 0;
char[] arr = { '>', ' ', ' ', ' ', ' ' };

void Swap(ref char sym1, ref char sym2) =>
    (sym1, sym2) = (sym2, sym1);



do
{
    Console.WriteLine("=== Center Library System ===");
    Console.WriteLine($"{arr[0]} Reader");
    Console.WriteLine($"{arr[1]} Books");
    Console.WriteLine($"{arr[2]} Give the Reader a book");
    Console.WriteLine($"{arr[3]} Book Search ");
    Console.WriteLine($"{arr[4]} Reader Search");
    Library library = new Library();
    ReaderBook readerBook = new ReaderBook();
    BookManager bookManager = new BookManager();
    Archive archive = new Archive();
    int duration = 0;


    var keyInfo = Console.ReadKey();

    Console.Clear();

    if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        if (numx < 4)
            Swap(ref arr[numx], ref arr[++numx]);
    }
    else if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        if (numx > 0)
            Swap(ref arr[numx], ref arr[--numx]);
    }
    else if (keyInfo.Key == ConsoleKey.Enter)
    {
        switch (numx)
        {
            case 0:
                Console.Clear();
                int numx1 = 0;
                char[] arr1 = { '>', ' ', ' ', ' ' };
                bool returnBack = true;
                do
                {
                    Console.WriteLine($"{arr1[0]} Add to new Reader");
                    Console.WriteLine($"{arr1[1]} Remove to current Reader");
                    Console.WriteLine($"{arr1[2]} Look at all Readers");
                    Console.WriteLine($"{arr1[3]} Back");

                    var keyInfo1 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo1.Key == ConsoleKey.DownArrow)
                    {
                        if (numx1 < 3)
                            Swap(ref arr1[numx1], ref arr1[++numx1]);
                    }
                    else if (keyInfo1.Key == ConsoleKey.UpArrow)
                    {
                        if (numx1 > 0)
                            Swap(ref arr1[numx1], ref arr1[--numx1]);
                    }
                    else if (keyInfo1.Key == ConsoleKey.Enter)
                    {
                        switch (numx1)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("Yeni Istifadeci qeydiyyatı  Zehmet olmasa melumatlari daxil edin");

                                try
                                {
                                    Console.WriteLine("Name: ");
                                    string name = Console.ReadLine();
                                    if (string.IsNullOrEmpty(name))
                                        throw new NameEmptyException();

                                    Console.WriteLine("Surname: ");
                                    string surName = Console.ReadLine();
                                    if (string.IsNullOrEmpty(surName))
                                        throw new SurNameEmptyException();

                                    Console.WriteLine("Age: ");
                                    int age = int.Parse(Console.ReadLine());
                                    if (age < 16)
                                        throw new AgeOlderThanSixteenException();

                                    Console.WriteLine("Phone Number: ");
                                    string phoneNumber = Console.ReadLine();
                                    if (string.IsNullOrEmpty(phoneNumber))
                                        throw new PhoneNumberEmptyException();

                                    Console.WriteLine("Mail: ");
                                    string mail = Console.ReadLine();
                                    if (string.IsNullOrEmpty(mail))
                                        throw new MailEmptyException();   
                                     
                                    if (!bookManager.IsValidEmail(mail))
                                    throw new MailDifferentFromCorrectSchemeException();                            
                                    Console.WriteLine("Home Addres: ");
                                    string homeAddress = Console.ReadLine();
                                    if (string.IsNullOrEmpty(homeAddress))
                                        throw new HomeAddressEmptyException();

                                    Reader reader = new Reader(name, surName, age, phoneNumber, mail, homeAddress);                                   
                                    library.AddReader(reader);
                                }
                                catch (NameEmptyException ex) { Console.WriteLine(ex.Message); }
                                catch (SurNameEmptyException ex) { Console.WriteLine(ex.Message); }
                                catch (AgeOlderThanSixteenException ex) { Console.WriteLine(ex.Message); }
                                catch (PhoneNumberEmptyException ex) { Console.WriteLine(ex.Message); }
                                catch (MailEmptyException ex) { Console.WriteLine(ex.Message); }
                                catch (HomeAddressEmptyException ex) { Console.WriteLine(ex.Message); }
                                catch(MailDifferentFromCorrectSchemeException ex) { Console.WriteLine(ex.Message); }
                                Thread.Sleep(1000);
                                break;
                            case 1:
                                string id;
                                Console.WriteLine("For Back Write 'Break' in ID");
                                do
                                {
                                    Console.WriteLine("Include Reader Id");
                                    id = Console.ReadLine();                                    
                                    library.RemoveByIdFromReader(id);
                                } while (id != "Break");
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Butun Oxucularin Siyahisi");
                                library.ShowAllReader();
                                Thread.Sleep(2000);
                                break;
                            case 3:
                                returnBack = false;
                                break;
                        }
                    }

                } while (returnBack);
                break;
            case 1:
                Console.Clear();
                int numx2 = 0;
                char[] arr2 = { '>', ' ', ' ', ' ', ' ', ' ', ' ' };
                bool returnBack1 = true;
                do
                {
                    Console.WriteLine($"{arr2[0]} Add to new book to Library");
                    Console.WriteLine($"{arr2[1]} Remove to book from Library");
                    Console.WriteLine($"{arr2[2]} Add to new book to Archive");
                    Console.WriteLine($"{arr2[3]} Remove to book from Archive");
                    Console.WriteLine($"{arr2[4]} Look at all Books In Library");
                    Console.WriteLine($"{arr2[5]} Look at all Books In Archive");
                    Console.WriteLine($"{arr2[6]} Back");

                    var keyInfo2 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo2.Key == ConsoleKey.DownArrow)
                    {
                        if (numx2 < 6)
                            Swap(ref arr2[numx2], ref arr2[++numx2]);
                    }
                    else if (keyInfo2.Key == ConsoleKey.UpArrow)
                    {
                        if (numx2 > 0)
                            Swap(ref arr2[numx2], ref arr2[--numx2]);
                    }
                    else if (keyInfo2.Key == ConsoleKey.Enter)
                    {
                        switch (numx2)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("Yeni Kitab qeydiyyatı  Zehmet olmasa melumatlari daxil edin");
                                try
                                {
                                    Console.WriteLine("Name: ");
                                    string name = Console.ReadLine();
                                    if (string.IsNullOrEmpty(name))
                                    {
                                        throw new NameEmptyException();
                                    }
                                    Console.WriteLine("Author: ");
                                    string author = Console.ReadLine();
                                    if (string.IsNullOrEmpty(author))
                                    {
                                        throw new AuthorEmptyException();
                                    }
                                    Console.WriteLine("Isbn: ");
                                    string isbns = Console.ReadLine();
                                    int isbn = default;
                                    if (!int.TryParse(isbns, out isbn) || isbns.Length != 8)
                                    {
                                        throw new ISBnDifferentFromEightException();
                                    }
                                    Console.WriteLine("Circulation: ");
                                    int circulation = int.Parse(Console.ReadLine());
                                    bool check = circulation >= 1 && circulation <= 10;
                                    if (!check)
                                    {
                                        throw new CirculationNotBetweenOneAndTen();
                                    }
                                    Console.WriteLine("Finish Date: ");
                                    DateTime dateTime = DateTime.Today;
                                    DateTime dateTime1 = DateTime.Parse(Console.ReadLine());
                                    TimeSpan timeSpan = dateTime1 - dateTime;
                                    int durationPeriod = timeSpan.Days;
                                    duration = durationPeriod;                                                    
                                    Book book = new Book(name, author, isbn, circulation, durationPeriod);
                                    
                                    library.AddBook(book);
                                    library.ShowAllBook();
                                }
                                catch (NameEmptyException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (AuthorEmptyException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (ISBnDifferentFromEightException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (CirculationNotBetweenOneAndTen ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                               
                                Thread.Sleep(10000);
                                break;
                            case 1:
                                string id;
                                Console.WriteLine("Include Book Id");
                                id = Console.ReadLine();
                                
                                library.RemoveByIdFromBook(id);
                                Console.Clear();
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("Arxive Kitab qeydiyyatı  Zehmet olmasa melumatlari daxil edin");
                                Console.WriteLine("Name: ");
                                string name1 = Console.ReadLine();
                                Console.WriteLine("Author: ");
                                string author1 = Console.ReadLine();
                                Console.WriteLine("isbn: ");
                                int isbn1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Circulation: ");
                                int circulation1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Duration Period: ");
                                int durationPeriod1 = int.Parse(Console.ReadLine());

                                Book book1 = new Book(name1, author1, isbn1, circulation1, durationPeriod1);
                                
                                archive.AddBook(book1);
                                id = Console.ReadLine();
                                library.RemoveByIdFromBook(book1.CardId.ToString());
                                archive.ShowAllBook();
                                Thread.Sleep(10000);
                                break;
                            case 3:
                                string id3;
                                Console.WriteLine("Include Book Id");
                                id3 = Console.ReadLine();
                                
                                archive.RemoveByIdFromBook(id3);
                                Console.Clear();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Librarydeki Butun Kitablarin Siyahisi");
                                
                                library.ShowAllBook();
                                Thread.Sleep(2000);
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Achivedeki Butun Kitablarin Siyahisi");
                                
                                archive.ShowAllBook();
                                Thread.Sleep(2000);
                                break;
                            case 6:
                                returnBack1 = false;
                                break;
                        }
                    }

                } while (returnBack1);
                break;
            case 2:
                Console.Clear();
                int numx3 = 0;
                char[] arr3 = { '>', ' ', ' ' };
                bool returnBack2 = true;
                do
                {
                    Console.WriteLine($"{arr3[0]} Give book to Reader from Library");
                    Console.WriteLine($"{arr3[1]} Give book to Reader from Archive");
                    Console.WriteLine($"{arr3[2]} Back");

                    var keyInfo3 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo3.Key == ConsoleKey.DownArrow)
                    {
                        if (numx3 < 2)
                            Swap(ref arr3[numx3], ref arr3[++numx3]);
                    }
                    else if (keyInfo3.Key == ConsoleKey.UpArrow)
                    {
                        if (numx3 > 0)
                            Swap(ref arr3[numx3], ref arr3[--numx3]);
                    }
                    else if (keyInfo3.Key == ConsoleKey.Enter)
                    {
                        switch (numx3)
                        {
                            case 0:
                                Console.WriteLine("Include Reader Id");
                                string readerId = Console.ReadLine();
                                Console.WriteLine("Include book Id");
                                string bookId = Console.ReadLine();
                                
                                
                                try
                                {
                                    if (library.AssignBookToReaderFromLibrary(readerId, bookId))
                                    {
                                        readerBook.Add(readerId, bookId);
                                        library.RemoveByIdFromBook(bookId);
                                        library.RemoveByIdFromReader(readerId);
                                    }
                                }
                                catch (NotFoundSameBookAsThisIdException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (NotFoundSameReaderAsThisIdException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                readerBook.ShowAllDictionary();
                                break;
                            case 1:
                                Console.WriteLine("Include Reader Id");
                                string readerId1 = Console.ReadLine();
                                Console.WriteLine("Include book Id");
                                string bookId1 = Console.ReadLine();
                                
                                
                                
                                try
                                {
                                    if (archive.AssignBookToReaderFromArchive(bookId1))
                                    {
                                        readerBook.Add(readerId1, bookId1);
                                        archive.RemoveByIdFromBook(bookId1);
                                        library.RemoveByIdFromReader(readerId1);
                                    }
                                }
                                catch (NotFoundSameBookAsThisIdException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (NotFoundSameReaderAsThisIdException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                readerBook.ShowAllDictionary();
                                break;
                            case 2:
                                returnBack2 = false;
                                break;
                        }
                    }

                } while (returnBack2);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Axtarisi neye gore edeceksiniz");

                int numx4 = 0;
                char[] arr4 = { '>', ' ', ' ', ' ', ' ', ' ' };
                bool returnBack4 = true;
                do
                {
                    Console.WriteLine($"{arr4[0]} By Book Name");
                    Console.WriteLine($"{arr4[1]} By Author Name");
                    Console.WriteLine($"{arr4[2]} By İSBM");
                    Console.WriteLine($"{arr4[3]} By Circulation");
                    Console.WriteLine($"{arr4[4]} By DurtionPeriod");
                    Console.WriteLine($"{arr4[5]} Back");

                    var keyInfo4 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo4.Key == ConsoleKey.DownArrow)
                    {
                        if (numx4 < 5)
                            Swap(ref arr4[numx4], ref arr4[++numx4]);
                    }
                    else if (keyInfo4.Key == ConsoleKey.UpArrow)
                    {
                        if (numx4 > 0)
                            Swap(ref arr4[numx4], ref arr4[--numx4]);
                    }
                    else if (keyInfo4.Key == ConsoleKey.Enter)
                    {
                        switch (numx4)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("Please include Book name");
                                string name = Console.ReadLine();
                              
                                var data = bookManager.SearchByBookName(name);
                                foreach (var item in data)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);

                                break;
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Please include Author name");
                                string name1 = Console.ReadLine();
                               
                                var data1 = bookManager.SearchByAuthorName(name1);
                                foreach (var item in data1)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Please include isbn");
                                int isbn = int.Parse(Console.ReadLine());
                                
                                var data2 = bookManager.SearchByISBN(isbn);
                                foreach (var item in data2)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Please include Circulation");
                                int circulation = int.Parse(Console.ReadLine());
                                
                                var data3 = bookManager.SearchByCirculation(circulation);
                                foreach (var item in data3)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Please include Duration Period");
                                int durationPeriod = int.Parse(Console.ReadLine());
                                
                                var data4 = bookManager.SearchByISBN(durationPeriod);
                                foreach (var item in data4)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 5:
                                returnBack4 = false;
                                break;
                        }
                    }

                } while (returnBack4);
                break;

            case 4:
                Console.Clear();
                Console.WriteLine("Axtarisi neye gore edeceksiniz");
                int numx5 = 0;
                char[] arr5 = { '>', ' ', ' ', ' ', ' ', ' ', ' ' };
                bool returnBack5 = true;
                do
                {
                    Console.WriteLine($"{arr5[0]} By Name");
                    Console.WriteLine($"{arr5[1]} By Surname");
                    Console.WriteLine($"{arr5[2]} By Age");
                    Console.WriteLine($"{arr5[3]} By Phone Number");
                    Console.WriteLine($"{arr5[4]} By Mail");
                    Console.WriteLine($"{arr5[5]} By Home Address");
                    Console.WriteLine($"{arr5[6]} Back");


                    var keyInfo5 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo5.Key == ConsoleKey.DownArrow)
                    {
                        if (numx5 < 6)
                            Swap(ref arr5[numx5], ref arr5[++numx5]);
                    }
                    else if (keyInfo5.Key == ConsoleKey.UpArrow)
                    {
                        if (numx5 > 0)
                            Swap(ref arr5[numx5], ref arr5[--numx5]);
                    }
                    else if (keyInfo5.Key == ConsoleKey.Enter)
                    {
                        switch (numx5)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("Please include name");
                                string name = Console.ReadLine();
                                ReaderManager readerManager = new ReaderManager();
                                var data1 = readerManager.SearchByName(name);
                                foreach (var item in data1)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Please include surname");
                                string surname = Console.ReadLine();
                                ReaderManager readerManager1 = new ReaderManager();
                                var data2 = readerManager1.SearchBySurname(surname);
                                foreach (var item in data2)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Please include age");
                                int age = int.Parse(Console.ReadLine());
                                ReaderManager readerManager2 = new ReaderManager();
                                var data3 = readerManager2.SearchByAge(age);
                                foreach (var item in data3)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Please include Phone Number");
                                string phoneNumber = Console.ReadLine();
                                ReaderManager readerManager3 = new ReaderManager();
                                var data4 = readerManager3.SearchByPhoneNumber(phoneNumber);
                                foreach (var item in data4)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Please include Mail");
                                string mail = Console.ReadLine();
                                ReaderManager readerManager4 = new ReaderManager();
                                var data5 = readerManager4.SearchByMail(mail);
                                foreach (var item in data5)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Please include Home Address");
                                string homeAddress = Console.ReadLine();
                                ReaderManager readerManager5 = new ReaderManager();
                                var data6 = readerManager5.SearchByHomeAddress(homeAddress);
                                foreach (var item in data6)
                                {
                                    Console.WriteLine(item);
                                }
                                Thread.Sleep(10000);
                                break;
                            case 6:
                                returnBack5 = false;
                                break;
                        }
                    }
                } while (returnBack5);
                break;
        }
    }
} while (true);





